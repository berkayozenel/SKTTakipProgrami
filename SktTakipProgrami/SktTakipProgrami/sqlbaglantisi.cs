using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace SktTakipProgrami
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-G0MHBCB3;Initial Catalog=SKTTakip;Integrated Security=True"); //for LENOVO 
            /*SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-U8T1L7P;Initial Catalog=SKTTakip;Integrated Security=True"); //for Coskunlar*/
            baglan.Open();
            return baglan;
            
        }
    }
}
