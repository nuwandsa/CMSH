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
    public partial class Formtechacc : Form
    {
        public Formtechacc()
        {
            InitializeComponent();
        }

        private void labelmd_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
