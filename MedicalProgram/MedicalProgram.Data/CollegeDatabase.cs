using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MedicalProgram.Entity;
//using MedicalProgram.Core;



namespace MedicalProgram.Data
{
    public class CollegeDatabase
    {

        public CollegeDatabase()
        {
        }
        public void AddCollege(int a, string b, int c, int d, int e, int f)
        {
            string query = string.Format("INSERT INTO College (CollegeCode, CollegeName, GeneralSeats, FFSeats, TribalSeats, TribalCode) VALUES({0}, '{1}', {2}, {3}, {4}, {5})", a, b, c, d, e, f);
            Database.ExecuteQuery(query);
        }
        public List<College> GetAll()
        {
            string query = "SELECT CollegeCode, CollegeName, GeneralSeats, FFSeats, TribalSeats, TribalCode FROM College";
            SqlDataReader reader = Database.GetData(query);

            College college;
            List<College> collegeList = new List<College>();
            
            while (reader.Read())
            {
                int a = Convert.ToInt32(reader["CollegeCode"]);
                string b = reader["CollegeName"].ToString();
                int c = Convert.ToInt32(reader["GeneralSeats"]);
                int d = Convert.ToInt32(reader["FFSeats"]);
                int e = Convert.ToInt32(reader["TribalSeats"]);
                int f = Convert.ToInt32(reader["TribalCode"]);

                college = new College(a, b, c, d, e, f);
                collegeList.Add(college);
            }
            return collegeList;
        }
        public bool checkCollege(int collegeCode)
        {
            string query = "SELECT CollegeCode FROM College";
            SqlDataReader reader = Database.GetData(query);


            while (reader.Read())
            {
                int a = Convert.ToInt32(reader["CollegeCode"]);

                if (a == collegeCode) {
                    return true;
                }
            }
            return false;
        }
        public string getCollege(int collegeCode)
        {
            string query = String.Format("SELECT CollegeName FROM College WHERE CollegeCode={0}", collegeCode);
            SqlDataReader reader = Database.GetData(query);


            while (reader.Read())
            {
                string a = reader["CollegeName"].ToString();

                return a;
            }
            return "";
        }
        
    }

}
