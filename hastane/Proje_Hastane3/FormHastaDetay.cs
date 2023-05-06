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
    public partial class FormHastaDetay : Form
    {
        public FormHastaDetay()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        public string tc;
        private void FormHastaDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;
            //ad soyad çekme
            SqlCommand komut=new SqlCommand("select HastaAdi, HastaSoyadi from Tbl_Hastalar where HastaTc=@p1",bgl.baglanti());
            komut.Parameters.Add("@p1", lblTc.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Tbl_Randevu where HastaTc=" +tc, bgl.baglanti());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            //branşları çekme
            SqlCommand komut2 = new SqlCommand("select BransAdi from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2=komut2.ExecuteReader();
            while (dr2.Read()) 
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            //doktor çekme
            SqlCommand komut3 = new SqlCommand("select DoktorAdi, DoktorSoyadi from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Tbl_Randevu where RandevuBrans='"+cmbBrans+"'",bgl.baglanti());
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linklblBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBilgiDuzenle formBilgiDuzenle=new FormBilgiDuzenle();
            formBilgiDuzenle.TcNo = lblTc.Text;
            formBilgiDuzenle.Show();

        }
    }
}
