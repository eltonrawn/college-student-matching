using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalProgram.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class College
    {
        private int collegeNo, totalSeat, ffReserved, tribalReserved, tribalCode;//ff = freedom fighter

        private int meritSeat, ffFilled, tribalFilled;
        private int meritcnt;

        private string collegeName;

        public List<int> candidateNoList;

        public int CollegeNo
        {
            set { this.collegeNo = value; }
            get { return this.collegeNo; }
        }
        public string CollegeName
        {
            set { this.collegeName = value; }
            get { return this.collegeName; }
        }
        public int TotalSeat
        {
            set { this.totalSeat = value; }
            get { return this.totalSeat; }
        }
        public int FFReserved
        {
            set { this.ffReserved = value; }
            get { return this.ffReserved; }
        }
        public int TribalReserved
        {
            set { this.tribalReserved = value; }
            get { return this.tribalReserved; }
        }
        public int TribalCode
        {
            set { this.tribalCode = value; }
            get { return this.tribalCode; }
        }


        ///baki gula
        public int FFFilled
        {
            set { this.ffFilled = value; }
            get { return this.ffFilled; }
        }
        public int TribalFilled
        {
            set { this.tribalFilled = value; }
            get { return this.tribalFilled; }
        }
        public int Meritcnt {
            set { this.meritcnt = value; }
            get { return this.meritcnt; }
        }
        public int MeritSeat
        {
            set { this.meritSeat = value; }
            get { return this.meritSeat; }
        }
        
        public College()
        {

        }
        public College(int a, string b, int c, int d, int e, int f)
        {
            candidateNoList = new List<int>();
            ///candidateNoList.Add(0);//invalid

            collegeNo = a;
            collegeName = b;
            totalSeat = c;
            ffReserved = d;
            tribalReserved = e;

            tribalCode = f;

            meritSeat = totalSeat - (ffReserved + tribalReserved);
            meritcnt = 0;
        }
        public void changeReserved()
        {
            ffReserved = ffFilled;
            tribalReserved = tribalFilled;
            //ffFilled = 0; tribalFilled = 0;
            meritSeat = totalSeat - (ffReserved + tribalReserved);
        }
        public void show()
        {
            Console.WriteLine(collegeNo + " " + collegeName + " " + totalSeat + " " + ffReserved + " " + tribalReserved + " " + tribalCode);
        }
    }
}
