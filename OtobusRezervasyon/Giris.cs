using OtobusRezervasyon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace Otobilet
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.Giris_FormClosing);
        }

        // Giriş yapan kullanıcının ID'sini tutmak için bir değişken
        public string UserID { get; private set; }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            string eposta = KadiTb.Text.Trim();
            string sifre = ParolaTb.Text;

            if (string.IsNullOrEmpty(eposta) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kullanıcıyı doğrula ve kullanıcı ID'sini al
                var (rol, userId) = KullaniciDogrula(eposta, sifre);

                if (!string.IsNullOrEmpty(rol))
                {
                    UserID = userId; // Kullanıcı ID'sini sakla

                    if (rol == "Admin")
                    {
                        MessageBox.Show("Admin olarak giriş yapıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Admin ekranına yönlendirme
                        this.Hide();
                        Otobus adminForm = new Otobus();
                        adminForm.Show();
                    }
                    else if (rol == "Kullanıcı")
                    {
                        MessageBox.Show("Kullanıcı olarak giriş yapıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Kullanıcı ekranına yönlendirme
                        this.Hide();
                        BiletAL anaSayfa = new BiletAL();
                        anaSayfa.UserID = userId; // Kullanıcı ID'sini aktar
                        anaSayfa.Show();
                    }
                }
                else
                {
                    MessageBox.Show("E-posta veya şifre hatalı.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Giriş sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Kullanıcıyı doğrula ve hem rol hem de kullanıcı ID'sini al
        private (string Rol, string UserID) KullaniciDogrula(string eposta, string sifre)
        {
            string rol = null;
            string userId = null;

            string connectionString = @"Data Source=DESKTOP-LDVGBVA\SQLEXPRESS;Initial Catalog=OtobiletDb;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Rol, UserID FROM KayitTbl WHERE Eposta = @Eposta AND Parola = @Parola";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Eposta", eposta);
                    cmd.Parameters.AddWithValue("@Parola", sifre);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rol = reader["Rol"].ToString();
                            userId = reader["UserID"].ToString();
                        }
                    }
                }
            }
            return (rol, userId);
        }
        private void Giris_Load(object sender, EventArgs e)
        {

        }
        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kayit KayitForm = new Kayit();
            KayitForm.Show();
        }
    }
}
