using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CMSH.Resources;

namespace CMSH
{
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelHFcreateaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            View.FormCreateAccount FCA = new View.FormCreateAccount();
            FCA.Show();
            
        }

        private void buttonHFlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            //View.FormDoctorAcc DA = new View.FormDoctorAcc();
            //DA.Show();
        }
    }
}
