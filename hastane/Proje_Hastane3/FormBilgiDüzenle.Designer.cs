namespace Proje_Hastane
{
    partial class FormBilgiDüzenle
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
            btnGuncelle = new Button();
            cmbCinsiyet = new ComboBox();
            tbxSoyAdi = new TextBox();
            tbxSifre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tbxAdi = new TextBox();
            label4 = new Label();
            label1 = new Label();
            mtbxTelefon = new MaskedTextBox();
            mtbxTc = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(218, 369);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(107, 45);
            btnGuncelle.TabIndex = 23;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cmbCinsiyet.Location = new Point(186, 308);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(170, 31);
            cmbCinsiyet.TabIndex = 22;
            // 
            // tbxSoyAdi
            // 
            tbxSoyAdi.Location = new Point(186, 118);
            tbxSoyAdi.Margin = new Padding(4, 3, 4, 3);
            tbxSoyAdi.Name = "tbxSoyAdi";
            tbxSoyAdi.Size = new Size(170, 30);
            tbxSoyAdi.TabIndex = 19;
            // 
            // tbxSifre
            // 
            tbxSifre.Location = new Point(186, 260);
            tbxSifre.Margin = new Padding(4, 3, 4, 3);
            tbxSifre.Name = "tbxSifre";
            tbxSifre.Size = new Size(170, 30);
            tbxSifre.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 121);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 23);
            label6.TabIndex = 12;
            label6.Text = "Soyadı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 267);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 13;
            label5.Text = "Şifre";
            // 
            // tbxAdi
            // 
            tbxAdi.Location = new Point(186, 73);
            tbxAdi.Margin = new Padding(4, 3, 4, 3);
            tbxAdi.Name = "tbxAdi";
            tbxAdi.Size = new Size(170, 30);
            tbxAdi.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 220);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 23);
            label4.TabIndex = 14;
            label4.Text = "Telefon Numarası";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 80);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 23);
            label1.TabIndex = 15;
            label1.Text = "Adı";
            // 
            // mtbxTelefon
            // 
            mtbxTelefon.Location = new Point(186, 214);
            mtbxTelefon.Margin = new Padding(4, 3, 4, 3);
            mtbxTelefon.Mask = "(999) 000-0000";
            mtbxTelefon.Name = "mtbxTelefon";
            mtbxTelefon.Size = new Size(170, 30);
            mtbxTelefon.TabIndex = 17;
            // 
            // mtbxTc
            // 
            mtbxTc.Location = new Point(186, 167);
            mtbxTc.Margin = new Padding(4, 3, 4, 3);
            mtbxTc.Mask = "00000000000";
            mtbxTc.Name = "mtbxTc";
            mtbxTc.Size = new Size(170, 30);
            mtbxTc.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 311);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 16;
            label3.Text = "Cinsiyet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 170);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 11;
            label2.Text = "TC Kimlik No";
            // 
            // FormBilgiDüzenle
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(455, 518);
            Controls.Add(btnGuncelle);
            Controls.Add(cmbCinsiyet);
            Controls.Add(tbxSoyAdi);
            Controls.Add(tbxSifre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbxAdi);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(mtbxTelefon);
            Controls.Add(mtbxTc);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormBilgiDüzenle";
            Text = "FormBilgiDüzenle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuncelle;
        private ComboBox cmbCinsiyet;
        private TextBox tbxSoyAdi;
        private TextBox tbxSifre;
        private Label label6;
        private Label label5;
        private TextBox tbxAdi;
        private Label label4;
        private Label label1;
        private MaskedTextBox mtbxTelefon;
        private MaskedTextBox mtbxTc;
        private Label label3;
        private Label label2;
    }
}