using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalProgram.Data;
using MedicalProgram.Entity;

namespace MedicalProgram.Core
{
    public class stuClg {
        int studentNo, clgNo;
        string studentName, clgName;
        string status;//sit status
        public int StudentNo
        {
            set { this.studentNo = value; }
            get { return this.studentNo; }
        }
        public int ClgNo
        {
            set { this.clgNo = value; }
            get { return this.clgNo; }
        }
        public string StudentName
        {
            set { this.studentName = value; }
            get { return this.studentName; }
        }
        public string ClgName
        {
            set { this.clgName = value; }
            get { return this.clgName; }
        }
        public string Status
        {
            set { this.status = value; }
            get { return this.status; }
        }
        
        public stuClg(int a, int b, string c) {
            StudentNo = a;
            ClgNo = b;
            Status = c;

            StudentName = (new CandidateService()).getCanName(StudentNo);
            ClgName = (new CollegeService()).getCollege(ClgNo);
        }
    }
    public class RunStableMarriage
    {
        //Candidate candAra[];
        List<Candidate> candidateList;
        List<College> collegeList;
        ///public List<int> CollegeInd;
        public int[] collegeInd;
        public RunStableMarriage()
        {
        }
        public List<stuClg> runPls()
        {
            
            candidateList = (new CandidateDatabase()).getAll();
            candidateList.Sort(new CandidateComparer());
            showCandidate();
            //showPref();
            ///func();
            collegeList = (new CollegeDatabase()).GetAll();
            collegeInd = new int[collegeList.Count + 100];
            setCollegeInd();
            //showCollege();
            ///showCollegeCandidates();
            ///showCollegeInd();
            assignAllPreference();
            showAllPreference();

            func();
            showCollegeCandidates();
            ///shesh hoise shob

            List<stuClg> stuclgList = new List<stuClg>();
            for (int i = candidateList.Count - 1; i >= 0; i--)
            {
                if (candidateList[i].CollegeNo == 0)
                {
                    continue;
                }
                new LoginCheck().updateClg(candidateList[i].CandidateNo, candidateList[i].CollegeNo);
                stuclgList.Add(new stuClg(candidateList[i].CandidateNo, candidateList[i].CollegeNo, candidateList[i].Status));
            }
            return stuclgList;
        }
        void assignAllPreference()   {
            //Console.WriteLine("CollegeList size : " + collegeList.Count);
            for (int i = 0; i < candidateList.Count; i++)
            {
                int[] ara = new int[collegeList.Count + 100];
                for (int j = 0; j < (collegeList.Count + 100); j++)
                {
                    ara[j] = 0;
                }
                for (int j = 0; j < candidateList[i].preference.Count; j++)
                {
                    int collegeNo = candidateList[i].preference[j];
                    if (collegeNo == 0) {
                        //checking if valid //database change korar por ei checking ar dorkar nai
                        continue;
                    }
                    ara[collegeNo]++;
                }

                for (int j = 0; j < collegeList.Count; j++)
                {
                    int collegeNo = collegeList[j].CollegeNo;
                    if (ara[collegeNo] != 0) {
                        continue;
                    }
                    candidateList[i].preference.Add(collegeNo);
                }
            }
        }
        void showAllPreference()
        {
            Console.Write("Preferences : \n");
            for (int i = 0; i < candidateList.Count; i++)
            {
                Console.Write(candidateList[i].CandidateNo + " : ");
                
                for (int j = 0; j < candidateList[i].preference.Count; j++)
                {
                    int collegeNo = candidateList[i].preference[j];
                    Console.Write(collegeNo + " ");
                }
                Console.Write("\n");
            }
        }
        void setCollegeInd() {
            int ind = 0;
            for (int i = 0; i < collegeList.Count; i++){
                int collegeNo = collegeList[i].CollegeNo;
                collegeInd[collegeNo] = ind;
                ind++;
            }
        }
        int getCollegeInd(int collegeNo)
        {
            return collegeInd[collegeNo];
        }
        void showCandidate()
        {
            Console.WriteLine("candidates : ");
            for (int i = 0; i < candidateList.Count; i++)
            {
                candidateList[i].show();
            }
        }
        void showPref()
        {
            Console.WriteLine("preference : ");
            for (int i = 0; i < candidateList.Count; i++)
            {
                candidateList[i].showPref();
            }
        }
        void showCollegeInd()
        {
            for (int i = 11; i <= 13; i++)
            {
                Console.WriteLine(i + " " + getCollegeInd(i));
            }
        }
        void showCollege()
        {
            for (int i = 0; i < collegeList.Count; i++)
            {
                ///int ind = ;
                collegeList[i].show();
            }
        }
        void showCollegeCandidates()
        {
            for (int i = 0; i < collegeList.Count; i++)
            {
                Console.Write(collegeList[i].CollegeNo + " : ");
                for (int j = 0; j < collegeList[i].candidateNoList.Count; j++)
                {
                    int candidateNo = collegeList[i].candidateNoList[j];
                    Console.Write(" " + candidateNo);
                }
                Console.WriteLine();
            }
        }

