using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtobusYonetimi;
using System.Collections;
using System.Reflection.Emit;

namespace Otobilet
{
    public partial class Rezervasyonlarim : Form
    {
        public int userID { get; set; } // Kullanıcının ID'si
        public Rezervasyonlarim()
        {
            InitializeComponent();
            Con = new Fonksiyonlar();
            this.FormClosing += new FormClosingEventHandler(this.Rezervasyonlarim_FormClosing);
        }
        Fonksiyonlar Con;
        private void Rezervasyonlarim_Load(object sender, EventArgs e)
        {
            KullaniciRezervasyonlari(userID); // Kullanıcının rezervasyonlarını yükle
        }

        private void KullaniciRezervasyonlari(int userID)
        {
            try
            {
                // Kullanıcıya ait rezervasyonları çekmek için güncellenmiş sorgu
                string query = @"
                SELECT 
                    r.SeferID, r.KoltukNo, r.Isim, r.Telefon, r.Cinsiyet
                FROM 
                    RezervasyonTbl r
                JOIN 
                    KayitTbl k ON r.Isim = k.Ad
                WHERE 
                    k.UserID = @userID";

                // SQL bağlantısını ve sorguyu çalıştırma
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-LDVGBVA\SQLEXPRESS;Initial Catalog=OtobiletDb;Integrated Security=True;"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    // Parametreyi burada ekliyoruz
                    command.Parameters.AddWithValue("@UserID", userID);

                    // Veriyi çekiyoruz
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // Eğer veri varsa, DataGridView'e aktar
                    if (dt.Rows.Count > 0)
                    {
                        rezervasyonlarimDvg.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Henüz bir rezervasyonunuz bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata mesajı
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BiletAL Obj = new BiletAL();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Giris Obj = new Giris();
            Obj.Show();
            this.Hide();
        }
        private void Rezervasyonlarim_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
