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
    public partial class FormDoktorPaneli : Form
    {
        public FormDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            //bransları combobax'a aktarma
            SqlCommand komut2 = new SqlCommand("select BransAdi from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("insert into Tbl_Doktorlar(DoktorAdi, DoktorSoyadi,DoktorBrans, DoktorTc, DoktorSifre) values (@d1, @d2, @d3, @d4, @d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",tbxAdi.Text);
            komut.Parameters.AddWithValue("@d2", tbxSoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", mtbxTc.Text);
            komut.Parameters.AddWithValue("@d5", tbxSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbxAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbxSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mtbxTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tbxSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("delete from Tbl_Doktorlar where DoktorTc= @d1", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",mtbxTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAdi =@d1, DoktorSoyadi=@d2, DoktorBrans=@d3, DoktorSifre=@d5 where DoktorTc=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", tbxAdi.Text);
            komut.Parameters.AddWithValue("@d2", tbxSoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", mtbxTc.Text);
            komut.Parameters.AddWithValue("@d5", tbxSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
