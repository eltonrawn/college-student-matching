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
    public partial class EditSystemMPForm : Form
    {
        AdminForm af;
        public EditSystemMPForm(AdminForm af)
        {
            InitializeComponent();
            this.af = af;
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "")) {
                MessageBox.Show("Please Fill Up Properly");
            }
            int val;
            if (int.TryParse(textBox1.Text, out val) == false)
            {
                MessageBox.Show("Give Integer Please");
                return;
            }
            if (int.TryParse(textBox2.Text, out val) == false)
            {
                MessageBox.Show("Give Integer Please");
                return;
            }
            if (int.TryParse(textBox3.Text, out val) == false)
            {
                MessageBox.Show("Give Integer Please");
                return;
            }

            new SystemMpService().setPassMark(Convert.ToInt32(textBox1.Text));
            new SystemMpService().setPrefLim(Convert.ToInt32(textBox2.Text));
            new SystemMpService().setPrefClgLim(Convert.ToInt32(textBox3.Text));

            af.Show();
            this.Close();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            af.Size = this.Size;
            af.Location = this.Location;
            af.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditSystemMPForm_Load(object sender, EventArgs e)
        {
            this.Size = af.Size;
            this.Location = af.Location;
        }
    }
}
