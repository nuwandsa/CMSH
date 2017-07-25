using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMSH.Control;
using CMSH.Model;

namespace CMSH.View
{
    public partial class FormCreateAccount : Form
    {
        public FormCreateAccount()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void textBoxfirstname_load(object sender,EventArgs e)
        {
            this.ActiveControl = textBoxfirstname;
            textBoxfirstname.GotFocus += new EventHandler(this.TextBox_GotFocus);
            textBoxfirstname.LostFocus += new EventHandler(this.TextLostFocus);

        }

        public void textBoxlastname_load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxlastname;
            textBoxlastname.GotFocus += new EventHandler(this.TextBox_GotFocus);
            textBoxlastname.LostFocus += new EventHandler(this.TextLostFocus);

        }
        public void TextBox_GotFocus(object sender, EventArgs e)
        {
             //MessageBox.Show("ok");
            TextBox tb = (TextBox)sender;
            //if(tb.Text=="First Name")
            {
               
                tb.Clear();
                tb.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {

        }

        private void labelcabrowsimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFd = new OpenFileDialog();
            openFd.Filter = "Images Only.|*jpg;*jpeg";
            DialogResult dr = openFd.ShowDialog();
            pictureBoxca.Image = Image.FromFile(openFd.FileName);
        }

        private void buttoncanext_Click(object sender, EventArgs e)
        {
            buttoncanext.Visible= false;
            String acctype = "";
            try {
                acctype = comboBoxacctype.SelectedItem.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error passing");
            }
            switch (acctype)
            {
               case "Doctor":
                    this.panelcapatient.Visible = true;
                    this.panelcatherapist.Visible = true;
                    this.panelcadoctor.Visible = true;
                    //label36.Visible = true;
                    //pictureBoxCAimage.Visible = true;
                    //buttonloginbrows.Visible = true;
                    break;
                case "MLT":
                    this.panelcapatient.Visible = true;
                    this.panelcatherapist.Visible = true;
                   /* label36.Visible = true;
                    pictureBoxCAimage.Visible = true;
                    buttonloginbrows.Visible = true;*/

                    break;

                case "Radiologist":
                    this.panelcapatient.Visible = true;
                    this.panelcatherapist.Visible = true;
                    /*label36.Visible = true;
                    pictureBoxCAimage.Visible = true;
                    buttonloginbrows.Visible = true;*/
                    break;

                case "Nurse":
                    this.panelcapatient.Visible = true;
                    this.panelcatherapist.Visible = true;
                    /*label36.Visible = true;
                    pictureBoxCAimage.Visible = true;
                    buttonloginbrows.Visible = true;*/
                    break;

                case "Physiotherapist":
                    this.panelcapatient.Visible = true;
                    this.panelcatherapist.Visible = true;
                    /*label36.Visible = true;
                    pictureBoxCAimage.Visible = true;
                    buttonloginbrows.Visible = true;*/
                    break;

                case "Patient":
                    //this.panelloginDoctor.Visible = true;
                    //this.panelTechtheraphistCa.Visible = true;
                    this.panelcapatient.Visible = true;
                    //label36.Visible = true;
                    //pictureBoxCAimage.Visible = true;
                    //buttonloginbrows.Visible = true;
                    break;

                case "Pharmacist":
                    this.panelcapatient.Visible = true;
                    this.panelcatherapist.Visible = true;
                    this.panelcapharmacist.Visible = true;
                    break;
            }
            }

        private void buttoncapatientback_Click(object sender, EventArgs e)
        {
            panelcapatient.Visible = false;
            buttoncanext.Visible = true;

        }

        private void buttoncapatientcreate_Click(object sender, EventArgs e)
        {
            sendcdata();
            User user = new User();
            usermng umng = new usermng();
            umng.getdata(user, textBoxusername.Text);

            sendpatdata(user.Userid);


        }

        private void buttontherapistback_Click(object sender, EventArgs e)
        {
            panelcapatient.Visible = false;
            this.panelcatherapist.Visible = false;
            buttoncanext.Visible = true;
        }

        private void buttontherapistcreate_Click(object sender, EventArgs e)
        {
            sendcdata();
            User user = new User();
            usermng umng = new usermng();
            umng.getdata(user, textBoxusername.Text);

            sendtherapstdata(user.Userid);
        }

        private void buttoncadrcreate_Click(object sender, EventArgs e)
        {
            sendcdata();
            User user = new User();
            usermng umng = new usermng();
            umng.getdata(user, textBoxusername.Text);
            
            senddrdata(user.Userid);
        }

        private void buttoncaphrback_Click(object sender, EventArgs e)
        {
            panelcapatient.Visible = false;
            this.panelcatherapist.Visible = false;
            this.panelcapharmacist.Visible = false;
            buttoncanext.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttoncaphrcreate_Click(object sender, EventArgs e)
        {
            sendcdata();
            
            
        }

        private void textBoxfirstname_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void sendcdata()
        {
            //MessageBox.Show("One");
            String pw = this.password.Text;
            String rpw = this.textBoxrepassword.Text;
            if (pw == rpw)
            {
                //MessageBox.Show("two");
                User user = new User();

                user.Fname = textBoxfirstname.Text;
                user.Lname = textBoxlastname.Text;
                user.Contact = textBoxcontactno.Text;
                user.Nic = textBoxnicno.Text;
                user.Username = textBoxusername.Text;
                user.Password = password.Text;
                user.Acctype = comboBoxacctype.SelectedItem.ToString();

                ImageConverter cnvrtr = new ImageConverter();
                byte[] img = (byte[])cnvrtr.ConvertTo(pictureBoxca.Image, typeof(byte[]));
                user.Pic = img;
                user.Imgsize = img.Length;
               

                usermng uMng = new usermng();
                string qry= "insert into cmshdb.users(fname,lname,contact,nic,username,password,acctype,img,imgsize)values('" + user.Fname + "','" + user.Lname + "','" + user.Contact + "','" + user.Nic + "','" + user.Username + "','" + user.Password + "','" + user.Acctype + "','" + user.Pic + "','" + user.Imgsize + "');";
                uMng.insert(/*user*/qry);
                            }
            else
            {

                MessageBox.Show("there is a error");
            }
        }

        private void senddrdata(int uid)
        {
            String pw = this.password.Text;
            String rpw = this.textBoxrepassword.Text;
            if (pw == rpw)
            {
                //MessageBox.Show("two");
                Doctors doctors = new Doctors();

                doctors.Regno = textBoxcadrgrn.Text;
                doctors.Qualification = textBoxcadrpq.Text;
                doctors.Designation = textBoxcadrdesignation.Text;
                doctors.Hospital = textBoxcadrcurrenthospital.Text;




                usermng uMng = new usermng();
                string qry = "insert into cmshdb.doctors(userid,regno,qualifications,designation,hospital)values('"+uid+"','"+ doctors.Regno + "','" + doctors.Qualification + "','" + doctors.Designation + "','" + doctors.Hospital + "')";
                uMng.insert(qry);
            }
            else
            {

                MessageBox.Show("there is a error");
            }

        }

        private void sendpatdata(int uid)
        {
            String pw = this.password.Text;
            String rpw = this.textBoxrepassword.Text;
            if (pw == rpw)
            {
                //MessageBox.Show("two");
                Patients patient  = new Patients();

                // patient.Bgroup = comboBoxbloodgroup.SelectedItem.ToString();
                patient.Bgroup = comboBoxbloodgroup.SelectedItem.ToString();

                //patient.BDay = dateTimePickerbday.Value;
                

                var bday = dateTimePickerbday.Value.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture);
                patient.BDay = bday;

                string gender;
                bool ischecked = radioButtonmale.Checked;
                if (ischecked)
                    gender = radioButtonmale.Text;
                else
                    gender = radioButtonfemale.Text;

                patient.Gender = gender;
                patient.Address = textBoxcaaddress.Text;





                usermng uMng = new usermng();
                string qry = "insert into cmshdb.patients(userid,bldgrp,bday,gender,address)values('" + uid + "','" + patient.Bgroup+ "','" +patient.BDay + "','" + patient.Gender + "','" + patient.Address + "')";
                uMng.insert(qry);
            }
            else
            {

                MessageBox.Show("there is a error");
            }

        }

        private void sendtherapstdata(int uid)
        {
            String pw = this.password.Text;
            String rpw = this.textBoxrepassword.Text;
            if (pw == rpw)
            {
                //MessageBox.Show("two");
                Tech te = new Tech();

                te.Regno = textBoxtherapistgrn.Text;
                te.Qualification = textBoxtherapistpq.Text;
                te.Designation = textBoxtherapistdesignation.Text;
                te.Workingplce = textBoxtherapistwp.Text;




                usermng uMng = new usermng();
                string qry = "insert into cmshdb.technecian(userid,regno,qualifications,designation,workingplace)values('" + uid + "','" + te.Regno + "','" + te.Qualification + "','" + te.Designation + "','" + te.Workingplce + "')";
                uMng.insert(qry);
            }
            else
            {

                MessageBox.Show("there is a error");
            }

        }

        private void buttoncaback_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHomePage hp = new FormHomePage();
            hp.Show();

        }

        private void textBoxfirstname_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxlastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
