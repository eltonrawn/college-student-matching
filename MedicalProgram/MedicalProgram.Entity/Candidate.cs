using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalProgram.Entity
{
    public class Candidate
    {
        private double totalMark;
        private double biologyMark, chemMark, phyMark, engMark, gkMark;//30, 25, 20, 15, 10
        private int candidateNo, collegeNo, tribalCode;

        private double sscMark, hscMark;

        private string name;

        private int isFF, isFirst;
        public List<int> preference;

        private double admMark;

        string status;

        public int CandidateNo
        {
            set { this.candidateNo = value; }
            get { return this.candidateNo; }
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public double SscMark
        {
            set { this.sscMark = value; }
            get { return this.sscMark; }
        }
        public double HscMark
        {
            set { this.hscMark = value; }
            get { return this.hscMark; }
        }
        public int IsFF
        {
            set { this.isFF = value; }
            get { return this.isFF; }
        }
        public int TribalCode
        {
            set { this.tribalCode = value; }
            get { return this.tribalCode; }
        }
        public int IsFirst
        {
            set { this.isFirst = value; }
            get { return this.isFirst; }
        }
        /*******************candidate Res***********************************/
        public double BioMark
        {
            set { this.biologyMark = value; }
            get { return this.biologyMark; }
        }
        public double ChemMark
        {
            set { this.chemMark = value; }
            get { return this.chemMark; }
        }
        public double PhyMark
        {
            set { this.phyMark = value; }
            get { return this.phyMark; }
        }
        public double EngMark
        {
            set { this.engMark = value; }
            get { return this.engMark; }
        }
        public double GkMark
        {
            set { this.gkMark = value; }
            get { return this.gkMark; }
        }
        

        //bakigula
        public double TotalMark
        {
            set { this.totalMark = value; }
            get { return this.totalMark; }
        }
        public int CollegeNo
        {
            set { this.collegeNo = value; }
            get { return this.collegeNo; }
        }

        public string Status
        {
            set { this.status = value; }
            get { return this.status; }
        }
        public Candidate()
        {
        }

        public Candidate(int cno, string nm, double a, double b, int c, int d, int e)
        {
            //preference = new List<int>();
            /**
            preference.Add(0);//invalid
            preference.Add(1); preference.Add(2); preference.Add(3); preference.Add(4);
            */

            candidateNo = cno;
            name = nm;

            sscMark = a;
            hscMark = b;

            isFF = c;
            tribalCode = d;

            isFirst = e;

            if (isFirst == 0)
            {
                totalMark -= 5;
            }
            ///isTribal = g;
            totalMark += (sscMark * 15) + (hscMark * 25);
        }

        public void setRes(double e, double f, double g, double h, double i)
        {
            biologyMark = e;
            chemMark = f;
            phyMark = g;
            engMark = h;
            gkMark = i;
            admMark = e + f + g + h + i;//adm = admission
            totalMark += admMark;
        }

        public void setPref(List<int> lelist)
        {
            preference = lelist;
        }
        public void show()
        {
            ///Console.WriteLine("totMarks : " + totalMark);
            Console.WriteLine(candidateNo + " " + name + " " + totalMark + " " + biologyMark + " " + chemMark + " " + phyMark + " " + engMark + " " + gkMark + " " + isFF + " " + tribalCode);
        }
        public void showPref()
        {
            ///Console.WriteLine("totMarks : " + totalMark);
            Console.Write(candidateNo + " ");
            for (int i = 0; i < Math.Min(5, preference.Count); i++)
            {
                Console.Write(preference[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
