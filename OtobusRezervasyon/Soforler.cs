using OtobusYonetimi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Otobilet
{
    public partial class Soforler : Form
    {
        public Soforler()
        {
            InitializeComponent();
            Con = new Fonksiyonlar();
            SoforleriGoster();
            this.FormClosing += new FormClosingEventHandler(this.Soforler_FormClosing);
        }

        Fonksiyonlar Con;

        private void SoforleriGoster()
        {
            string Query = "select * from SoforTbl";
            SoforDgv.DataSource = Con.GetData(Query);
        }

        private void Temizle()
        {
            SAdTb.Text = "";
            STelefonMtb.Text = "";
            SCinsiyetTb.Text = "";
            SAdresTb.Text = "";
            SDeneyimTb.Text = "";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void YeniSoforEkleBtn_Click(object sender, EventArgs e)
        {
            if (SAdTb.Text == "" || STelefonMtb.Text == "" || SCinsiyetTb.Text == "" || SAdresTb.Text == "" || SDeneyimTb.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız!");
            }
            else
            {
                try
                {
                    string STelefon = STelefonMtb.Text;
                    string SAd = SAdTb.Text;
                    int SDeneyim = Convert.ToInt32(SDeneyimTb.Text);
                    string SAdres = SAdresTb.Text;
                    string SCinsiyet = SCinsiyetTb.Text;
                    string Query = "insert into SoforTbl values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}' )";
                    Query = string.Format(Query, SAd, SCinsiyet, STelefon, SAdres, SDeneyim, SDogumDtp.Value.Date.ToString("yyyy-MM-dd"));
                    Con.setData(Query);
                    MessageBox.Show("Soför Eklendi!");
                    SoforleriGoster();
                    Temizle();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {Ex.Message}\nLütfen destek ekibiyle iletişime geçin.");
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }



        int Key = 0;
        private void SoforDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SoforDgv.CurrentRow != null)
            {
                SAdTb.Text = SoforDgv.CurrentRow.Cells[1].Value.ToString();
                SCinsiyetTb.Text = SoforDgv.CurrentRow.Cells[2].Value.ToString();
                STelefonMtb.Text = SoforDgv.CurrentRow.Cells[3].Value.ToString();
                SAdresTb.Text = SoforDgv.CurrentRow.Cells[4].Value.ToString();
                SDeneyimTb.Text = SoforDgv.CurrentRow.Cells[5].Value.ToString();
                SDogumDtp.Text = SoforDgv.CurrentRow.Cells[6].Value.ToString();

                // Anahtar değeri güncelle
                if (string.IsNullOrEmpty(SAdTb.Text))
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(SoforDgv.CurrentRow.Cells[0].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir satır seçilmedi.");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (SAdTb.Text == "" || STelefonMtb.Text == "" || SCinsiyetTb.Text == "" || SDeneyimTb.Text == "" || SAdresTb.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız!");
            }
            else
            {
                try
                {
                    string STelefon = STelefonMtb.Text;
                    string SAd = SAdTb.Text;
                    int SDeneyim = Convert.ToInt32(SDeneyimTb.Text);
                    string SCinsiyet = SCinsiyetTb.Text;
                    string SAdres = SAdresTb.Text;
                    string Query = "update SoforTbl set SAd = '{0}', SCinsiyet = '{1}', STelefon = '{2}', SAdres = '{3}', SDeneyim = '{4}', SDogum = '{5}' where SKod = {6} ";
                    Query = string.Format(Query, SAd, SCinsiyet, STelefon, SAdres, SDeneyim, SDogumDtp.Value.Date.ToString("yyyy-MM-dd"), Key);
                    Con.setData(Query);
                    MessageBox.Show("Soför Güncellendi!");
                    SoforleriGoster();
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
            if (Key == 0)
            {
                MessageBox.Show("Soför Seçiniz!");
            }
            else
            {
                try
                {
                    string Query = "delete from SoforTbl where SKod = {0}";
                    Query = string.Format(Query, Key);
                    Con.setData(Query);
                    MessageBox.Show("Soför Silindi!");
                    SoforleriGoster();
                    Temizle();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {Ex.Message}\nLütfen destek ekibiyle iletişime geçin.");
                }
            }
        }

        private void Soforler_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Soforler_FormClosing(object sender, FormClosingEventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Yolcular Obj = new Yolcular();
            Obj.Show();
            this.Hide();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Otobus Obj = new Otobus();
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
