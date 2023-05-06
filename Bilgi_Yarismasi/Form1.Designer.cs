namespace Bilgi_Yarismasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnb = new Button();
            btnC = new Button();
            btnD = new Button();
            btnSonraki = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblSoru = new Label();
            lblDogru = new Label();
            lblYanlis = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnBaslat = new Button();
            btnBitir = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(224, 224, 224);
            richTextBox1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(12, 63);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(282, 102);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.BackColor = Color.FromArgb(224, 224, 224);
            btnA.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnA.Location = new Point(12, 171);
            btnA.Name = "btnA";
            btnA.Size = new Size(133, 57);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnA_Click;
            // 
            // btnb
            // 
            btnb.BackColor = Color.FromArgb(224, 224, 224);
            btnb.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnb.Location = new Point(161, 171);
            btnb.Name = "btnb";
            btnb.Size = new Size(133, 57);
            btnb.TabIndex = 1;
            btnb.Text = "B";
            btnb.UseVisualStyleBackColor = false;
            btnb.Click += btnb_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(224, 224, 224);
            btnC.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnC.Location = new Point(14, 247);
            btnC.Name = "btnC";
            btnC.Size = new Size(133, 59);
            btnC.TabIndex = 1;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.BackColor = Color.FromArgb(224, 224, 224);
            btnD.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnD.Location = new Point(161, 247);
            btnD.Name = "btnD";
            btnD.Size = new Size(133, 59);
            btnD.TabIndex = 1;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnD_Click;
            // 
            // btnSonraki
            // 
            btnSonraki.BackColor = Color.FromArgb(224, 224, 224);
            btnSonraki.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSonraki.Location = new Point(300, 141);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(173, 40);
            btnSonraki.TabIndex = 1;
            btnSonraki.Text = "Sonraki Soru";
            btnSonraki.UseVisualStyleBackColor = false;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(353, 61);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 2;
            label5.Text = "Soru No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(309, 88);
            label6.Name = "label6";
            label6.Size = new Size(131, 23);
            label6.TabIndex = 2;
            label6.Text = "Doğru Sayısı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(308, 115);
            label7.Name = "label7";
            label7.Size = new Size(132, 23);
            label7.TabIndex = 2;
            label7.Text = "Yanlış Sayısı:";
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Location = new Point(446, 61);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(21, 23);
            lblSoru.TabIndex = 3;
            lblSoru.Text = "0";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(446, 88);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(21, 23);
            lblDogru.TabIndex = 3;
            lblDogru.Text = "0";
            // 
            // lblYanlis
            // 
            lblYanlis.AutoSize = true;
            lblYanlis.Location = new Point(446, 115);
            lblYanlis.Name = "lblYanlis";
            lblYanlis.Size = new Size(21, 23);
            lblYanlis.TabIndex = 3;
            lblYanlis.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 BlkCn BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 16);
            label1.Name = "label1";
            label1.Size = new Size(212, 34);
            label1.TabIndex = 4;
            label1.Text = "BİLGİ YARIŞMASI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnBaslat
            // 
            btnBaslat.BackColor = Color.FromArgb(192, 255, 192);
            btnBaslat.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaslat.Location = new Point(300, 24);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(80, 32);
            btnBaslat.TabIndex = 6;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = false;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // btnBitir
            // 
            btnBitir.BackColor = Color.FromArgb(255, 128, 128);
            btnBitir.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBitir.Location = new Point(386, 24);
            btnBitir.Name = "btnBitir";
            btnBitir.Size = new Size(80, 32);
            btnBitir.TabIndex = 6;
            btnBitir.Text = "Bitir";
            btnBitir.UseVisualStyleBackColor = false;
            btnBitir.Click += btnBitir_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(300, 211);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(386, 211);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(87, 95);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 367);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 9;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 399);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 9;
            label3.Text = "label2";
            label3.Visible = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(300, 185);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(173, 18);
            progressBar1.TabIndex = 10;
            progressBar1.Click += progressBar1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(479, 316);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnBitir);
            Controls.Add(btnBaslat);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblYanlis);
            Controls.Add(lblDogru);
            Controls.Add(lblSoru);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnSonraki);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnb);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnb;
        private Button btnC;
        private Button btnD;
        private Button btnSonraki;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblSoru;
        private Label lblDogru;
        private Label lblYanlis;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnBaslat;
        private Button btnBitir;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
    }
}