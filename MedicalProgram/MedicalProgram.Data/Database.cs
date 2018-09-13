using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MedicalProgram.Data
{
    public static class Database
    {
        static SqlConnection conn;
        static SqlConnection Connection
        {
            get
            {
                //conn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\Rawn\\Documents\\Visual Studio 2013\\Projects\\algo\\Database\\Database.mdf\";Integrated Security=True;Connect Timeout=30");
                conn = new SqlConnection(MedicalProgram.Data.Properties.Settings.Default.MpDbConnStr);
                conn.Open();
                return conn;
            }
        }

        public static int ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            return cmd.ExecuteNonQuery();
        }

        public static SqlDataReader GetData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            return cmd.ExecuteReader();
        }


    }
}