using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalProgram.Entity;
using MedicalProgram.Data;

namespace MedicalProgram.Core
{
    public class CandidateService
    {
        public List<Candidate> getAll()
        {
            CandidateDatabase cd = new CandidateDatabase();
            return cd.getAll();
        }
        public List<Candidate> getAllByName(string name)
        {

            List<Candidate> canList = getAll();
            List<Candidate> filteredCanList = new List<Candidate>();
            foreach (Candidate can in canList)
            {
                if (can.Name.ToLower().Contains(name.ToLower()))
                {
                    filteredCanList.Add(can);
                }
            }
            return filteredCanList;
        }

        public List<int> getByIdPref(int canId)
        {
            CandidateDatabase cd = new CandidateDatabase();
            
            return cd.getByIdPref(canId);
        }

        public void addCandidatePref(int candidateNo, List<College>pref)
        {
            CandidateDatabase cd = new CandidateDatabase();
            cd.addCandidatePref(candidateNo, pref);
        }
        public void delCandidatePref(int candidateNo)
        {
            CandidateDatabase cd = new CandidateDatabase();
            cd.delCandidatePref(candidateNo);
        }
        public string getCanName(int canId)
        {
            CandidateDatabase cd = new CandidateDatabase();

            return cd.getCanName(canId);
        }
    }
}
