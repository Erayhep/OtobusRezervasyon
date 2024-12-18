﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OtobusYonetimi;
using OtobusRezervasyon;
using System.Data.SqlClient;

namespace Otobilet
{
    public partial class Sefer : Form
    {
        public Sefer()
        {
            InitializeComponent();
            Con = new Fonksiyonlar();
            SeferleriGoster();
            this.FormClosing += new FormClosingEventHandler(this.Sefer_FormClosing);
        }
        Fonksiyonlar Con;
        private void SeferleriGoster()
        {
            string query = @"SELECT S.SEKod, O.Otobus, S.Nereden, S.Nereye, S.Sefer_Tarih, S.Sefer_Saat, S.Fiyat, SF.SoforAd
            FROM SeferTbl S
            JOIN SoforTbl SF ON S.SoforAd = SF.SoforAd
            JOIN OtobusTbl O ON S.Otobus = O.OKod"; // OtobusTbl'deki Otobus ismini seçiyoruz

            DataTable dt = Con.GetData(query); // Veritabanından verileri çek
            SeferlerDgv.DataSource = dt;       // DataGridView'e verileri yükle
        }

        private void Temizle()
        {
            SOtobusCmb.Text = "";
            STarihDtp.Text = "";
            SNeredenCmb.Text = "";
            SNereyeCmb.Text = "";
            SSaatMtb.Text = "";
            SFiyatMtb.Text = "";
            SSoforCmb.Text = "";
        }

        private void FillOtobusCmb()
        {
            string query = "SELECT OKod, Otobus FROM OtobusTbl";  // Otobüs tablosundan veri çekme sorgusu
            DataTable dt = Con.GetData(query);

            SOtobusCmb.DataSource = dt;  // ComboBox'a verileri yerleştiriyoruz
            SOtobusCmb.DisplayMember = "Otobus";  // ComboBox'ta görünen değer
            SOtobusCmb.ValueMember = "OKod";     // ComboBox'ta saklanan (gizli) değer (OKod, otobüsün ID'si)

        }

