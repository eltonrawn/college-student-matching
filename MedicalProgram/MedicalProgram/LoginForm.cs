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

namespace MedicalProgram
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void IdTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if ((IdTxtBox.Text == "") || (PassTxtBox.Text == "")) {
                MessageBox.Show("Please Fill Up Properly");
                return;
            }
            
            if((IdTxtBox.Text.Length >= 3))   {
                string tmp = "";
                tmp += IdTxtBox.Text[0];
                tmp += IdTxtBox.Text[1];
                tmp += IdTxtBox.Text[2];
                //MessageBox.Show(tmp);
                //if (tmp.Equals("ADM"))
                if (tmp == "ADM")
                { //admin login
                    if ((new LoginCheck()).AdminLoginIdCheck(IdTxtBox.Text) == false) {
                        MessageBox.Show("Invalid Login Id");
                        return;
                    }
                    if ((new LoginCheck()).AdminPassCheck(IdTxtBox.Text, PassTxtBox.Text) == false)
                    {
                        MessageBox.Show("Invalid Password");
                        return;
                    }
                    ///new AdminPage();
                    //MessageBox.Show("Hoise 1");
                    (new AdminForm(this)).Show();
                    /**
                    AdminForm adminForm = new AdminForm(this);
                    adminForm.Show();
                    adminForm.Size = this.Size;
                     * */
                    IdTxtBox.Text = "";
                    PassTxtBox.Text = "";
                    this.Hide();
                    return;
                }
                
            }

            if ((new LoginCheck()).CanLoginIdCheck(IdTxtBox.Text) == false)
            {
                MessageBox.Show("Invalid Login Id");
                return;
            }
            if ((new LoginCheck()).CanPassCheck(IdTxtBox.Text, PassTxtBox.Text) == false)
            {
                MessageBox.Show("Invalid Password");
                return;
            }

            int candidateNo = (new LoginCheck()).getCandidateNo(Convert.ToInt32(IdTxtBox.Text));

            //MessageBox.Show("" + candidateNo);
            (new CandidateForm(candidateNo, this)).Show();
            IdTxtBox.Text = "";
            PassTxtBox.Text = "";
            this.Hide();
            //MessageBox.Show("Hoise 2");
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void IdLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
