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
                Console.WriteLine("came here");
                String sqlStr = "Server=127.0.0.1;Uid=root;";
                MySqlConnection con = new MySqlConnection(sqlStr);
                string query = "insert into cmshdb.users(fname,lname,contact,nic,username,password,acctype)values('" + user.Fname + "','" + user.Lname + "','" + user.Contact + "','" + user.Nic + "','" + user.Username + "','" + user.Password + "','" + user.Acctype + "');";
                MySqlCommand mycommand = new MySqlCommand(query, con);
                con.Open();

                mycommand.ExecuteNonQuery();
                Console.WriteLine("Success");
                con.Close();

                /*String myConnectionString = "";
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "localhost";
                builder.UserID = "root";
                builder.Password = "";
                //builder.Port = 8050;
                //myConnectionString = builder.ConnectionString;

                string myconnection = "Server=localhost;Port=8050;Database=cmshdb;Uid=root";
                string query = "insert into users(fname,lname,contact,nic,username,password,acctype)values('"+user.Fname+"','"+user.Lname+"','"+user.Contact+"','"+user.Nic+"','"+user.Username+"','"+user.Password+"','"+user.Acctype+"');";
                MySqlConnection Mycon = new MySqlConnection();
                Mycon.ConnectionString = myConnectionString;
                MessageBox.Show("Im here");
                //MySqlCommand mycommand = new MySqlCommand(query, Mycon);
                ////mycommand.ExecuteNonQuery();
                MySqlDataReader myreader;
                //if(Mycon.State != ConnectionSate.Open)
                //Mycon.Close();
                Mycon.Open();
                //myreader = mycommand.ExecuteReader();
                MessageBox.Show("ham here");
                mycommand.ExecuteNonQuery();
                MessageBox.Show("Save data");
                /*while(myreader.Read())
                {

                }
                Mycon.Close();*/

            }

            catch ( Exception ex)
            {
                MessageBox.Show("Unable to save the data"+ex.Message);
            }


        }
       

        
    }
}
