using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalProgram
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new PreferenceForm(1));
            //Application.Run(new CollegeDbView());
            //Application.Run(new CandidateDbView());
            //Application.Run(new CandidateResDbView());
            //Application.Run(new PreferenceForm(5);
            //Application.Run(new CandidateForm(3, new LoginForm()));
        }
    }
}
