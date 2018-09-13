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
    public partial class AdminForm : Form
    {
        LoginForm lf;

        int konta;
        public AdminForm()
        {
            InitializeComponent();
        }
        public AdminForm(LoginForm lf)
        {
            InitializeComponent();
            this.lf = lf;

            cndGridView.AutoGenerateColumns = false;
            cndGridView2.AutoGenerateColumns = false;
            clgGridView.AutoGenerateColumns = false;
            finGridView.AutoGenerateColumns = false;
        }

        

        private void cndGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        void hideAll()   {
            cndGridView.Hide();
            cndGridView2.Hide();
            clgGridView.Hide();
            finGridView.Hide();
        }

        private void candidateButton_Click(object sender, EventArgs e)
        {
            konta = 1;

            hideAll();
            cndGridView.Show();

            CandidateService cs = new CandidateService();
            List<Candidate> cndList = cs.getAll();
            
            cndGridView.DataSource = cndList;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            konta = 2;

            hideAll();
            cndGridView2.Show();
            CandidateService cs = new CandidateService();
            List<Candidate> cndList = cs.getAll();
            
            cndGridView2.DataSource = cndList;
        }

        private void clgButton_Click(object sender, EventArgs e)
        {
            konta = 3;

            hideAll();
            clgGridView.Show();

            CollegeService cs = new CollegeService();
            List<College> clgList = cs.getAll();
            
            clgGridView.DataSource = clgList;
        }
        List<stuClg> stuClgList;
        private void appButton_Click(object sender, EventArgs e)
        {
            konta = 4;

            hideAll();
            finGridView.Show();

            RunStableMarriage rm = new RunStableMarriage();
            stuClgList = rm.runPls();
            finGridView.DataSource = stuClgList;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lf.Size = this.Size;
            lf.Location = this.Location;
            lf.WindowState = this.WindowState;
            lf.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void finGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditSystemMPForm(this).Show();
            this.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.Size = lf.Size;
            this.Location = lf.Location;
        }


        void searchErKaj() {
            if (konta == 1)
            {
                CandidateService cs = new CandidateService();
                List<Candidate> cndList = cs.getAllByName(textBox1.Text);
                cndGridView.DataSource = cndList;
            }

            if (konta == 2)
            {
                CandidateService cs = new CandidateService();
                List<Candidate> cndList = cs.getAllByName(textBox1.Text);
                cndGridView2.DataSource = cndList;
            }
            if (konta == 3)
            {
                CollegeService cs = new CollegeService();
                List<College> clgList = cs.getAllByName(textBox1.Text);
                clgGridView.DataSource = clgList;
            }
            if (konta == 4) {
                List<stuClg> filteredStuClgList = new List<stuClg>();
                foreach (stuClg can in stuClgList)
                {
                    if (can.StudentName.ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        filteredStuClgList.Add(can);
                    }
                }
                finGridView.DataSource = filteredStuClgList;
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            searchErKaj();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchErKaj();
        }
    }
}
