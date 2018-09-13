using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalProgram.Entity;
using MedicalProgram.Data;


namespace MedicalProgram.Core
{
    public class CollegeService
    {
        public List<College> getAll() {
            CollegeDatabase cd = new CollegeDatabase();
            return cd.GetAll();
        }
        public List<College> getAllByName(string name)
        {

            List<College> canList = getAll();
            List<College> filteredCanList = new List<College>();
            foreach (College clg in canList)
            {
                if (clg.CollegeName.ToLower().Contains(name.ToLower()))
                {
                    filteredCanList.Add(clg);
                }
            }
            return filteredCanList;
        }
        public bool checkCollege(string collegeCode) { 
            return (new CollegeDatabase()).checkCollege(Convert.ToInt32(collegeCode));
        }
        public string getCollege(int collegeCode)
        {
            return (new CollegeDatabase()).getCollege(collegeCode);
        }
    }
}
