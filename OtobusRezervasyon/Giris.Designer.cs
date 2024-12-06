namespace Otobilet
{
    partial class Giris
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
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            label9 = new Label();
            GirisBtn = new Button();
            ParolaTb = new TextBox();
            label1 = new Label();
            KadiTb = new TextBox();
            label4 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(GirisBtn);
            panel1.Controls.Add(ParolaTb);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(KadiTb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 430);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(370, 305);
            label2.Name = "label2";
            label2.Size = new Size(29, 35);
            label2.TabIndex = 42;
            label2.Text = "+";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(350, 300);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 43;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gold;
            label9.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(130, 305);
            label9.Name = "label9";
            label9.Size = new Size(29, 35);
            label9.TabIndex = 40;
            label9.Text = "+";
            // 
            // GirisBtn
            // 
            GirisBtn.BackColor = Color.Gold;
            GirisBtn.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GirisBtn.ForeColor = Color.Black;
            GirisBtn.Location = new Point(115, 300);
            GirisBtn.Name = "GirisBtn";
            GirisBtn.Size = new Size(200, 50);
            GirisBtn.TabIndex = 41;
            GirisBtn.Text = "Giriş Yap";
            GirisBtn.UseVisualStyleBackColor = false;
            GirisBtn.Click += GirisBtn_Click;
            // 
            // ParolaTb
            // 
            ParolaTb.Font = new Font("Trebuchet MS", 12F);
            ParolaTb.Location = new Point(194, 229);
            ParolaTb.Name = "ParolaTb";
            ParolaTb.PasswordChar = '*';
            ParolaTb.Size = new Size(260, 31);
            ParolaTb.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(194, 193);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 38;
            label1.Text = "Parola";
            // 
            // KadiTb
            // 
            KadiTb.Font = new Font("Trebuchet MS", 12F);
            KadiTb.Location = new Point(194, 133);
            KadiTb.Name = "KadiTb";
            KadiTb.Size = new Size(260, 31);
            KadiTb.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(194, 97);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 36;
            label4.Text = "E-posta";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold | FontStyle.Italic);
            label11.ForeColor = Color.ForestGreen;
            label11.Location = new Point(117, 27);
            label11.Name = "label11";
            label11.Size = new Size(411, 35);
            label11.TabIndex = 35;
            label11.Text = "Otobüs Bilet Otomasyonu: Otobilet";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(682, 453);
            Controls.Add(panel1);
            Font = new Font("Tw Cen MT Condensed Extra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giris";
            Load += Giris_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label11;
        private TextBox ParolaTb;
        private Label label1;
        private TextBox KadiTb;
        private Label label4;
        private Label label9;
        private Button GirisBtn;
        private Label label2;
        private Button button1;
    }
}