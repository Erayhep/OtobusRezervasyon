namespace Otobilet
{
    partial class BiletAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiletAL));
            label11 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            STarihDtp = new DateTimePicker();
            SeferSaatCmb = new ComboBox();
            OtobusCmb = new ComboBox();
            NereyeCmb = new ComboBox();
            NeredenCmb = new ComboBox();
            label8 = new Label();
            sefersaat = new Label();
            label10 = new Label();
            label6 = new Label();
            biletAlDvg = new DataGridView();
            label9 = new Label();
            button1 = new Button();
            pictureBox7 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)biletAlDvg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.ForestGreen;
            label11.Location = new Point(880, 21);
            label11.Name = "label11";
            label11.Size = new Size(235, 38);
            label11.TabIndex = 34;
            label11.Text = "Sefer Detayları";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(77, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 40);
            panel2.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(212, 26);
            label2.TabIndex = 0;
            label2.Text = "Rezervasyon Yönetimi";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 20);
            label1.Name = "label1";
            label1.Size = new Size(298, 29);
            label1.TabIndex = 48;
            label1.Text = "Otobüs Bilet Rezervasyonu";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(STarihDtp);
            panel1.Controls.Add(SeferSaatCmb);
            panel1.Controls.Add(OtobusCmb);
            panel1.Controls.Add(NereyeCmb);
            panel1.Controls.Add(NeredenCmb);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(sefersaat);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(biletAlDvg);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(29, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(1524, 661);
            panel1.TabIndex = 47;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(17, 558);
            label5.Name = "label5";
            label5.Size = new Size(443, 92);
            label5.TabIndex = 58;
            label5.Text = "Önemli Not: Şu anlık filtreleme seçeneklerimiz kullanıma kapalıdır. Sağ taraftan bütün seferlerimizi görebilirsiniz. ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(39, 49);
            label3.Name = "label3";
            label3.Size = new Size(355, 38);
            label3.TabIndex = 57;
            label3.Text = "Nereye Gitmek İstersin?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(251, 139);
            label4.Name = "label4";
            label4.Size = new Size(112, 26);
            label4.TabIndex = 57;
            label4.Text = "Sefer Günü";
            // 
            // STarihDtp
            // 
            STarihDtp.Format = DateTimePickerFormat.Short;
            STarihDtp.Location = new Point(251, 178);
            STarihDtp.Margin = new Padding(3, 4, 3, 4);
            STarihDtp.Name = "STarihDtp";
            STarihDtp.Size = new Size(184, 31);
            STarihDtp.TabIndex = 56;
            // 
            // SeferSaatCmb
            // 
            SeferSaatCmb.FormattingEnabled = true;
            SeferSaatCmb.Location = new Point(163, 353);
            SeferSaatCmb.Name = "SeferSaatCmb";
            SeferSaatCmb.Size = new Size(155, 34);
            SeferSaatCmb.TabIndex = 55;
            // 
            // OtobusCmb
            // 
            OtobusCmb.FormattingEnabled = true;
            OtobusCmb.Items.AddRange(new object[] { " Adana", " Adıyaman", " Afyonkarahisar", " Ağrı", " Aksaray", " Amasya", " Ankara", " Antalya", " Ardahan", " Artvin", " Aydın", " Balıkesir", " Bartın", " Batman", " Bayburt", " Bilecik", " Bingöl", " Bitlis", " Bolu", " Burdur", " Bursa", " Çanakkale", " Çankırı", " Çorum", " Denizli", " Diyarbakır", " Düzce", " Edirne", " Elazığ", " Erzincan", " Erzurum", " Eskişehir", " Gaziantep", " Giresun", " Gümüşhane", " Hakkâri", " Hatay", " Iğdır", " Isparta", " İstanbul", " İzmir", " Kahramanmaraş", " Karabük", " Karaman", " Kars", " Kastamonu", " Kayseri", " Kilis", " Kırıkkale", " Kırklareli", " Kırşehir", " Kocaeli", " Konya", " Kütahya", " Malatya", " Manisa", " Mardin", " Mersin", " Muğla", " Muş", " Nevşehir", " Niğde", " Ordu", " Osmaniye", " Rize", " Sakarya", " Samsun", " Şanlıurfa", " Siirt", " Sinop", " Sivas", " Şırnak", " Tekirdağ", " Tokat", " Trabzon", " Tunceli", " Uşak", " Van", " Yalova", " Yozgat", " Zonguldak" });
            OtobusCmb.Location = new Point(39, 172);
            OtobusCmb.Name = "OtobusCmb";
            OtobusCmb.Size = new Size(184, 34);
            OtobusCmb.TabIndex = 54;
            // 
            // NereyeCmb
            // 
            NereyeCmb.FormattingEnabled = true;
            NereyeCmb.Location = new Point(242, 284);
            NereyeCmb.Name = "NereyeCmb";
            NereyeCmb.Size = new Size(195, 34);
            NereyeCmb.TabIndex = 53;
            // 
            // NeredenCmb
            // 
            NeredenCmb.FormattingEnabled = true;
            NeredenCmb.Location = new Point(40, 284);
            NeredenCmb.Name = "NeredenCmb";
            NeredenCmb.Size = new Size(183, 34);
            NeredenCmb.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(242, 246);
            label8.Name = "label8";
            label8.Size = new Size(76, 26);
            label8.TabIndex = 51;
            label8.Text = "Nereye";
            // 
            // sefersaat
            // 
            sefersaat.AutoSize = true;
            sefersaat.ForeColor = SystemColors.ControlDarkDark;
            sefersaat.Location = new Point(39, 356);
            sefersaat.Name = "sefersaat";
            sefersaat.Size = new Size(118, 26);
            sefersaat.TabIndex = 50;
            sefersaat.Text = "Sefer Saati:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(40, 139);
            label10.Name = "label10";
            label10.Size = new Size(74, 26);
            label10.TabIndex = 49;
            label10.Text = "Otobüs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(40, 246);
            label6.Name = "label6";
            label6.Size = new Size(88, 26);
            label6.TabIndex = 48;
            label6.Text = "Nereden";
            // 
            // biletAlDvg
            // 
            biletAlDvg.BackgroundColor = Color.White;
            biletAlDvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            biletAlDvg.Location = new Point(462, 80);
            biletAlDvg.Name = "biletAlDvg";
            biletAlDvg.RowHeadersWidth = 51;
            biletAlDvg.Size = new Size(1059, 461);
            biletAlDvg.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gold;
            label9.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(135, 444);
            label9.Name = "label9";
            label9.Size = new Size(29, 35);
            label9.TabIndex = 2;
            label9.Text = "+";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(79, 439);
            button1.Name = "button1";
            button1.Size = new Size(299, 48);
            button1.TabIndex = 11;
            button1.Text = "Sefer Seç";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(895, 781);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(71, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 56;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(805, 781);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(71, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 58;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(715, 781);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(71, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 57;
            pictureBox3.TabStop = false;
            // 
            // BiletAL
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1582, 853);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox7);
            Font = new Font("Trebuchet MS", 12F);
            Margin = new Padding(4);
            Name = "BiletAL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BiletAL";
            Load += BiletAL_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)biletAlDvg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private DataGridView biletAlDvg;
        private Label label9;
        private Button button1;
        private PictureBox pictureBox7;
        private Label label4;
        private DateTimePicker STarihDtp;
        private ComboBox SeferSaatCmb;
        private ComboBox OtobusCmb;
        private ComboBox NereyeCmb;
        private ComboBox NeredenCmb;
        private Label label8;
        private Label sefersaat;
        private Label label10;
        private Label label6;
        private Label label5;
        private Label label3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
    }
}