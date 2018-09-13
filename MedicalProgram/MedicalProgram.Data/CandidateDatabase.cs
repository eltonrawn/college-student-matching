using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using MedicalProgram.Entity;

namespace MedicalProgram.Data
{
    public class CandidateDatabase
    {
        public void AddCandidate(int a, string b, int c, int d, int e, int f, int g)
        {
            string query = string.Format("INSERT INTO Candidate (CandidateId, Name, SSCPoint, HSCPoint, IsFreedomFighter, TribalCode, IsFirstTime) VALUES({0}, '{1}', {2}, {3}, {4}, {5}, {6})", a, b, c, d, e, f, g);
            Database.ExecuteQuery(query);
        }
        public void AddCandidateRes(int a, double b, double c, double d, double e, double f)
        {
            string query = string.Format("INSERT INTO CandidateResult (CandidateId, Biology, Chemistry, Physics, English, GeneralKnowledge) VALUES({0}, '{1}', {2}, {3}, {4}, {5})", a, b, c, d, e, f);
            Database.ExecuteQuery(query);

            
        }
        public void addCandidatePref(int candidateNo, List<College>pref)
        {
            /*
            string query = string.Format("INSERT INTO Preference (CandidateId, Pref1, Pref2, Pref3, Pref4, Pref5) VALUES({0}, '{1}', {2}, {3}, {4}, {5})", a, b, c, d, e, f);
            Database.ExecuteQuery(query);
            */
            for (int i = 0; i < pref.Count; i++){
                string query = string.Format("INSERT INTO Preference (CandidateId, CollegeId, PrefNo) VALUES({0}, {1}, {2})", candidateNo, pref[i].CollegeNo, i + 1);
                Database.ExecuteQuery(query);
            }

            LoginDatabase ld = new LoginDatabase();
            ld.updatePrefCnt(candidateNo);
        }
        public void delCandidatePref(int candidateNo)
        {
            
            string query = string.Format("DELETE FROM Preference WHERE CandidateId={0}", candidateNo);
            Database.ExecuteQuery(query);
            
        }

        //getall() mehods
        public List<Candidate> getAll()
        {
            string query1 = "SELECT CandidateId, Name, SSCPoint, HSCPoint, IsFreedomFighter, TribalCode, IsFirstTime FROM Candidate";
            SqlDataReader reader = Database.GetData(query1);

            List<Candidate> candidateList = new List<Candidate>();
            while (reader.Read())
            {
                /***/
                int a = Convert.ToInt32(reader["CandidateId"]);
                string b = reader["Name"].ToString();
                double c = Convert.ToDouble(reader["SSCPoint"]);
                double d = Convert.ToDouble(reader["HSCPoint"]);
                int e = Convert.ToInt32(reader["IsFreedomFighter"]);
                int f = Convert.ToInt32(reader["TribalCode"]);
                int g = Convert.ToInt32(reader["IsFirstTime"]);

                Candidate cn = new Candidate(a, b, c, d, e, f, g);

                /**********************inserting result**************************/
                ArrayList al = getByIdRes(a);
                //cn.setRes((double)al[1], (double)al[2], (double)al[3], (double)al[4], (double)al[5]);
                cn.setRes((double)al[0], (double)al[1], (double)al[2], (double)al[3], (double)al[4]);

                /**********************inserting preference**************************/
                cn.setPref(getByIdPref(a));

                /**********************add candidate now**************************/
                candidateList.Add(cn);
            }
            return candidateList;
        }

        public ArrayList getByIdRes(int canId)
        {
            //string query = "SELECT CandidateId, Biology, Chemistry, Physics, English, GeneralKnowledge FROM CandidateResult WHERE CandidateId=" + canId;
            string query = "SELECT Biology, Chemistry, Physics, English, GeneralKnowledge FROM CandidateResult WHERE CandidateId=" + canId;
            SqlDataReader reader = Database.GetData(query);
            reader.Read();
            ArrayList al = new ArrayList();
            if (reader.HasRows)
            {
                //al.Add(Convert.ToInt32(reader["CandidateId"]));
                al.Add(Convert.ToDouble(reader["Biology"]));
                al.Add(Convert.ToDouble(reader["Chemistry"]));
                al.Add(Convert.ToDouble(reader["Physics"]));
                al.Add(Convert.ToDouble(reader["English"]));
                al.Add(Convert.ToDouble(reader["GeneralKnowledge"]));
            }
            return al;
        }
        public string getCanName(int canId)
        {
            //string query = "SELECT CandidateId, Biology, Chemistry, Physics, English, GeneralKnowledge FROM CandidateResult WHERE CandidateId=" + canId;
            string query = "SELECT Name FROM Candidate WHERE CandidateId=" + canId;
            SqlDataReader reader = Database.GetData(query);
            reader.Read();
            if (reader.HasRows)
            {
                return reader["Name"].ToString();
            }
            return "";
        }
        
        public List<int> getByIdPref(int canId)
        {
            string query = "SELECT CollegeId, PrefNo FROM Preference WHERE CandidateId=" + canId;
            SqlDataReader reader = Database.GetData(query);
            List<int> al = new List<int>();
            List<ColbyPref> cbpl = new List<ColbyPref>();
            while (reader.Read()) {
                int a = Convert.ToInt32(reader["CollegeId"]);
                int b = Convert.ToInt32(reader["PrefNo"]);
                cbpl.Add(new ColbyPref(a, b));
            }
            cbpl.Sort(new PreferenceComparer());

            for (int i = 0;  i < cbpl.Count; i++){
                al.Add(cbpl[i].CollegeNo);
            }
            return al;
        }
    }

    public class ColbyPref  { 
        private int collegeNo, prefNo;
        public int CollegeNo
        {
            set { this.collegeNo = value; }
            get { return this.collegeNo; }
        }
        public int PrefNo
        {
            set { this.prefNo = value; }
            get { return this.prefNo; }
        }
        public ColbyPref(int a, int b) {
            CollegeNo = a;
            PrefNo = b;
        }
    }

    public class PreferenceComparer : IComparer<ColbyPref>
    {
        public int Compare(ColbyPref x, ColbyPref y)
        {
            if (x.PrefNo == y.PrefNo) return 0;
            else if (x.PrefNo > y.PrefNo) return 1;
            else return -1;
        }
    }
}