        private void FillSoforCmb()
        {
            string query = "SELECT SKod, SoforAd FROM SoforTbl";  // Şoför tablosundan veri çekme sorgusu
            DataTable dt = Con.GetData(query);  // Direkt sorgu string'i gönderiliyor

            SSoforCmb.DataSource = dt;  // ComboBox'a verileri yerleştiriyoruz
            SSoforCmb.DisplayMember = "SoforAd";  // ComboBox'ta görünen değer
            SSoforCmb.ValueMember = "SKod";       // ComboBox'ta saklanan (gizli) değer (SKod, şoförün ID'si)
        }
        private void Sefer_Load(object sender, EventArgs e)
        {
            FillOtobusCmb();
            FillSoforCmb();
        }
        private void YSEkleBtn_Click(object sender, EventArgs e)
        {
            if (SOtobusCmb.Text == "" || STarihDtp.Text == "" || SNeredenCmb.Text == "" || SNereyeCmb.Text == "" || SSaatMtb.Text == "" || SFiyatMtb.Text == "" || SSoforCmb.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız!");
            }
            else
            {
                try
                {
                    // Form üzerindeki alanlardan değerleri alıyoruz
                    //string Otobus = SOtobusCmb.Text;                // Otobüs adı
                    string Tarih = STarihDtp.Value.ToString("yyyy-MM-dd"); // Tarih formatını veritabanına uygun şekilde ayarlıyoruz
                    string Nereden = SNeredenCmb.Text;             // Nereden bilgisi
                    string Nereye = SNereyeCmb.Text;               // Nereye bilgisi
                    string Saat = SSaatMtb.Text;                   // Sefer saati
                    int Fiyat = Convert.ToInt32(SFiyatMtb.Text);   // Fiyat bilgisi
                    string SoforAd = SSoforCmb.Text;                 // Şoför adı
                    int OtobusID = Convert.ToInt32(SOtobusCmb.SelectedValue);

                    string query = "INSERT INTO SeferTbl (Otobus, Nereden, Nereye, Sefer_Tarih, Sefer_Saat, SoforAd, Fiyat) " +
               "VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', {6})";
                    query = string.Format(query, OtobusID, Nereden, Nereye, Tarih, Saat, SoforAd, Fiyat);
                    Con.setData(query);

                    MessageBox.Show("Sefer Başarıyla Eklendi!");
                    SeferleriGoster(); // Seferleri güncel listelemek için çağrılıyor
                    Temizle();         // Formdaki alanları temizliyoruz
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}\nLütfen destek ekibiyle iletişime geçin.");
                }
            }
        }
        int Key = 0;
        private void SeferlerDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Satırın seçildiğinden emin olun
            {
                DataGridViewRow row = SeferlerDgv.Rows[e.RowIndex];  // Seferler DataGridView'i

                // Hücrelerdeki verilere doğru şekilde erişmek için, her bir hücreyi tek tek alıyoruz
                SOtobusCmb.Text = row.Cells["Otobus"].Value.ToString();  // Otobus adı
                SNeredenCmb.Text = row.Cells["Nereden"].Value.ToString();  // Nereden
                SNereyeCmb.Text = row.Cells["Nereye"].Value.ToString();    // Nereye
                STarihDtp.Value = Convert.ToDateTime(row.Cells["Sefer_Tarih"].Value);  // Sefer Tarihi
                SSaatMtb.Text = row.Cells["Sefer_Saat"].Value.ToString();  // Sefer Saati
                SSoforCmb.Text = row.Cells["SoforAd"].Value.ToString();  // Şoför adı
                SFiyatMtb.Text = row.Cells["Fiyat"].Value.ToString();  // Fiyat

                // Seçilen seferin ID'sini (SEKod) kaydediyoruz
                Key = Convert.ToInt32(row.Cells["SEKod"].Value);  // SEKod, SeferTbl tablosundaki anahtar
            }
        }

        private void YGuncelleBtn_Click(object sender, EventArgs e)
        {
            if (SOtobusCmb.Text == "" || SSoforCmb.Text == "" || SFiyatMtb.Text == "" || SNeredenCmb.Text == "" || SNereyeCmb.Text == "" || SSaatMtb.Text == "" || STarihDtp.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız!");
            }
            else
            {
                try
                {
                    string SOtobus = SOtobusCmb.Text;  // Otobüs adı
                    string SSofor = SSoforCmb.Text;    // Şoför adı
                    int SFiyat = Convert.ToInt32(SFiyatMtb.Text);  // Fiyat bilgisi
                    string SNereden = SNeredenCmb.Text;  // Nereden
                    string SNereye = SNereyeCmb.Text;   // Nereye
                    string SSaat = SSaatMtb.Text;       // Sefer saati
                    DateTime STarih = STarihDtp.Value;  // Sefer tarihi

                    // Otobüsün ID'sini almak için sorgu yazıyoruz (parametreli sorgu)
                    string otobusQuery = "SELECT OKod FROM OtobusTbl WHERE Otobus = @Otobus";

                    // Otobüs verisini almak için parametre ekliyoruz
                    SqlParameter[] parameters = new SqlParameter[]
                    {
        new SqlParameter("@Otobus", SOtobus)
                    };

                    // Otobüs verisini alıyoruz
                    DataTable otobusDt = Con.GetData(otobusQuery, parameters);  // Veriyi çekiyoruz

                    // Eğer otobüs bulunursa, güncellemeyi yapıyoruz
                    if (otobusDt.Rows.Count > 0)
                    {
                        int otobusID = Convert.ToInt32(otobusDt.Rows[0]["OKod"]);  // Otobüs ID'si

                        // Sefer tablosu güncelleme sorgusu
                        string Query = "UPDATE SeferTbl SET Otobus = @Otobus, SoforAd = @SoforAd, Fiyat = @Fiyat, Nereden = @Nereden, Nereye = @Nereye, Sefer_Saat = @SeferSaat, Sefer_Tarih = @SeferTarih WHERE SEKod = @SEKod";

                        // Parametreler
                        SqlParameter[] updateParameters = new SqlParameter[]
                        {
            new SqlParameter("@Otobus", otobusID),
            new SqlParameter("@SoforAd", SSofor),
            new SqlParameter("@Fiyat", SFiyat),
            new SqlParameter("@Nereden", SNereden),
            new SqlParameter("@Nereye", SNereye),
            new SqlParameter("@SeferSaat", SSaat),
            new SqlParameter("@SeferTarih", STarih.ToString("yyyy-MM-dd")),
            new SqlParameter("@SEKod", Key)  // Key'yi parametre olarak ekledik
                        };

                        // Veritabanına sorguyu gönder
                        Con.setData(Query, updateParameters);  // Veritabanına güncelleme sorgusunu gönderiyoruz

                        MessageBox.Show("Sefer Güncellendi!");
                        SeferleriGoster();  // Güncellenen verileri göster
                        Temizle();  // Formu temizle
                    }
                    else
                    {
                        MessageBox.Show("Seçilen otobüs bulunamadı!");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {Ex.Message}\nLütfen destek ekibiyle iletişime geçin.");
                }
            }
            }

        private void SSilBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Sefer Seçiniz!");
            }
            else
            {
                try
                {
                    // Sefer silme sorgusu
                    string Query = "DELETE FROM SeferTbl WHERE SEKod = {0}";
                    Query = string.Format(Query, Key);

                    // Veritabanına sorguyu gönder
                    Con.setData(Query);
                    MessageBox.Show("Sefer Silindi!");
                    SeferleriGoster();  // Güncellenen verileri göster
                    Temizle();  // Formu temizle

                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {Ex.Message}\nLütfen destek ekibiyle iletişime geçin.");
                }
            }
        }
        private void Sefer_FormClosing(object sender, FormClosingEventArgs e)
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
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Otobus Obj = new Otobus();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Yolcular Obj = new Yolcular();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Soforler Obj = new Soforler();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Rezervasyonlar Obj = new Rezervasyonlar();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Giris Obj = new Giris();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Ayarlar Obj = new Ayarlar();
            Obj.Show();
            this.Hide();
        }
    }
}
