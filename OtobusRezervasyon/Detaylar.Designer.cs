namespace Otobilet
{
    partial class Detaylar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detaylar));
            pictureBox7 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            detaylarDvg = new DataGridView();
            label9 = new Label();
            button1 = new Button();
            label1 = new Label();
            kapasitePanel = new Panel();
            BiletKadinRbtn = new RadioButton();
            BiletErkekRbtn = new RadioButton();
            label5 = new Label();
            label17 = new Label();
            BiletTelTb = new TextBox();
            label14 = new Label();
            BiletAdTb = new TextBox();
            koltukPanel = new Panel();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)detaylarDvg).BeginInit();
            kapasitePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(895, 781);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(71, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 60;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 6);
            label2.Name = "label2";
            label2.Size = new Size(91, 29);
            label2.TabIndex = 0;
            label2.Text = "Bilet Al";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(77, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 40);
            panel2.TabIndex = 59;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.ForestGreen;
            label11.Location = new Point(873, 24);
            label11.Name = "label11";
            label11.Size = new Size(235, 38);
            label11.TabIndex = 34;
            label11.Text = "Sefer Detayları";
            // 
            // detaylarDvg
            // 
            detaylarDvg.BackgroundColor = Color.White;
            detaylarDvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detaylarDvg.Location = new Point(445, 82);
            detaylarDvg.Name = "detaylarDvg";
            detaylarDvg.RowHeadersWidth = 51;
            detaylarDvg.Size = new Size(1064, 110);
            detaylarDvg.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gold;
            label9.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(766, 586);
            label9.Name = "label9";
            label9.Size = new Size(29, 35);
            label9.TabIndex = 2;
            label9.Text = "+";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(710, 581);
            button1.Name = "button1";
            button1.Size = new Size(299, 48);
            button1.TabIndex = 11;
            button1.Text = "Bilet Al";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 20);
            label1.Name = "label1";
            label1.Size = new Size(298, 29);
            label1.TabIndex = 58;
            label1.Text = "Otobüs Bilet Rezervasyonu";
            // 
            // kapasitePanel
            // 
            kapasitePanel.BackColor = Color.White;
            kapasitePanel.Controls.Add(BiletKadinRbtn);
            kapasitePanel.Controls.Add(BiletErkekRbtn);
            kapasitePanel.Controls.Add(label5);
            kapasitePanel.Controls.Add(label17);
            kapasitePanel.Controls.Add(BiletTelTb);
            kapasitePanel.Controls.Add(label14);
            kapasitePanel.Controls.Add(BiletAdTb);
            kapasitePanel.Controls.Add(koltukPanel);
            kapasitePanel.Controls.Add(label3);
            kapasitePanel.Controls.Add(label11);
            kapasitePanel.Controls.Add(detaylarDvg);
            kapasitePanel.Controls.Add(label9);
            kapasitePanel.Controls.Add(button1);
            kapasitePanel.Location = new Point(29, 102);
            kapasitePanel.Name = "kapasitePanel";
            kapasitePanel.Size = new Size(1524, 661);
            kapasitePanel.TabIndex = 57;
            // 
            // BiletKadinRbtn
            // 
            BiletKadinRbtn.AutoSize = true;
            BiletKadinRbtn.Font = new Font("Trebuchet MS", 12F);
            BiletKadinRbtn.Location = new Point(901, 342);
            BiletKadinRbtn.Name = "BiletKadinRbtn";
            BiletKadinRbtn.Size = new Size(84, 30);
            BiletKadinRbtn.TabIndex = 43;
            BiletKadinRbtn.TabStop = true;
            BiletKadinRbtn.Text = "Kadın";
            BiletKadinRbtn.UseVisualStyleBackColor = true;
            // 
            // BiletErkekRbtn
            // 
            BiletErkekRbtn.AutoSize = true;
            BiletErkekRbtn.Font = new Font("Trebuchet MS", 12F);
            BiletErkekRbtn.Location = new Point(806, 342);
            BiletErkekRbtn.Name = "BiletErkekRbtn";
            BiletErkekRbtn.Size = new Size(83, 30);
            BiletErkekRbtn.TabIndex = 42;
            BiletErkekRbtn.TabStop = true;
            BiletErkekRbtn.Text = "Erkek";
            BiletErkekRbtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(686, 341);
            label5.Name = "label5";
            label5.Size = new Size(92, 28);
            label5.TabIndex = 41;
            label5.Text = "Cinsiyet:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label17.ForeColor = SystemColors.ControlDarkDark;
            label17.Location = new Point(841, 247);
            label17.Name = "label17";
            label17.Size = new Size(87, 28);
            label17.TabIndex = 40;
            label17.Text = "Telefon:";
            // 
            // BiletTelTb
            // 
            BiletTelTb.Font = new Font("Trebuchet MS", 12F);
            BiletTelTb.Location = new Point(941, 247);
            BiletTelTb.Name = "BiletTelTb";
            BiletTelTb.Size = new Size(225, 31);
            BiletTelTb.TabIndex = 39;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ControlDarkDark;
            label14.Location = new Point(482, 247);
            label14.Name = "label14";
            label14.Size = new Size(43, 28);
            label14.TabIndex = 38;
            label14.Text = "Ad:";
            // 
            // BiletAdTb
            // 
            BiletAdTb.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BiletAdTb.Location = new Point(532, 247);
            BiletAdTb.Name = "BiletAdTb";
            BiletAdTb.Size = new Size(225, 31);
            BiletAdTb.TabIndex = 37;
            // 
            // koltukPanel
            // 
            koltukPanel.Location = new Point(17, 82);
            koltukPanel.Name = "koltukPanel";
            koltukPanel.Size = new Size(327, 547);
            koltukPanel.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(17, 24);
            label3.Name = "label3";
            label3.Size = new Size(219, 38);
            label3.TabIndex = 35;
            label3.Text = "Koltuk Seçiniz";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(805, 781);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(71, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 62;
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
            pictureBox3.TabIndex = 61;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(45, 2);
            label4.Name = "label4";
            label4.Size = new Size(29, 35);
            label4.TabIndex = 63;
            label4.Text = "+";
            // 
            // Detaylar
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1582, 853);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox7);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(kapasitePanel);
            Font = new Font("Trebuchet MS", 14.25F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Detaylar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detaylar";
            Load += Detaylar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)detaylarDvg).EndInit();
            kapasitePanel.ResumeLayout(false);
            kapasitePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox7;
        private Label label2;
        private Panel panel2;
        private Label label11;
        private DataGridView detaylarDvg;
        private Label label9;
        private Button button1;
        private Label label1;
        private Panel kapasitePanel;
        private Label label3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private Panel koltukPanel;
        private RadioButton BiletKadinRbtn;
        private RadioButton BiletErkekRbtn;
        private Label label5;
        private Label label17;
        private TextBox BiletTelTb;
        private Label label14;
        private TextBox BiletAdTb;
        private Label label4;
    }
}