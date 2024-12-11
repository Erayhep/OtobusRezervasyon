using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobilet
{
    public partial class Detaylar : Form
    {
        private int selectedSeferID;
        public Detaylar(int seferID)
        {
            InitializeComponent();
            Con = new Fonksiyonlar();
            this.FormClosing += new FormClosingEventHandler(this.Detaylar_FormClosing);
            selectedSeferID = seferID; // Sefer ID'sini alıyoruz

        }
        Fonksiyonlar Con;

        private void Detaylar_Load(object sender, EventArgs e)
        {
            // Seferin detaylarını getir ve göster
            string query = @"
            SELECT S.SEKod, S.Sefer_Saat, S.Sefer_Tarih, O.Otobus, O.Kapasite, S.Nereden, S.Nereye, S.SoforAd 
            FROM SeferTbl S
            JOIN OtobusTbl O ON S.Otobus = O.OKod
            WHERE S.SEKod = @SeferID";

            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@SeferID", SqlDbType.Int) { Value = selectedSeferID }
                };

                DataTable dt = Con.GetData(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    detaylarDvg.DataSource = dt;

                    // Kapasite bilgisini al
                    int kapasite = Convert.ToInt32(dt.Rows[0]["Kapasite"]);

                    // Koltukları oluştur
                    KoltuklariOlustur(kapasite);

                    // Dolu koltukları işaretle
                    List<int> doluKoltuklar = GetDoluKoltuklar(selectedSeferID);
                    DoluKoltuklariIsaretle(doluKoltuklar);
                }
                else
                {
                    MessageBox.Show("Sefer bilgisi bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void KoltuklariOlustur(int kapasite)
        {

            koltukPanel.Controls.Clear();
            int koltukNumarasi = 1;
            int x, y = 10;

            for (int i = 0; i < kapasite / 4; i++)
            {
                x = 10;

                // Sol ve sağ taraf koltukları
                for (int j = 0; j < 4; j++)
                {
                    Button koltuk = new Button
                    {
                        Width = 50,
                        Height = 50,
                        Text = koltukNumarasi.ToString(),
                        Tag = koltukNumarasi,
                        BackColor = Color.Green,
                        Location = new Point(x, y)
                    };

                    koltuk.Click += Koltuk_Click;
                    koltukPanel.Controls.Add(koltuk);
                    koltukNumarasi++;
                    x += 60 + (j == 1 ? 40 : 0); // Koridor boşluğu
                }

                y += 60;
            }

            // Artan koltuklar (arka sıra için)
            x = 10;
            y += 10;
            for (int i = 0; i < kapasite % 4; i++)
            {
                Button koltuk = new Button
                {
                    Width = 50,
                    Height = 50,
                    Text = koltukNumarasi.ToString(),
                    Tag = koltukNumarasi,
                    BackColor = Color.Green,
                    Location = new Point(x, y)
                };

                koltuk.Click += Koltuk_Click;
                koltukPanel.Controls.Add(koltuk);
                koltukNumarasi++;
                x += 60;
            }
        }
        private List<int> GetDoluKoltuklar(int seferID)
        {
            List<int> doluKoltuklar = new List<int>();
            string query = "SELECT KoltukNo FROM RezervasyonTbl WHERE SeferID = @SeferID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SeferID", SqlDbType.Int) { Value = seferID }
            };

            DataTable dt = Con.GetData(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                doluKoltuklar.Add(Convert.ToInt32(row["KoltukNo"]));
            }

            return doluKoltuklar;
        }

        private void DoluKoltuklariIsaretle(List<int> doluKoltuklar)
        {
            foreach (Control control in koltukPanel.Controls)
            {
                if (control is Button koltuk && doluKoltuklar.Contains(Convert.ToInt32(koltuk.Tag)))
                {
                    koltuk.BackColor = Color.Red;
                    koltuk.Enabled = false;
                }
            }
        }
        private void Koltuk_Click(object sender, EventArgs e)
        {
            Button selectedKoltuk = sender as Button;

            if (selectedKoltuk != null)
            {
                int koltukNumarasi = Convert.ToInt32(selectedKoltuk.Tag);
                MessageBox.Show($"Seçilen Koltuk: {koltukNumarasi}", "Koltuk Seçimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedKoltuk.BackColor = Color.Blue;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan alınan veriler
                int seferID = selectedSeferID;  // Sefer ID'si
                int koltukNo = Convert.ToInt32(koltukPanel.Controls.OfType<Button>()
                    .FirstOrDefault(b => b.BackColor == Color.Blue)?.Tag);  // Seçilen koltuk numarası
                string Isim = BiletAdTb.Text;  // Bilet adı
                string Telefon = BiletTelTb.Text;  // Bilet telefon numarası
                string cinsiyet = BiletErkekRbtn.Checked ? "Erkek" : "Kadın";  // Cinsiyet

                // Seçilen koltuk numarasının dolu olup olmadığını kontrol et
                List<int> doluKoltuklar = GetDoluKoltuklar(seferID);
                if (doluKoltuklar.Contains(koltukNo))
                {
                    MessageBox.Show("Bu koltuk zaten rezerve edilmiş.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // SQL sorgusunu oluştur
                string query = @"INSERT INTO RezervasyonTbl (SeferID, KoltukNo, Isim, Telefon, Cinsiyet)
                         VALUES (@SeferID, @KoltukNo, @Isim, @Telefon, @Cinsiyet)";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@SeferID", SqlDbType.Int) { Value = seferID },
            new SqlParameter("@KoltukNo", SqlDbType.Int) { Value = koltukNo },
            new SqlParameter("@Isim", SqlDbType.NVarChar) { Value = Isim },
            new SqlParameter("@Telefon", SqlDbType.NVarChar) { Value = Telefon },
            new SqlParameter("@Cinsiyet", SqlDbType.NVarChar) { Value = cinsiyet }
                };

                // Veriyi ekle
                int rowsAffected = Con.setData(query, parameters);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Rezervasyon başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Koltuğu işaretle ve disable et
                    koltukPanel.Controls.OfType<Button>().FirstOrDefault(b => Convert.ToInt32(b.Tag) == koltukNo).BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool RezervasyonKaydet(int seferID, int koltukNo, string ad, string telefon, bool erkek, bool kadin)
        {
            try
            {
                string query = @"
        INSERT INTO RezervasyonTbl (SeferID, KoltukNo, Isim, Telefon, Cinsiyet)
        VALUES (@SeferID, @KoltukNo, @Isim, @Telefon, @Cinsiyet)";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@SeferID", SqlDbType.Int) { Value = seferID },
            new SqlParameter("@KoltukNo", SqlDbType.Int) { Value = koltukNo },
            new SqlParameter("@Isim", SqlDbType.NVarChar, 100) { Value = ad },
            new SqlParameter("@Telefon", SqlDbType.NVarChar, 20) { Value = telefon },
            new SqlParameter("@Cinsiyet", SqlDbType.NVarChar, 10) { Value = erkek ? "Erkek" : "Kadın" }
                };

                int result = Con.setData(query, parameters); // setData metodunu kullan

                return result > 0; // Eğer başarılı bir şekilde veri eklendiyse true döner
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void Detaylar_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Burada uygulama kapanmadan önce yapılacak işlemleri ekleyebilirsiniz
            // Örneğin, kullanıcıdan onay almak için bir MessageBox ekleyebiliriz:

            DialogResult result = MessageBox.Show("Uygulamayı kapatmak istediğinizden emin misiniz?", "Kapat", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Kapatmayı iptal eder
            }
            else
            {
                Application.Exit(); // Uygulamayı tamamen kapatır
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Giris Obj = new Giris();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BiletAL Obj = new BiletAL();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Rezervasyonlarim Obj = new Rezervasyonlarim();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
