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
using System.Security.Cryptography;
using OtobusRezervasyon;

namespace Otobilet
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
            Con = new Fonksiyonlar();
            this.FormClosing += new FormClosingEventHandler(this.Kayit_FormClosing);
        }
        Fonksiyonlar Con;
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Kayit_Load(object sender, EventArgs e)
        {

        }
        private void KayitKayitBtn_Click(object sender, EventArgs e)
        {

        }
        private void KayitKayitBtn_Click_1(object sender, EventArgs e)
        {
            string ad = KayitAdTb.Text.Trim();
            string soyad = KayitSoyadTb.Text.Trim();
            string eposta = KayitEpostaTb.Text.Trim();
            string telefon = KayitTelTb.Text.Trim();
            string cinsiyet = ErkekRbtn.Checked ? "Erkek" : (KadinRbtn.Checked ? "Kadın" : null);
            string parola = KayitSifreTb.Text;
            string parolaTekrar = KayitSifre2Tb.Text;

            // Alan doğrulama
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(eposta) ||
                string.IsNullOrEmpty(telefon) || string.IsNullOrEmpty(parola))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (parola != parolaTekrar)
            {
                MessageBox.Show("Şifreler uyuşmuyor. Lütfen kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Veritabanına kayıt işlemi
                KullaniciyiKaydet(ad, soyad, eposta, telefon, cinsiyet, parola);
                MessageBox.Show("Kayıt başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Alanların temizlenmesi
                KayitAdTb.Clear();
                KayitSoyadTb.Clear();
                KayitEpostaTb.Clear();
                KayitTelTb.Clear();
                KayitSifreTb.Clear();
                KayitSifre2Tb.Clear();
                ErkekRbtn.Checked = false;
                KadinRbtn.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void KullaniciyiKaydet(string ad, string soyad, string eposta, string telefon, string cinsiyet, string parola)
        {

            string connectionString = @"Data Source=DESKTOP-LDVGBVA\SQLEXPRESS;Initial Catalog=OtobiletDb;Integrated Security=True;"; // Bağlantı dizesi
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            INSERT INTO KayitTbl (Ad, Soyad, Eposta, Telefon, Cinsiyet, Parola) 
            VALUES (@Ad, @Soyad, @Eposta, @Telefon, @Cinsiyet, @Parola)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ad", ad);
                    cmd.Parameters.AddWithValue("@Soyad", soyad);
                    cmd.Parameters.AddWithValue("@Eposta", eposta);
                    cmd.Parameters.AddWithValue("@Telefon", telefon);
                    cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Parola", parola);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void KayitGeriBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris girisForm = new Giris();
            girisForm.Show();
        }

        private void Kayit_FormClosing(object sender, FormClosingEventArgs e)
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

    }
}
