using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MedicalProgram.Data
{
    public class SystemMpDatabase
    {
        public double getPassMark()
        {
            string query = string.Format("SELECT PassMark FROM SystemMP");
            SqlDataReader reader = Database.GetData(query);

            while (reader.Read())
            {
                double a = Convert.ToDouble(reader["PassMark"]);
                return a;
                //int f = Convert.ToInt32(reader["TribalCode"]);
            }
            return 0;
        }

        public int getPrefLim()
        {
            string query = string.Format("SELECT PrefLimit FROM SystemMP");
            SqlDataReader reader = Database.GetData(query);

            while (reader.Read())
            {
                int a = Convert.ToInt32(reader["PrefLimit"]);
                return a;
                //int f = Convert.ToInt32(reader["TribalCode"]);
            }
            return 0;
        }
        public int getPrefClgLim()
        {
            string query = string.Format("SELECT PrefClgLim FROM SystemMP");
            SqlDataReader reader = Database.GetData(query);

            while (reader.Read())
            {
                int a = Convert.ToInt32(reader["PrefClgLim"]);
                return a;
                //int f = Convert.ToInt32(reader["TribalCode"]);
            }
            return 0;
        }


        /*****************************************/
        public void setPassMark(int a)
        {
            string query = string.Format("UPDATE SystemMP SET PassMark={0} WHERE Id=1", a);
            Database.ExecuteQuery(query);
        }

        public void setPrefLim(int a)
        {
            string query = string.Format("UPDATE SystemMP SET PrefLimit={0} WHERE Id=1", a);
            Database.ExecuteQuery(query);
        }
        public void setPrefClgLim(int a)
        {
            string query = string.Format("UPDATE SystemMP SET PrefClgLim={0} WHERE Id=1", a);
            Database.ExecuteQuery(query);
        }
    }
}
