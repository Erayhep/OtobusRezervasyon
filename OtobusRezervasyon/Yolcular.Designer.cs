namespace OtobusYonetimi
{
    partial class Yolcular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yolcular));
            label10 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            STarihDtp = new DateTimePicker();
            SeferSaatCmb = new ComboBox();
            OtobusCmb = new ComboBox();
            NereyeCmb = new ComboBox();
            NeredenCmb = new ComboBox();
            label8 = new Label();
            YSilBtn = new Button();
            YGuncelleBtn = new Button();
            label11 = new Label();
            sefersaat = new Label();
            YolcularDgv = new DataGridView();
            label9 = new Label();
            YBEkleBtn = new Button();
            label6 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox7 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)YolcularDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(40, 139);
            label10.Name = "label10";
            label10.Size = new Size(74, 26);
            label10.TabIndex = 15;
            label10.Text = "Otobüs";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(STarihDtp);
            panel1.Controls.Add(SeferSaatCmb);
            panel1.Controls.Add(OtobusCmb);
            panel1.Controls.Add(NereyeCmb);
            panel1.Controls.Add(NeredenCmb);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(YSilBtn);
            panel1.Controls.Add(YGuncelleBtn);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(sefersaat);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(YolcularDgv);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(YBEkleBtn);
            panel1.Controls.Add(label6);
            panel1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            panel1.Location = new Point(33, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(1524, 661);
            panel1.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(251, 139);
            label4.Name = "label4";
            label4.Size = new Size(112, 26);
            label4.TabIndex = 47;
            label4.Text = "Sefer Günü";
            // 
            // STarihDtp
            // 
            STarihDtp.Format = DateTimePickerFormat.Short;
            STarihDtp.Location = new Point(251, 178);
            STarihDtp.Margin = new Padding(3, 4, 3, 4);
            STarihDtp.Name = "STarihDtp";
            STarihDtp.Size = new Size(184, 31);
            STarihDtp.TabIndex = 46;
            // 
            // SeferSaatCmb
            // 
            SeferSaatCmb.FormattingEnabled = true;
            SeferSaatCmb.Location = new Point(163, 353);
            SeferSaatCmb.Name = "SeferSaatCmb";
            SeferSaatCmb.Size = new Size(155, 34);
            SeferSaatCmb.TabIndex = 45;
            // 
            // OtobusCmb
            // 
            OtobusCmb.FormattingEnabled = true;
            OtobusCmb.Items.AddRange(new object[] { " Adana", " Adıyaman", " Afyonkarahisar", " Ağrı", " Aksaray", " Amasya", " Ankara", " Antalya", " Ardahan", " Artvin", " Aydın", " Balıkesir", " Bartın", " Batman", " Bayburt", " Bilecik", " Bingöl", " Bitlis", " Bolu", " Burdur", " Bursa", " Çanakkale", " Çankırı", " Çorum", " Denizli", " Diyarbakır", " Düzce", " Edirne", " Elazığ", " Erzincan", " Erzurum", " Eskişehir", " Gaziantep", " Giresun", " Gümüşhane", " Hakkâri", " Hatay", " Iğdır", " Isparta", " İstanbul", " İzmir", " Kahramanmaraş", " Karabük", " Karaman", " Kars", " Kastamonu", " Kayseri", " Kilis", " Kırıkkale", " Kırklareli", " Kırşehir", " Kocaeli", " Konya", " Kütahya", " Malatya", " Manisa", " Mardin", " Mersin", " Muğla", " Muş", " Nevşehir", " Niğde", " Ordu", " Osmaniye", " Rize", " Sakarya", " Samsun", " Şanlıurfa", " Siirt", " Sinop", " Sivas", " Şırnak", " Tekirdağ", " Tokat", " Trabzon", " Tunceli", " Uşak", " Van", " Yalova", " Yozgat", " Zonguldak" });
            OtobusCmb.Location = new Point(39, 172);
            OtobusCmb.Name = "OtobusCmb";
            OtobusCmb.Size = new Size(184, 34);
            OtobusCmb.TabIndex = 44;
            // 
            // NereyeCmb
            // 
            NereyeCmb.FormattingEnabled = true;
            NereyeCmb.Location = new Point(242, 284);
            NereyeCmb.Name = "NereyeCmb";
            NereyeCmb.Size = new Size(195, 34);
            NereyeCmb.TabIndex = 43;
            // 
            // NeredenCmb
            // 
            NeredenCmb.FormattingEnabled = true;
            NeredenCmb.Location = new Point(40, 284);
            NeredenCmb.Name = "NeredenCmb";
            NeredenCmb.Size = new Size(183, 34);
            NeredenCmb.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(242, 246);
            label8.Name = "label8";
            label8.Size = new Size(76, 26);
            label8.TabIndex = 41;
            label8.Text = "Nereye";
            // 
            // YSilBtn
            // 
            YSilBtn.BackColor = Color.Tomato;
            YSilBtn.Location = new Point(240, 505);
            YSilBtn.Name = "YSilBtn";
            YSilBtn.Size = new Size(100, 40);
            YSilBtn.TabIndex = 38;
            YSilBtn.Text = "Sil";
            YSilBtn.UseVisualStyleBackColor = false;
            YSilBtn.Click += YSilBtn_Click_1;
            // 
            // YGuncelleBtn
            // 
            YGuncelleBtn.BackColor = Color.ForestGreen;
            YGuncelleBtn.Location = new Point(108, 505);
            YGuncelleBtn.Name = "YGuncelleBtn";
            YGuncelleBtn.Size = new Size(100, 40);
            YGuncelleBtn.TabIndex = 37;
            YGuncelleBtn.Text = "Güncelle";
            YGuncelleBtn.UseVisualStyleBackColor = false;
            YGuncelleBtn.Click += YGuncelleBtn_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.ForestGreen;
            label11.Location = new Point(53, 48);
            label11.Name = "label11";
            label11.Size = new Size(355, 38);
            label11.TabIndex = 35;
            label11.Text = "Nereye Gitmek İstersin?";
            // 
            // sefersaat
            // 
            sefersaat.AutoSize = true;
            sefersaat.ForeColor = SystemColors.ControlDarkDark;
            sefersaat.Location = new Point(39, 356);
            sefersaat.Name = "sefersaat";
            sefersaat.Size = new Size(118, 26);
            sefersaat.TabIndex = 19;
            sefersaat.Text = "Sefer Saati:";
            // 
            // YolcularDgv
            // 
            YolcularDgv.BackgroundColor = Color.White;
            YolcularDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            YolcularDgv.Location = new Point(462, 80);
            YolcularDgv.Name = "YolcularDgv";
            YolcularDgv.RowHeadersWidth = 51;
            YolcularDgv.Size = new Size(1059, 461);
            YolcularDgv.TabIndex = 14;
            YolcularDgv.CellContentClick += YolcularDgv_CellContentClick_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gold;
            label9.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(119, 444);
            label9.Name = "label9";
            label9.Size = new Size(29, 35);
            label9.TabIndex = 2;
            label9.Text = "+";
            // 
            // YBEkleBtn
            // 
            YBEkleBtn.BackColor = Color.Gold;
            YBEkleBtn.ForeColor = Color.Black;
            YBEkleBtn.Location = new Point(79, 439);
            YBEkleBtn.Name = "YBEkleBtn";
            YBEkleBtn.Size = new Size(299, 48);
            YBEkleBtn.TabIndex = 11;
            YBEkleBtn.Text = "Sefer Seç";
            YBEkleBtn.UseVisualStyleBackColor = false;
            YBEkleBtn.Click += YBEkleBtn_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(40, 246);
            label6.Name = "label6";
            label6.Size = new Size(88, 26);
            label6.TabIndex = 6;
            label6.Text = "Nereden";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 10);
            label1.Name = "label1";
            label1.Size = new Size(389, 29);
            label1.TabIndex = 48;
            label1.Text = "Otobüs Bilet Rezervasyon Yönetimi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(5, 1);
            label3.Name = "label3";
            label3.Size = new Size(29, 35);
            label3.TabIndex = 1;
            label3.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(31, 8);
            label2.Name = "label2";
            label2.Size = new Size(141, 26);
            label2.TabIndex = 0;
            label2.Text = "Bilet Yönetimi";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(955, 772);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(71, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 55;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(865, 772);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(71, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 54;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(775, 772);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(71, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 53;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(685, 772);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(71, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 52;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(505, 772);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1045, 772);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(71, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 56;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(81, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 40);
            panel2.TabIndex = 49;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(595, 772);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // Yolcular
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox7);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Yolcular";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yolcular";
            Load += Yolcular_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)YolcularDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Panel panel1;
        private Button YSilBtn;
        private Button YGuncelleBtn;
        private Label label11;
        private Label sefersaat;
        private DataGridView YolcularDgv;
        private Label label9;
        private Button YBEkleBtn;
        private Label label6;
        private Label label1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox7;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label8;
        private ComboBox NereyeCmb;
        private ComboBox NeredenCmb;
        private ComboBox OtobusCmb;
        private ComboBox SeferSaatCmb;
        private Label label4;
        private DateTimePicker STarihDtp;
    }
}