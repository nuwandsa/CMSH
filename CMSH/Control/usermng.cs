using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;
using System.Windows.Forms;
using CMSH.Model;

namespace CMSH.Control
{
    class usermng
    {
        public void insert(User user)
        {

            try
            {
                string myconnection = "Server=localhost;Port=8050;Database=cmshdb;Uid=root;Pwd=";
                string query = "insert into users(fname,lname,contact,nic,username,password,acctype)values('"+user.Fname+"','"+user.Lname+"','"+user.Contact+"','"+user.Nic+"','"+user.Username+"','"+user.Password+"','"+user.Acctype+"');";
                MySqlConnection Mycon = new MySqlConnection(myconnection);
                
                MessageBox.Show("Im here");
                MySqlCommand mycommand = new MySqlCommand(query, Mycon);
                //mycommand.ExecuteNonQuery();
                MySqlDataReader myreader;
                Mycon.Open();
                //myreader = mycommand.ExecuteReader();
                MessageBox.Show("ham here");
                mycommand.ExecuteNonQuery();
                MessageBox.Show("Save data");
                /*while(myreader.Read())
                {

                }*/
                Mycon.Close();

            }

            catch ( Exception ex)
            {
                MessageBox.Show("Unable to save the data"+ex.Message);
            }


        }
       

        
    }
}
