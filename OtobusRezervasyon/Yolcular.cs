using Otobilet;
using OtobusRezervasyon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusYonetimi
{
    public partial class Yolcular : Form
    {

        public Yolcular()
        {
            InitializeComponent();
            Con = new Fonksiyonlar();
            this.FormClosing += new FormClosingEventHandler(this.Yolcular_FormClosing);
        }
        Fonksiyonlar Con;

        private void Yolcular_Load(object sender, EventArgs e)
        {
            FillOtobusCmb();
            FillSeferSaatCmb();
            FillNeredenVeNereye();

            // Başlangıçta tüm seferleri getirin
            YolculariFiltrele();
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
            NereyeCmb.DisplayMember = "Nereye"; // Nereye kolonunu görüntüle
        }
        private void YBEkleBtn_Click_1(object sender, EventArgs e)
        {
            if (YolcularDgv.SelectedRows.Count > 0)
            {
                int selectedSeferID = Convert.ToInt32(YolcularDgv.SelectedRows[0].Cells["SEKod"].Value);
                MessageBox.Show($"Sefer seçildi! Sefer ID: {selectedSeferID}");

                // Burada seçilen sefer bilgilerini başka bir forma aktarabilirsiniz
                Rezervasyonlar rezervasyonForm = new Rezervasyonlar(); // Örnek bir form oluşturma
                rezervasyonForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen bir sefer seçin!");
            }
        }

        private void YolculariFiltrele()
        {
            try
            {
                string baseQuery = @"SELECT S.SEKod, S.Sefer_Saat, S.Sefer_Tarih, O.Otobus, 
                     S.Nereden, S.Nereye, S.SoforAd AS SoforAd
                     FROM SeferTbl S
                     JOIN OtobusTbl O ON S.Otobus = O.OKod
                     WHERE 1=1";

                // Otobus filtresi
                if (OtobusCmb.SelectedValue != null && OtobusCmb.SelectedValue is int)
                {
                    baseQuery += " AND O.OKod = " + OtobusCmb.SelectedValue;
                }

                // Nereden filtresi
                if (!string.IsNullOrEmpty(NeredenCmb.Text))
                {
                    baseQuery += $" AND S.Nereden COLLATE SQL_Latin1_General_CP1_CI_AS LIKE '%{NeredenCmb.Text}%'";
                }

                // Nereye filtresi
                if (!string.IsNullOrEmpty(NereyeCmb.Text))
                {
                    baseQuery += $" AND S.Nereye COLLATE SQL_Latin1_General_CP1_CI_AS LIKE '%{NereyeCmb.Text}%'";
                }

                // Sefer saat filtresi
                if (!string.IsNullOrEmpty(SeferSaatCmb.Text))
                {
                    baseQuery += $" AND S.Sefer_Saat = '{SeferSaatCmb.Text}'";
                }

                // Tarih filtresi
                baseQuery += $" AND CONVERT(DATE, S.Sefer_Tarih) = '{STarihDtp.Value.ToString("yyyy-MM-dd")}'";

                // Debug: Sorguyu MessageBox ile göster
                MessageBox.Show(baseQuery);

                // Veritabanından sorguyu çalıştır ve sonuçları DataGridView'e aktar
                DataTable dt = Con.GetData(baseQuery);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
        private void OtobusCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            YolculariFiltrele(); // Otobus seçimi değiştiğinde filtreleme yap
        }

        private void NeredenCmb_TextChanged(object sender, EventArgs e)
        {
            YolculariFiltrele(); // Nereden metni değiştiğinde filtreleme yap
        }

        private void NereyeCmb_TextChanged(object sender, EventArgs e)
        {
            YolculariFiltrele(); // Nereye metni değiştiğinde filtreleme yap
        }

        private void SeferSaatCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            YolculariFiltrele(); // Sefer saati değiştiğinde filtreleme yap
        }

        private void STarihDtp_ValueChanged(object sender, EventArgs e)
        {
            YolculariFiltrele(); // Tarih değiştiğinde filtreleme yap
        }
        private void YolcularDgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void YGuncelleBtn_Click_1(object sender, EventArgs e)
        {
            if (YolcularDgv.SelectedRows.Count > 0)
            {
                int selectedSeferID = Convert.ToInt32(YolcularDgv.SelectedRows[0].Cells["SEKod"].Value);

                // Gerekli bilgileri form bileşenlerinden al
                string yeniSaat = SeferSaatCmb.Text;
                string yeniNereden = NeredenCmb.Text;
                string yeniNereye = NereyeCmb.Text;
                DateTime yeniTarih = STarihDtp.Value;

                if (string.IsNullOrEmpty(yeniSaat) || string.IsNullOrEmpty(yeniNereden) || string.IsNullOrEmpty(yeniNereye))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!");
                    return;
                }

                try
                {
                    string query = "UPDATE SeferTbl SET Sefer_Saat = '{0}', Sefer_Tarih = '{1}', Nereden = '{2}', Nereye = '{3}' WHERE SEKod = {4}";
                    query = string.Format(query, yeniSaat, yeniTarih.ToString("yyyy-MM-dd"), yeniNereden, yeniNereye, selectedSeferID);

                    Con.setData(query);
                    MessageBox.Show("Sefer güncellendi!");
                    YolculariFiltrele(); // Sefer listesi güncellenir
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz bir sefer seçin!");
            }
        }

        private void YSilBtn_Click_1(object sender, EventArgs e)
        {
            if (YolcularDgv.SelectedRows.Count > 0)
            {
                int selectedSeferID = Convert.ToInt32(YolcularDgv.SelectedRows[0].Cells["SEKod"].Value);

                DialogResult dialogResult = MessageBox.Show("Seçilen seferi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string query = $"DELETE FROM SeferTbl WHERE SEKod = {selectedSeferID}";
                        Con.setData(query);
                        MessageBox.Show("Sefer silindi!");
                        YolculariFiltrele(); // Listeyi günceller
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir sefer seçin!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Yolcular_FormClosing(object sender, FormClosingEventArgs e)
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Otobus Obj = new Otobus();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Giris Obj = new Giris();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Soforler Obj = new Soforler();
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
