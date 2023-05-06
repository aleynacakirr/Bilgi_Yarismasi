using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane3
{
    public partial class FormSekreterGiris : Form
    {
        public FormSekreterGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();  
        private void FormSekreterGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("select * from Tbl_Sekreter where SekreterTc=@p1 and SekreterSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                FormSekreterDetay frs = new FormSekreterDetay();
                frs.TcNumara = maskedTextBox1.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }
    }
}
