using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalProgram.Data;

namespace MedicalProgram.Core
{
    public class SystemMpService
    {
        public double getPassMark()
        {
            return (new SystemMpDatabase()).getPassMark();
        }
        public int getPrefLim()
        {
            return (new SystemMpDatabase()).getPrefLim();
        }
        public int getPrefClgLim()
        {
            return (new SystemMpDatabase()).getPrefClgLim();
        }

        public void setPassMark(int a)
        {
            new SystemMpDatabase().setPassMark(a);
        }
        public void setPrefLim(int a)
        {
            new SystemMpDatabase().setPrefLim(a);
        }
        public void setPrefClgLim(int a)
        {
            new SystemMpDatabase().setPrefClgLim(a);
        }
    }
}
