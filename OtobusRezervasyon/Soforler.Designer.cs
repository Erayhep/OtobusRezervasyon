namespace Otobilet
{
    partial class Soforler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Soforler));
            label10 = new Label();
            SoforDgv = new DataGridView();
            label9 = new Label();
            YeniSoforEkleBtn = new Button();
            SDogumDtp = new DateTimePicker();
            panel1 = new Panel();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            label11 = new Label();
            label8 = new Label();
            STelefonMtb = new MaskedTextBox();
            SDeneyimTb = new TextBox();
            SAdresTb = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SCinsiyetTb = new TextBox();
            label5 = new Label();
            SAdTb = new TextBox();
            label88 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)SoforDgv).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(241, 137);
            label10.Name = "label10";
            label10.Size = new Size(131, 26);
            label10.TabIndex = 15;
            label10.Text = "Doğum Tarihi";
            // 
            // SoforDgv
            // 
            SoforDgv.BackgroundColor = Color.White;
            SoforDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SoforDgv.Location = new Point(462, 80);
            SoforDgv.Name = "SoforDgv";
            SoforDgv.RowHeadersWidth = 51;
            SoforDgv.Size = new Size(1059, 461);
            SoforDgv.TabIndex = 14;
            SoforDgv.CellContentClick += SoforDgv_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gold;
            label9.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(120, 440);
            label9.Name = "label9";
            label9.Size = new Size(29, 35);
            label9.TabIndex = 2;
            label9.Text = "+";
            // 
            // YeniSoforEkleBtn
            // 
            YeniSoforEkleBtn.BackColor = Color.Gold;
            YeniSoforEkleBtn.ForeColor = Color.Black;
            YeniSoforEkleBtn.Location = new Point(80, 435);
            YeniSoforEkleBtn.Name = "YeniSoforEkleBtn";
            YeniSoforEkleBtn.Size = new Size(299, 48);
            YeniSoforEkleBtn.TabIndex = 11;
            YeniSoforEkleBtn.Text = "Yeni Şoför Ekle";
            YeniSoforEkleBtn.UseVisualStyleBackColor = false;
            YeniSoforEkleBtn.Click += YeniSoforEkleBtn_Click;
            // 
            // SDogumDtp
            // 
            SDogumDtp.Format = DateTimePickerFormat.Short;
            SDogumDtp.Location = new Point(241, 176);
            SDogumDtp.Name = "SDogumDtp";
            SDogumDtp.Size = new Size(186, 31);
            SDogumDtp.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(UpdateBtn);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(STelefonMtb);
            panel1.Controls.Add(SDeneyimTb);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(SAdresTb);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(SoforDgv);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(YeniSoforEkleBtn);
            panel1.Controls.Add(SDogumDtp);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(SCinsiyetTb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(SAdTb);
            panel1.Controls.Add(label88);
            panel1.Location = new Point(33, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(1524, 661);
            panel1.TabIndex = 20;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Tomato;
            DeleteBtn.Location = new Point(241, 501);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(100, 40);
            DeleteBtn.TabIndex = 36;
            DeleteBtn.Text = "Sil";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.ForestGreen;
            UpdateBtn.Location = new Point(109, 501);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(100, 40);
            UpdateBtn.TabIndex = 35;
            UpdateBtn.Text = "Güncelle";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.ForestGreen;
            label11.Location = new Point(96, 48);
            label11.Name = "label11";
            label11.Size = new Size(235, 38);
            label11.TabIndex = 34;
            label11.Text = "Şoför Detayları";
            label11.Click += label11_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(241, 337);
            label8.Name = "label8";
            label8.Size = new Size(90, 26);
            label8.TabIndex = 33;
            label8.Text = "Deneyim";
            // 
            // STelefonMtb
            // 
            STelefonMtb.Location = new Point(241, 273);
            STelefonMtb.Mask = "(999) 000-0000";
            STelefonMtb.Name = "STelefonMtb";
            STelefonMtb.Size = new Size(183, 31);
            STelefonMtb.TabIndex = 16;
            // 
            // SDeneyimTb
            // 
            SDeneyimTb.Location = new Point(241, 374);
            SDeneyimTb.Name = "SDeneyimTb";
            SDeneyimTb.Size = new Size(186, 31);
            SDeneyimTb.TabIndex = 32;
            // 
            // SAdresTb
            // 
            SAdresTb.Location = new Point(39, 374);
            SAdresTb.Name = "SAdresTb";
            SAdresTb.Size = new Size(186, 31);
            SAdresTb.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(39, 334);
            label6.Name = "label6";
            label6.Size = new Size(120, 26);
            label6.TabIndex = 30;
            label6.Text = "Şoför Adresi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(241, 237);
            label7.Name = "label7";
            label7.Size = new Size(170, 26);
            label7.TabIndex = 8;
            label7.Text = "Telefon Numarası";
            // 
            // SCinsiyetTb
            // 
            SCinsiyetTb.Location = new Point(39, 273);
            SCinsiyetTb.Name = "SCinsiyetTb";
            SCinsiyetTb.Size = new Size(186, 31);
            SCinsiyetTb.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(39, 237);
            label5.Name = "label5";
            label5.Size = new Size(143, 26);
            label5.TabIndex = 4;
            label5.Text = "Şoför Cinsiyeti";
            // 
            // SAdTb
            // 
            SAdTb.Location = new Point(39, 173);
            SAdTb.Name = "SAdTb";
            SAdTb.Size = new Size(186, 31);
            SAdTb.TabIndex = 3;
            // 
            // label88
            // 
            label88.AutoSize = true;
            label88.ForeColor = SystemColors.ControlDarkDark;
            label88.Location = new Point(39, 137);
            label88.Name = "label88";
            label88.Size = new Size(93, 26);
            label88.TabIndex = 2;
            label88.Text = "Şoför Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 10);
            label1.Name = "label1";
            label1.Size = new Size(389, 29);
            label1.TabIndex = 28;
            label1.Text = "Otobüs Bilet Rezervasyon Yönetimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 8);
            label2.Name = "label2";
            label2.Size = new Size(146, 26);
            label2.TabIndex = 0;
            label2.Text = "Şoför Yönetimi";
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
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(81, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 40);
            panel2.TabIndex = 29;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1045, 772);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(71, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 36;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(955, 772);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(71, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 35;
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
            pictureBox5.TabIndex = 34;
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
            pictureBox4.TabIndex = 33;
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
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(595, 772);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(505, 772);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Soforler
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1582, 853);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Soforler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Soforler";
            Load += Soforler_Load;
            ((System.ComponentModel.ISupportInitialize)SoforDgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private DataGridView SoforDgv;
        private Label label9;
        private Button YeniSoforEkleBtn;
        private DateTimePicker SDogumDtp;
        private Panel panel1;
        private MaskedTextBox STelefonMtb;
        private Label label7;
        private TextBox SCinsiyetTb;
        private Label label5;
        private TextBox SAdTb;
        private Label label88;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label label8;
        private TextBox SDeneyimTb;
        private TextBox SAdresTb;
        private Label label6;
        private Label label11;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button DeleteBtn;
        private Button UpdateBtn;
    }
}