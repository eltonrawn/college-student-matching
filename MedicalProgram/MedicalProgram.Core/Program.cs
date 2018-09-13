using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalProgram.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            RunStableMarriage rm = new RunStableMarriage();
            rm.runPls();
        }
    }
}
