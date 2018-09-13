using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MedicalProgram.Data
{
    public class LoginDatabase
    {
        public bool AdminLoginIdCheck(string LoginId)
        {
            string query = "SELECT LoginId FROM AdminLogin";
            SqlDataReader reader = Database.GetData(query);

            while (reader.Read())
            {
                string a = reader["LoginId"].ToString();
                if (a == LoginId)
                {
                    return true;
                }
                //int f = Convert.ToInt32(reader["TribalCode"]);
            }
            return false;
        }
        public bool AdminPassCheck(string LoginId, string pass)
        {
            string query = string.Format("SELECT Password FROM AdminLogin WHERE LoginId='{0}'", LoginId);
            SqlDataReader reader = Database.GetData(query);
            
            while (reader.Read())
            {
                string a = reader["Password"].ToString();
                if (a == pass)
                {
                    return true;
                }
                //int f = Convert.ToInt32(reader["TribalCode"]);
            }
            return false;
        }

        public bool CanLoginIdCheck(string LoginId)
        {
            string query = "SELECT LoginId FROM CandidateLogin";
            SqlDataReader reader = Database.GetData(query);

            while (reader.Read())
            {
                string a = reader["LoginId"].ToString();
                if (a == LoginId)
                {
                    return true;
                }
                //int f = Convert.ToInt32(reader["TribalCode"]);
            }
            return false;
        }
        public bool CanPassCheck(string LoginId, string pass)
        {
            string query = string.Format("SELECT Password FROM CandidateLogin WHERE LoginId='{0}'", LoginId);
            SqlDataReader reader = Database.GetData(query);

            while (reader.Read())
            {
                string a = reader["Password"].ToString();
                if (a == pass)
                {
                    return true;
                }
                //int f = Convert.ToInt32(reader["TribalCode"]);
            }
            return false;
        }
        public void updatePrefCnt(int candidateNo)    {
            int a = getPrefCnt(candidateNo);
            a++;

            string query = string.Format("UPDATE CandidateLogin SET PreferenceCnt={0} WHERE candidateNo={1}", a, candidateNo);
            Database.ExecuteQuery(query);
        }
        public void updateClg(int candidateNo, int collegeNo)   {
            string query = string.Format("UPDATE CandidateLogin SET CollegeCode={0} WHERE candidateNo={1}", collegeNo, candidateNo);
            Database.ExecuteQuery(query);
        }
        
        public int getPrefCnt(int candidateNo)
        {
            string query = string.Format("SELECT PreferenceCnt FROM CandidateLogin WHERE candidateNo='{0}'", candidateNo);
            SqlDataReader reader = Database.GetData(query);

            while (reader.Read())
            {
                int a = Convert.ToInt32(reader["PreferenceCnt"]);
                return a;
                //int f = Convert.ToInt32(reader["TribalCode"]);
            }
            return 0;
            //return false;
        }
        public int getCollege(int candidateNo)
        {
            string query = string.Format("SELECT CollegeCode FROM CandidateLogin WHERE candidateNo='{0}'", candidateNo);
            SqlDataReader reader = Database.GetData(query);

            while (reader.Read())
            {
                int a = Convert.ToInt32(reader["CollegeCode"]);
                return a;
                //int f = Convert.ToInt32(reader["TribalCode"]);
            }
            return 0;
            //return false;
        }
        
        public int getCandidateNo(int loginId)
        {
            string query = string.Format("SELECT CandidateNo FROM CandidateLogin WHERE LoginId='{0}'", loginId);
            SqlDataReader reader = Database.GetData(query);

            while (reader.Read())
            {
                int a = Convert.ToInt32(reader["CandidateNo"]);
                return a;
                //int f = Convert.ToInt32(reader["TribalCode"]);
            }
            return 0;
            //return false;
        }
        
    }
}
