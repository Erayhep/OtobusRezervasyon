using OtobusYonetimi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otobilet
{
    public partial class Otobus : Form
    {
        public Otobus()
        {
            InitializeComponent();
            Con = new Fonksiyonlar();
            OtobusleriGoster();
            this.FormClosing += new FormClosingEventHandler(this.Otobus_FormClosing);
        }
        Fonksiyonlar Con;

        private void OtobusleriGoster()
        {
            string query = "SELECT * FROM OtobusTbl";  // Otobüs tablosundan veri çekme sorgusu
            DataTable dt = Con.GetData(query);  // Parametreli GetData metodunu çağırıyoruz (string parametre)

            OtobusDgv.DataSource = dt;  // DataGridView'e veri bağlama
        }

        private void Temizle()
        {
            OAdTb.Clear();
            ONumaraTb.Clear();
            OKapasiteTb.Clear();
            ODurumTb.Clear();
            OSeferTb.Clear();
        }

        private void YOEkleBtn_Click(object sender, EventArgs e)
        {
            if (OAdTb.Text == "" || ONumaraTb.Text == "" || OKapasiteTb.Text == "" || ODurumTb.Text == "" || OSeferTb.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız!");
            }
            else
            {
                try
                {
                    string ONumara = ONumaraTb.Text;
                    string OAd = OAdTb.Text;
                    int Kapasite = Convert.ToInt32(OKapasiteTb.Text);
                    string Durum = ODurumTb.Text;
                    string SeferSaat = OSeferTb.Text;
                    string Query = "insert into OtobusTbl values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}' )";
                    Query = string.Format(Query, OAd, ONumara, Kapasite, Durum, SeferSaat, OTarihDtp.Value.Date.ToString("yyyy-MM-dd"));
                    Con.setData(Query);
                    MessageBox.Show("Otobüs Eklendi!");
                    OtobusleriGoster();
                    Temizle();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {Ex.Message}\nLütfen destek ekibiyle iletişime geçin.");
                }
            }

        }

        int Key = 0;
        private void OtobusDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OtobusDgv.CurrentRow != null)
            {
                OAdTb.Text = OtobusDgv.CurrentRow.Cells[1].Value.ToString();
                ONumaraTb.Text = OtobusDgv.CurrentRow.Cells[2].Value.ToString();
                OKapasiteTb.Text = OtobusDgv.CurrentRow.Cells[3].Value.ToString();
                ODurumTb.Text = OtobusDgv.CurrentRow.Cells[4].Value.ToString();
                OSeferTb.Text = OtobusDgv.CurrentRow.Cells[5].Value.ToString();
                OTarihDtp.Text = OtobusDgv.CurrentRow.Cells[6].Value.ToString();

                // Anahtar değeri güncelle
                if (string.IsNullOrEmpty(OAdTb.Text))
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(OtobusDgv.CurrentRow.Cells[0].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir satır seçilmedi.");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
        }
        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            if (OAdTb.Text == "" || ONumaraTb.Text == "" || OKapasiteTb.Text == "" || ODurumTb.Text == "" || OSeferTb.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız!");
            }
            else
            {
                try
                {
                    string ONumara = ONumaraTb.Text;
                    string OAd = OAdTb.Text;
                    int Kapasite = Convert.ToInt32(OKapasiteTb.Text);
                    string Durum = ODurumTb.Text;
                    string SeferSaat = OSeferTb.Text;
                    string Query = "update OtobusTbl set Otobus = '{0}', Plaka = '{1}', Kapasite = '{2}', Durum = '{3}', OSefer_Saat = '{4}', Tarih = '{5}' where OKod = {6} ";
                    Query = string.Format(Query, OAd, ONumara, Kapasite, Durum, SeferSaat, OTarihDtp.Value.Date.ToString("yyyy-MM-dd"), Key);
                    Con.setData(Query);
                    MessageBox.Show("Otobüs Güncellendi!");
                    OtobusleriGoster();
                    Temizle();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {Ex.Message}\nLütfen destek ekibiyle iletişime geçin.");
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
        }
        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Otobüs Seçiniz!");
            }
            else
            {
                try
                {
                    string Query = "delete from OtobusTbl where OKod = {0}";
                    Query = string.Format(Query, Key);
                    Con.setData(Query);
                    MessageBox.Show("Otobüs Silindi!");
                    OtobusleriGoster();
                    Temizle();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {Ex.Message}\nLütfen destek ekibiyle iletişime geçin.");
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
        // Sofor ekranına gönderir
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Soforler Obj = new Soforler();
            Obj.Show();
            this.Hide();
        }

        private void Otobus_Load(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Otobus_FormClosing(object sender, FormClosingEventArgs e)
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

        // Giriş ekranına gönderir
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Giris Obj = new Giris();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Yolcular Obj = new Yolcular();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Sefer Obj = new Sefer();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Rezervasyonlar Obj = new Rezervasyonlar();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Ayarlar Obj = new Ayarlar();
            Obj.Show();
            this.Hide();
        }
    }
}