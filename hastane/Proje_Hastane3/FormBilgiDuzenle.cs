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
    public partial class FormBilgiDuzenle : Form
    {
        public FormBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TcNo;
        SqlBaglantisi bgl=new SqlBaglantisi();
        private void FormBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mtbxTc.Text = TcNo;
            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mtbxTc.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                tbxAdi.Text = dr[1].ToString();
                tbxSoyadi.Text = dr[2].ToString();
                mTbxTel.Text= dr[4].ToString();
                tbxSifre.Text = dr[5].ToString();
                cmbCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAdi=@p1, HastaSoyadi=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5 where HastaTc=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", tbxAdi.Text);
            komut2.Parameters.AddWithValue("@p2", tbxSoyadi.Text);
            komut2.Parameters.AddWithValue("@p3", mTbxTel.Text);
            komut2.Parameters.AddWithValue("@p4", tbxSifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", mtbxTc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
    }
}
