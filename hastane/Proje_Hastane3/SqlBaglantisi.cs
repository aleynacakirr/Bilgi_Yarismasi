using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane3
{
    public class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-388UKOD;Initial Catalog=Hastane_Projesi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
