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
    public partial class FormHastaGiris : Form
    {
        public FormHastaGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        private void lblUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaKayıt hastaKayıt=new FormHastaKayıt();
            hastaKayıt.Show();
        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut =new SqlCommand("select * from Tbl_Hastalar where HastaTc=@p1 and HastaSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mtbxTc.Text);
            komut.Parameters.AddWithValue("@p2", tbxSifre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                FormHastaDetay hastaDetay = new FormHastaDetay();
                hastaDetay.tc = mtbxTc.Text;
                hastaDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Hatalı","Hata", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }

        private void FormHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
