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
    public partial class FormSekreterDetay : Form
    {
        public FormSekreterDetay()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        public string TcNumara;
        private void FormSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = TcNumara;
            //ad soyad çekme
            SqlCommand komut1=new SqlCommand("select SekreterAdSoyad from Tbl_Sekreter where SekreterTc=@p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr1= komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //branş çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select BransAdi from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //doktor çekme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (DoktorAdi+' '+DoktorSoyadi) as 'Doktorlar',DoktorBrans from Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //branşı combobox a aktarma
            SqlCommand komut2 = new SqlCommand("select BransAdi from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Randevu (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) values (@r1, @r2, @r3, @r4)", bgl.baglanti());
            komutKaydet.Parameters.AddWithValue("@r1", mtbxTarih.Text);
            komutKaydet.Parameters.AddWithValue("@r2", mtbxSaat.Text);
            komutKaydet.Parameters.AddWithValue("@r3", cmbBrans.Text);
            komutKaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);
            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut3= new SqlCommand("select DoktorAdi, DoktorSoyAdi from tbl_Doktorlar where DoktorBrans= @p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr=komut3.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rtbxDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu.");
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            FormDoktorPaneli frmdoktorpaneli=new FormDoktorPaneli();
            frmdoktorpaneli.Show();
        }

        private void btnBrans_Click(object sender, EventArgs e)
        {
            FormBransPaneli frmbrans=new FormBransPaneli();
            frmbrans.Show();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            FormRandevuListesi rndv=new FormRandevuListesi();
            rndv.Show();    
        }
    }
}
