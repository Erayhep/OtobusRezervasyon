using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OtobusYonetimi;

namespace Otobilet
{
    public partial class Rezervasyonlar : Form
    {
        public Rezervasyonlar()
        {
            InitializeComponent();
            Con = new Fonksiyonlar();
            this.FormClosing += new FormClosingEventHandler(this.Rezervasyonlar_FormClosing);
        }
        Fonksiyonlar Con;

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void LoadAllRezervasyonlar()
        {
            try
            {
                string query = "SELECT SeferID, KoltukNo, Isim, Telefon, Cinsiyet FROM RezervasyonTbl";
                DataTable dt = Con.GetData(query);
                rezervasyonlarDvg.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Rezervasyonlar_Load(object sender, EventArgs e)
        {
            LoadAllRezervasyonlar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Otobus Obj = new Otobus();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Soforler Obj = new Soforler();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Giris Obj = new Giris();
            Obj.Show();
            this.Hide();
        }
        private void Rezervasyonlar_FormClosing(object sender, FormClosingEventArgs e)
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Ayarlar Obj = new Ayarlar();
            Obj.Show();
            this.Hide();
        }
    }
}