        /*****************************stable marriage Algo**************************************/
        void func()
        {
            Console.WriteLine("Hi");
            //initialize start
            for (int i = 0; i < candidateList.Count; i++)
            {
                candidateList[i].CollegeNo = 0;
            }

            for (int i = 0; i < collegeList.Count; i++)
            {
                collegeList[i].candidateNoList.Clear();

                collegeList[i].FFFilled = 0; collegeList[i].TribalFilled = 0;
                collegeList[i].Meritcnt = 0;
                ///Console.WriteLine("College : " + collegeList[i].collegeNo + " : " + collegeList[i].meritSeat);
            }
            //initialize end

            //main kaj shuru
            for (int i = candidateList.Count - 1; i >= 0; i--)
            {
                Console.Write(candidateList[i].CandidateNo + " : ");

                for (int j = 0; j < candidateList[i].preference.Count; j++)
                {

                    int collegeNo = candidateList[i].preference[j];
                    if (collegeNo == 0) {
                        continue;
                    }

                    if (assignCollege(candidateList[i], collegeList[getCollegeInd(collegeNo)]) == true)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
            //main kaj shesh


            bool recur_it = false;
            for (int i = 0; i < collegeList.Count; i++)
            {
                if ((collegeList[i].FFFilled < collegeList[i].FFReserved) || (collegeList[i].TribalFilled < collegeList[i].TribalReserved))
                {
                    collegeList[i].changeReserved();
                    recur_it = true;
                }
            }
            if (recur_it)
            {
                func();
            }
        }

        bool assignCollege(Candidate candidate, College clg)
        {
            if (candidate.TotalMark <= (new SystemMpService()).getPassMark())
            {
                return false;
            }

            if (candidate.IsFF == 1)
            {
                if (clg.FFFilled < clg.FFReserved)
                {
                    clg.FFFilled++;
                    clg.candidateNoList.Add(candidate.CandidateNo);

                    candidate.CollegeNo = clg.CollegeNo;
                    candidate.Status = "Freedom Fighter";
                    Console.Write("fir " + clg.CollegeNo + " " + clg.Meritcnt + " " + clg.MeritSeat + ", ");
                    return true;
                }
            }
            if (candidate.TribalCode == clg.TribalCode)
            {
                if (clg.TribalFilled < clg.TribalReserved)
                {
                    clg.TribalFilled++;
                    clg.candidateNoList.Add(candidate.CandidateNo);

                    candidate.CollegeNo = clg.CollegeNo;
                    candidate.Status = "Tribal";
                    Console.Write("sec " + clg.CollegeNo + " " + clg.Meritcnt + " " + clg.MeritSeat + ", ");
                    return true;
                }
            }

            if (clg.Meritcnt < clg.MeritSeat)
            {
                clg.Meritcnt++;
                clg.candidateNoList.Add(candidate.CandidateNo);

                candidate.CollegeNo = clg.CollegeNo;
                candidate.Status = "Merit";
                Console.Write("thir " + clg.CollegeNo + " " + clg.Meritcnt + " " + clg.MeritSeat + ", ");
                return true;
            }
            Console.Write("hoinai");
            return false;
        }
    }
}
/**
candidateList = new List<Candidate>();
candidateList.Add(new Candidate());///invalid
candidateList.Add(new Candidate(1, 2, 2, 3, 3, 5, true, false));
candidateList.Add(new Candidate(2, 3, 2, 3, 4, 5, false, false));
candidateList.Add(new Candidate(3, 5, 2, 3, 4, 5, true, true));
candidateList.Add(new Candidate(4, 2, 2, 3, 7, 5, false, true));

candidateList.Sort(new CandidateComparer());
*/

/**
collegeList = new List<College>();
collegeList.Add(new College());///invalid
collegeList.Add(new College(1, 3, 2, 1));
collegeList.Add(new College(2, 3, 1, 1));
collegeList.Add(new College(3, 2, 1, 0));
collegeList.Add(new College(4, 1, 1, 0));
*/