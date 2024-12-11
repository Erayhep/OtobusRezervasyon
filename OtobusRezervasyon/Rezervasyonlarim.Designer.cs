namespace Otobilet
{
    partial class Rezervasyonlarim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezervasyonlarim));
            label11 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            hosGeldinizlbl = new Label();
            label1 = new Label();
            panel1 = new Panel();
            rezervasyonlarimDvg = new DataGridView();
            pictureBox7 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rezervasyonlarimDvg).BeginInit();
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
            label11.Location = new Point(608, 22);
            label11.Name = "label11";
            label11.Size = new Size(344, 38);
            label11.TabIndex = 34;
            label11.Text = "Rezervasyon Geçmişim";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(hosGeldinizlbl);
            panel2.Location = new Point(77, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 40);
            panel2.TabIndex = 49;
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
            // hosGeldinizlbl
            // 
            hosGeldinizlbl.AutoSize = true;
            hosGeldinizlbl.Location = new Point(31, 8);
            hosGeldinizlbl.Name = "hosGeldinizlbl";
            hosGeldinizlbl.Size = new Size(173, 26);
            hosGeldinizlbl.TabIndex = 0;
            hosGeldinizlbl.Text = "Rezervasyonlarım";
            hosGeldinizlbl.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 20);
            label1.Name = "label1";
            label1.Size = new Size(389, 29);
            label1.TabIndex = 48;
            label1.Text = "Otobüs Bilet Rezervasyon Yönetimi";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(rezervasyonlarimDvg);
            panel1.Location = new Point(29, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(1524, 661);
            panel1.TabIndex = 47;
            // 
            // rezervasyonlarimDvg
            // 
            rezervasyonlarimDvg.BackgroundColor = Color.White;
            rezervasyonlarimDvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rezervasyonlarimDvg.Location = new Point(17, 80);
            rezervasyonlarimDvg.Name = "rezervasyonlarimDvg";
            rezervasyonlarimDvg.RowHeadersWidth = 51;
            rezervasyonlarimDvg.Size = new Size(1488, 557);
            rezervasyonlarimDvg.TabIndex = 14;
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
            pictureBox5.TabIndex = 54;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(715, 781);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(71, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 52;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Rezervasyonlarim
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Font = new Font("Trebuchet MS", 12F);
            Margin = new Padding(4);
            Name = "Rezervasyonlarim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rezervasyonlarim";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rezervasyonlarimDvg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private DataGridView rezervasyonlarimDvg;
        private PictureBox pictureBox7;
        private PictureBox pictureBox5;
        private Label label3;
        private Label hosGeldinizlbl;
        private PictureBox pictureBox3;
    }
}