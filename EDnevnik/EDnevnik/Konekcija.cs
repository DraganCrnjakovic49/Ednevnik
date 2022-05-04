using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace EDnevnik
{
    class Konekcija
    {
        static public SqlConnection Connect()
        {
            string cs;
            cs = ConfigurationManager.ConnectionStrings["kuca"].ConnectionString;
            SqlConnection veza = new SqlConnection(cs);
            return veza;
        }
    }
}
