using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsemkaLaundryX.Setup
{
    class DBConnection
    {
        public SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-NQPTINB\SQLEXPRESS; Initial Catalog = esemkaLaundryDB; Integrated Security = True");
    }
}
