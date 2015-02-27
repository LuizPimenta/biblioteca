using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BibliotecaClassLibrary.Data
{
    internal class DBConnection
    {
        protected SqlConnection conn;

        internal DBConnection(string strConn)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        internal void Dispose()
        {
            conn.Close();
        }
    }
}
