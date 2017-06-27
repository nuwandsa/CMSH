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
        public void insert(/*User user*/string qry)
        {

            try
            {
                //Console.WriteLine("came here");
                String sqlStr = "Server=127.0.0.1;Uid=root;";
                MySqlConnection con = new MySqlConnection(sqlStr);
                //string query = "insert into cmshdb.users(fname,lname,contact,nic,username,password,acctype)values('" + user.Fname + "','" + user.Lname + "','" + user.Contact + "','" + user.Nic + "','" + user.Username + "','" + user.Password + "','" + user.Acctype + "');";
                string query = qry;
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

        public void getdata(User user,string unm)
        
        {

            String sqlStr = "Server=127.0.0.1;Uid=root;";
            MySqlConnection con = new MySqlConnection(sqlStr);
            String query = "select * from cmshdb.users WHERE username= '"+unm+"'";
            
            MySqlConnection MyConn2 = new MySqlConnection(sqlStr);
            MyConn2.Open();
            MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);
            //  MyConn2.Open();  
            //For offline connection we weill use  MySqlDataAdapter class. 
            try
            {
                var reader = MyCommand2.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0));
                    Console.WriteLine(reader.GetString(1));
                    Console.WriteLine(reader.GetString(2));
                    Console.WriteLine(reader.GetString(6));

                    //User user = new User();
                    user.Userid = reader.GetInt32(0);
                    user.Fname = reader.GetString(1);
                    user.Lname = reader.GetString(2);
                    user.Contact = reader.GetString(3);
                    user.Nic = reader.GetString(4);
                    user.Username = reader.GetString(5);
                    user.Password = reader.GetString(6);
                    user.Acctype = reader.GetString(7);

                    

                    
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            /*MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            Me1ageBox.Show("");*/




        }

        public void getdatafrmdctrs(Doctors doctors,string uid)
        {
            String sqlStr = "Server=127.0.0.1;Uid=root;";
            MySqlConnection con = new MySqlConnection(sqlStr);
            String query = "select * from cmshdb.doctors WHERE userid= '" + uid + "'";
            MySqlConnection MyConn2 = new MySqlConnection(sqlStr);
            MyConn2.Open();
            MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);
            //  MyConn2.Open();  
            //For offline connection we weill use  MySqlDataAdapter class. 
            try
            {
                var reader = MyCommand2.ExecuteReader();
                while (reader.Read())
                {
                    
                    Console.WriteLine(reader.GetString(0));
                    Console.WriteLine(reader.GetString(1));
                    Console.WriteLine(reader.GetString(2));
                    Console.WriteLine(reader.GetString(6));

                    //User user = new User();
                    doctors.Userid = reader.GetInt32(0);
                    doctors.Regno = reader.GetString(1);
                    doctors.Qualification = reader.GetString(2);
                    doctors.Designation= reader.GetString(3);
                    doctors.Hospital = reader.GetString(4);




                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
       
        public void login(User user,string pwd)
        {
            MessageBox.Show("1");
            //User user = new User();
            if(pwd==user.Password)
            {
                switch(user.Acctype)
                {
                    case "Doctor":
                        FormHomePage hpg = new FormHomePage();
                        hpg.Hide();  

                        View.FormDoctoracc FDA = new View.FormDoctoracc();
                        FDA.set_values(user.Fname,user.Lname);


                        FDA.Show();
                        break;
                    case "MLT":
                        FormHomePage hpg2 = new FormHomePage();
                        hpg2.Hide();

                        View.Formtechacc FTA = new View.Formtechacc();
                        FTA.Show();


                        break;

                    case "Radiologist":
                        FormHomePage hpg3 = new FormHomePage();
                        hpg3.Hide();

                        View.Formtechacc FTAr = new View.Formtechacc();
                        FTAr.Show();

                        break;

                    case "Nurse":
                        FormHomePage hpg4 = new FormHomePage();
                        hpg4.Hide();

                        View.Formtechacc FTAn = new View.Formtechacc();
                        FTAn.Show();

                        break;

                    case "Physiotherapist":
                        FormHomePage hpg5 = new FormHomePage();
                        hpg5.Hide();

                        View.Formtechacc FTAp = new View.Formtechacc();
                        FTAp.Show();

                        break;

                    case "Patient":
                        
                        break;

                    case "Pharmacist":
                        
                        break;
                }
            }
            else
            {
                MessageBox.Show("wrong password");
                MessageBox.Show(user.Password);
            }
            
        }

        public void insertquery()
        {

        }
        
    }
}
