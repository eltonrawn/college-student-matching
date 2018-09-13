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
    public partial class PreferenceForm : Form
    {
        List<College> originalClgList;
        List<College> clgList, selectedList;

        int[] clgChk;

        CandidateForm cf;
        int candidateNo;
        public PreferenceForm(int candidateNo, CandidateForm cf)
        {
            InitializeComponent();
            this.cf = cf;
            this.candidateNo = candidateNo;

            clgList = (new CollegeService()).getAll();
            selectedList = new List<College>();

            clgChk = new int[clgList.Count + 10];
            for (int i = 0; i < clgList.Count; i++)
            {
                clgChk[i] = 0;
            }
            originalClgList = clgList;

            clgGridView.AutoGenerateColumns = false;
            selectedGridView.AutoGenerateColumns = false;
            refresh();
        }

        public PreferenceForm(int candidateNo)
        {
            InitializeComponent();
            this.candidateNo = candidateNo;

            clgList = (new CollegeService()).getAll();
            selectedList = new List<College>();

            clgChk = new int[clgList.Count + 10];
            for (int i = 0; i < clgList.Count; i++)
            {
                clgChk[i] = 0;
            }
            originalClgList = clgList;

            clgGridView.AutoGenerateColumns = false;
            selectedGridView.AutoGenerateColumns = false;
            refresh();
            
        }

        //College tmpclg;
        private void clgGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) {
                int clgLim = (new SystemMpService()).getPrefClgLim();
                if (selectedList.Count == clgLim)
                {
                    MessageBox.Show("Can't add more than " + clgLim);
                    return;
                }

                College tmpclg = clgList[e.RowIndex];
                
                int row = e.RowIndex;

                clgGridView.DataSource = null;//eita na korle hoi na
                clgList.RemoveAt(row);

                //selectedGridView.DataSource = null;
                selectedList.Add(tmpclg);

                //MessageBox.Show(selectedList.Count + "");
                refresh();
            }
        }

        
        private void selectedGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            if (e.ColumnIndex == 2)
            {

                College tmpclg = selectedList[e.RowIndex];

                int row = e.RowIndex;

                selectedGridView.DataSource = null;//eita na korle hoi na
                selectedList.RemoveAt(row);

                clgList.Add(tmpclg);

                refresh();
            }
            
        }

        void refresh()
        {

            clgGridView.DataSource = null;
            clgGridView.DataSource = clgList.ToArray();


            selectedGridView.DataSource = null;
            selectedGridView.DataSource = selectedList.ToArray();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //delete first
            (new CandidateService()).delCandidatePref(candidateNo);
            (new CandidateService()).addCandidatePref(candidateNo, selectedList);


            this.Close();
            cf.Size = this.Size;
            cf.Location = this.Location;
            cf.Show();
        }

        private void PreferenceForm_Load(object sender, EventArgs e)
        {
            this.Size = cf.Size;
            this.Location = cf.Location;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
/*
http://stackoverflow.com/questions/180629/remove-last-row-databound-datagridview-c-sharp
 
 
 http://stackoverflow.com/questions/1435526/datagridview-object-databinding-issue-index-1-does-not-have-a-value
 **/
