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
using CMSH.View;

namespace CMSH.View
{
    public partial class Formrcmndcheckups : Form
        
    {
        List<string> checkups = new List<string>();

        public Formrcmndcheckups()
        {
            InitializeComponent();
        }

        private void textBoxrecmndcheckups_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoncheckupsaddlist_Click(object sender, EventArgs e)
        {
           
            checkups.Add(textBoxaddcheckup.Text);
            
            //senddata(checkups);

            if(this.textBoxaddcheckup.Text!=""||this.textBoxaddcheckup.Text!= "Type the checkup here...")
            {
                listBoxcheckups.Items.Add(this.textBoxaddcheckup.Text);
                this.textBoxaddcheckup.Focus();
                this.textBoxaddcheckup.Clear();
            }

            else
            {
                MessageBox.Show("Please enter a name of checkup");
                this.textBoxaddcheckup.Focus();
            }
        }

        private void buttonremovecheckup_Click(object sender, EventArgs e)
        {
            if(this.listBoxcheckups.SelectedIndex>=0)
            {
                this.listBoxcheckups.Items.RemoveAt(this.listBoxcheckups.SelectedIndex);
            }
        }

        public void senddata(Checkups chckup)
        {
            
           
            //
            

        }

        /* private void buttonRecommendcheckups_Click(object sender, EventArgs e)
         {

             //senddata();
         }*/

        private void buttonRecommendcheckups_Click(object sender, EventArgs e)
        {
            //Checkups[] chkps ;
            Checkups chkps=new Checkups();
            FormDoctoracc fda = new FormDoctoracc();
            chkps.Pid = int.Parse(fda.textBoxdapid.Text);
            usermng umng = new usermng();
            Console.Write("here1");
            umng.getdatafrmrecmndcheckups(chkps);
            MessageBox.Show(chkps.Checkupno+" test:");
           // MessageBox.Show("" + chkps[0].Pid);
            

        }
    }
}
