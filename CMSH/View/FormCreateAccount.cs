using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void buttoncadrcreate_Click(object sender, EventArgs e)
        {
            sendcdata();
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
            MessageBox.Show("One");
            String pw = this.password.Text;
            String rpw = this.textBoxrepassword.Text;
            if (pw == rpw)
            {
                MessageBox.Show("two");
                User user = new User();

                user.Fname = textBoxfirstname.Text;
                user.Lname = textBoxlastname.Text;
                user.Contact = textBoxcontactno.Text;
                user.Nic = textBoxnicno.Text;
                user.Username = textBoxusername.Text;
                user.Password = password.Text;
                user.Acctype = comboBoxacctype.SelectedItem.ToString();

                usermng uMng = new usermng();
                uMng.insert(user);
            }
            else
            {

                MessageBox.Show("there is a error");
            }
        }

        
    }
}
