using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalProgram.Core;
using MedicalProgram.Entity;

namespace MedicalProgram
{
    public partial class CandidateForm : Form
    {
        int candidateNo;
        LoginForm lf;
        public CandidateForm(int candidateNo, LoginForm lf)
        {
            InitializeComponent();
            
            //this.Size = lf.Size;
            clgGridView.AutoGenerateColumns = false;

            this.candidateNo = candidateNo;
            this.lf = lf;
        }

        private void buttonPref_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            hideAll();
            resTextBox.Show();

            if ((new LoginCheck()).getPrefCnt(candidateNo) != 0)
            {
            }
            else
            {
                resTextBox.Text = "Please give your preference first";
                //MessageBox.Show("Please give your preference first");
                return;
            }

            int collegeNo = (new LoginCheck()).getCollege(candidateNo);
            if (collegeNo == 0)
            {
                //MessageBox.Show("College : None");
                resTextBox.Text = "College : None";
            }
            else
            {
                string clg = (new CollegeService()).getCollege(collegeNo);
                //MessageBox.Show("College : " + clg);
                resTextBox.Text = "College : " + clg;
            }
        }
        /*
        private void backButton_Click(object sender, EventArgs e)
        {
            
        }
         * */

        private void CandidateForm_Load(object sender, EventArgs e)
        {
            this.Size = lf.Size;
            this.Location = lf.Location;
            //this.StartPosition = lf.StartPosition;
            //this.WindowState = lf.WindowState;
            //this.StartPosition = lf.StartPosition;
            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lf.Size = this.Size;
            lf.Location = this.Location;
            lf.Show();
            this.Close();
        }

        private void givePreferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /******************change hobe**********************/
            if ((new LoginCheck()).getPrefCnt(candidateNo) == (new SystemMpService()).getPrefLim())
            {
                MessageBox.Show("Your choice option is over");
                return;
            }
            else
            {
                (new PreferenceForm(candidateNo, this)).Show();
                this.Hide();
            }
        }

        void hideAll()   {
            resTextBox.Hide();
            clgGridView.Hide();
        }

        private void PrefButton_Click(object sender, EventArgs e)
        {
            hideAll();

            if ((new LoginCheck()).getPrefCnt(candidateNo)  != 0)
            {
            }
            else
            {
                resTextBox.Show();
                resTextBox.Text = "Please give your preference first";
                //MessageBox.Show("Please give your preference first");
                return;
            }
            
            clgGridView.Show();

            List<int> collegeId = (new CandidateService()).getByIdPref(candidateNo);
            List<College> clgList = new List<College>();
            for (int i = 0; i < collegeId.Count; i++){
                string clgName = (new CollegeService()).getCollege(collegeId[i]);
                College tmpClg = new College();tmpClg.CollegeNo = collegeId[i];tmpClg.CollegeName = clgName;
                clgList.Add(tmpClg);
            }
            
            clgGridView.DataSource = clgList;
        }
    }
}