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
    public partial class FormHastaKayıt : Form
    {
        public FormHastaKayıt()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAdi,HastaSoyadi, HastaTc, HastaTelefon, HastaSifre,HastaCinsiyet) values (@p1, @p2, @p3, @p4, @p5, @p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tbxAdi.Text);
            komut.Parameters.AddWithValue("@p2", tbxSoyadi.Text);
            komut.Parameters.AddWithValue("@p3", mtbxTc.Text);
            komut.Parameters.AddWithValue("@p4", mTbxTel.Text);
            komut.Parameters.AddWithValue("@p5", tbxSifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız gerçekleşmiştir. Şifreniz: " + tbxSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
