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
    public partial class BiletAL : Form
    {
        public BiletAL()
        {
            InitializeComponent();
            Con = new Fonksiyonlar();
            this.FormClosing += new FormClosingEventHandler(this.BiletAL_FormClosing);
        }
        Fonksiyonlar Con;

        // Kullanıcı ID'sini burada tutabilirsiniz
        public string UserID { get; set; } = "1"; // Örnek olarak varsayılan bir ID verdim.

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BiletAL_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=DESKTOP-LDVGBVA\SQLEXPRESS;Initial Catalog=OtobiletDb;Integrated Security=True;";
            string query = "SELECT Ad FROM kayitTbl WHERE UserID = @UserID";


            try
            {
                // SQL bağlantısını ve sorguyu çalıştırma
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", UserID);

                    // Sorgudan kullanıcı adını çekiyoruz
                    string kullaniciAd = command.ExecuteScalar()?.ToString();

                    if (!string.IsNullOrEmpty(kullaniciAd))
                    {
                        label2.Text = $"Hoş geldiniz, {kullaniciAd}!";
                    }
                    else
                    {
                        label2.Text = "Hoş geldiniz!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FillOtobusCmb();
            FillSeferSaatCmb();
            FillNeredenVeNereye();

            // Başlangıçta tüm seferleri getirin
            SeferleriFiltrele();
        }
        private void SeferleriFiltrele()
        {
            try
            {
                string baseQuery = @"SELECT S.SEKod, S.Sefer_Saat, S.Sefer_Tarih, O.Otobus, O.Kapasite,
                         S.Nereden, S.Nereye, S.SoforAd AS SoforAd
                         FROM SeferTbl S
                         JOIN OtobusTbl O ON S.Otobus = O.OKod
                         WHERE 1=1";  // Sorgu

                DataTable dt = Con.GetData(baseQuery);  // Parametreli GetData çağrılıyor

                // Eğer veri yoksa kullanıcıyı bilgilendirin
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Sefer tablosunda görüntülenecek veri bulunamadı.");
                }
                else
                {
                    // DataGridView'e veri bağlayın
                    biletAlDvg.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillOtobusCmb()
        {
            string query = "SELECT OKod, Otobus FROM OtobusTbl";
            DataTable dt = Con.GetData(query);
            OtobusCmb.DataSource = dt;
            OtobusCmb.DisplayMember = "Otobus";
            OtobusCmb.ValueMember = "OKod";
        }

        private void FillSeferSaatCmb()
        {
            string query = "SELECT DISTINCT Sefer_Saat FROM SeferTbl";
            DataTable dt = Con.GetData(query);
            SeferSaatCmb.DataSource = dt;
            SeferSaatCmb.DisplayMember = "Sefer_Saat";
        }

        private void FillNeredenVeNereye()
        {
            string query = "SELECT DISTINCT Nereden FROM SeferTbl UNION SELECT DISTINCT Nereye FROM SeferTbl";
            DataTable dt = Con.GetData(query);

            // Nereden ComboBox için veri kaynağını ayarlıyoruz
            NeredenCmb.DataSource = dt;
            NeredenCmb.DisplayMember = "Nereden"; // Nereden kolonunu görüntüle

            // Nereye ComboBox için veri kaynağını ayarlıyoruz
            NereyeCmb.DataSource = dt.Copy();
            NereyeCmb.DisplayMember = "Nereye"; // Nereye kolonunu görüntüle
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (biletAlDvg.SelectedRows.Count > 0)
            {
                int selectedSeferID = Convert.ToInt32(biletAlDvg.SelectedRows[0].Cells["SEKod"].Value);
                MessageBox.Show($"Sefer seçildi! Sefer ID: {selectedSeferID}");

                // Seçilen Sefer ID'sini Detaylar formuna aktar
                Detaylar detaylarForm = new Detaylar(selectedSeferID); // Sefer ID'sini parametre olarak veriyoruz
                detaylarForm.Show();
                this.Hide(); // BiletAl formunu gizle
            }
            else
            {
                MessageBox.Show("Lütfen bir sefer seçin!");
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Giris Obj = new Giris();
            Obj.Show();
            this.Hide();
        }
        private void BiletAL_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Rezervasyonlarim Obj = new Rezervasyonlarim();
            Obj.Show();
            this.Hide();
        }
    }
}

