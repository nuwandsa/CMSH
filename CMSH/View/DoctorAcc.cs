using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSH.View
{
    public partial class FormDoctorAcc : Form
    {
        public FormDoctorAcc()
        {
            InitializeComponent();
        }

       

       

       

        private void DoctorAcc_Load(object sender, EventArgs e)
        {

        }

        private void labeldaexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labeldamaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void labeldaminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
