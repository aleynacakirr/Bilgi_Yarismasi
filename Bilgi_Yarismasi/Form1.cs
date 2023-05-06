namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru, dogru, yanlis;

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            soru++;
            lblSoru.Text = soru.ToString();
            richTextBox1.Text = "Türkiyenin en büyük gölünün adý nedir ?";
            btnA.Text = "Van Gölü";
            btnb.Text = "Tuz Gölü";
            btnC.Text = "Beyþehir Gölü";
            btnD.Text = "Eðirdir Gölü";
            label2.Text = "Van Gölü";
            btnBaslat.Enabled = false;
            btnBitir.Enabled = false;
            btnA.Enabled = true;
            btnb.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            soru++;
            lblSoru.Text = soru.ToString();
            progressBar1.Value += 20;   
            if (soru == 2)
            {
                richTextBox1.Text = "Telefonu kim icat etmiþtir ?";
                btnA.Text = "Leonardo da Vinci";
                btnb.Text = "Samuel Morse";
                btnC.Text = "Alexander Graham Bell";
                btnD.Text = "Thomas Jefferson";
                label2.Text = "Alexander Graham Bell";
                btnA.Enabled = true;
                btnb.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            else if (soru == 3)
            {
                richTextBox1.Text = "Eurovision ‘da Türkiyeye birincilik getiren sanatçýmýz kimdir ?";
                btnA.Text = "Manga";
                btnb.Text = "Ýbrahim Tatlýses";
                btnC.Text = "Ajda Pekkan";
                btnD.Text = "Sertap Erener";
                label2.Text = "Sertap Erener";
                btnA.Enabled = true;
                btnb.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            else if (soru == 4)
            {
                richTextBox1.Text = "Pisagor teoremi hangi bilim dalýyla ilgilidir ?";
                btnA.Text = "Fizik";
                btnb.Text = "Matematik";
                btnC.Text = "Kimya";
                btnD.Text = "Coðrafya";
                label2.Text = "Matematik";
                btnA.Enabled = true;
                btnb.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            else if (soru == 5)
            {
                richTextBox1.Text = "En geniþ ormanlýk alana sahip bölgemiz hangisidir ?";
                btnA.Text = "Marmara Bölgesi";
                btnb.Text = "Karadeniz Bölgesi";
                btnC.Text = "Ege Bölgesi";
                btnD.Text = "Ýç Anadolu Bölgesi";
                label2.Text = "Karadeniz Bölgesi";
                btnSonraki.Enabled = false;
                btnBitir.Enabled = true;
                btnA.Enabled = true;
                btnb.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
        }
        public void Sonuclar()
        {
            if (label2.Text == label3.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                btnA.Enabled = false;
                btnb.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                pictureBox3.Visible = true;
                lblYanlis.Text = yanlis.ToString();
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            label3.Text = btnA.Text;
            Sonuclar();
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            label3.Text = btnb.Text;
            Sonuclar();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            label3.Text = btnC.Text;
            Sonuclar();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            label3.Text = btnD.Text;
            Sonuclar();
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            if (dogru > yanlis)
            {
                MessageBox.Show(dogru + " Doðru" + "\n" + yanlis + " Yanlýþ" + "\n" + "KAZANDINIZ :)");
            }
            else
            {
                MessageBox.Show(dogru + " Doðru" + "\n" + yanlis + " Yanlýþ" + "\n" + "KAYBETTÝNÝZ :(");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}