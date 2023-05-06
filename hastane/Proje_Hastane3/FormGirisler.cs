using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane3
{
    public partial class FormGirisler : Form
    {
        public FormGirisler()
        {
            InitializeComponent();
        }

        private void btnHastaGirisi_Click(object sender, EventArgs e)
        {
            FormHastaGiris giris = new FormHastaGiris();
            giris.Show();
            this.Hide();
        }

        private void btnDoktorGirisi_Click(object sender, EventArgs e)
        {
            FormDoktorGiris doktorGiris = new FormDoktorGiris();
            doktorGiris.Show();
            this.Hide();
        }

        private void btnSekreterGirisi_Click(object sender, EventArgs e)
        {
            FormSekreterGiris sekreterGiris = new FormSekreterGiris();
            sekreterGiris.Show();
            this.Hide();
        }
    }
}
