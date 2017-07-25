using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMSH.Control;
using CMSH.Model;


namespace CMSH.View
{
    public partial class FormDoctoracc : Form
    {
        public FormDoctoracc()
        {
            InitializeComponent();
        }

        private void labelmd_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttondapcheck_Click(object sender, EventArgs e)
        {
            paneldapatient.Visible = true;
            Checkups chckups = new Checkups();
            chckups.Pid =int.Parse(textBoxdapid.Text);

            /*Formrcmndcheckups Formreccheckups = new Formrcmndcheckups();
            Formreccheckups.senddata(chckups);*/

            setvaluespatnt();
        }
        public void set_values(User user,Doctors dctr)
        {
            MessageBox.Show(dctr.Hospital);
            labeldctrname.Text = user.Fname+user.Lname;
            labeldctrqualifications.Text = dctr.Qualification;
            labeldctrdesignation.Text = dctr.Designation;
            labeldctrhospital.Text = dctr.Hospital;
            //pictureBoxdadrimg.Image =ByteToImage(user.Pic,user.Imgsize);

        }

        public void setvaluespatnt()
        {

            //Patients ptnt = new Patients();
            User ur = new User();
            Patients ptnt = new Patients();
            usermng umng = new usermng();
            int uid = int.Parse(textBoxdapid.Text);
            umng.getdatafrmpatnt(ur, ptnt, uid);



            labeldapname.Text = ur.Fname + " " + ur.Lname;
            labeldaaddress.Text = ptnt.Address;
            labeldapnic.Text = ur.Nic;

            DateTime bday = Convert.ToDateTime(ptnt.BDay);
            DateTime now = DateTime.Today;
            int age = now.Year - bday.Year;

            labeldapage.Text = Convert.ToString(age);
            






        }
        /*public static Image ByteToImage(byte[]blob,int size )
        {
            
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(size));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
            MemoryStream memstr = new MemoryStream(blob);
             Image X = Image.FromStream(memstr);
            //Image X = (Bitmap)((new ImageConverter()).ConvertFrom(blob));
            return X;
        } */

        private void labeldctrname_Click(object sender, EventArgs e)
        {

        }

        private void buttondapcheckups_Click(object sender, EventArgs e)
        {
            View.Formrcmndcheckups frm = new View.Formrcmndcheckups();
            frm.Show();
        }

        private void buttondapcheckups_Click_1(object sender, EventArgs e)
        {
            View.Formrcmndcheckups frm = new View.Formrcmndcheckups();
            frm.Show();

        }

        private void buttondanewp_Click(object sender, EventArgs e)
        {
            paneldapatient.Visible = false;
        }
    }
}
