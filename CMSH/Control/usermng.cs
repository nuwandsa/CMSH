using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;
using System.Windows.Forms;
using CMSH.Model;
using System.IO;
using System.Drawing;

namespace CMSH.Control
{
    class usermng
    {
        public void insert(string qry)
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

        public void getdata(User user,string unm )
        
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

                    UInt32 FileSize;
                    byte[] rawData;
                    FileStream fs;

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

                    FileSize = reader.GetUInt32(reader.GetOrdinal("imgsize"));
                    rawData = new byte[FileSize];
                   // reader.GetBytes(reader.);
                    reader.GetBytes(reader.GetOrdinal("img"), 0, rawData, 0, (int)FileSize);

                    //fs = new FileStream(@"E:\studies\year 3\project\images\load images.jpg", FileMode.OpenOrCreate, FileAccess.Write);
                    //fs.Write(rawData, 0, (int)FileSize);
                    //fs.Flush();
                    user.Pic = rawData;
                    //fs.Close();
                    //Image X = (Bitmap)((new ImageConverter()).ConvertFrom(rawData));

                    Console.Write(rawData.Length+"");

                    

                    

                    
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            /*MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            Me1ageBox.Show("");*/

            MyConn2.Close();


        }
        public void getdatafrmpatnt(User user,Patients patnt,int uid)
        {
            String sqlStr = "Server=127.0.0.1;Uid=root;";
            MySqlConnection con = new MySqlConnection(sqlStr);
            
            String query1="select*from cmshdb.users Where userid='"+uid+"' ";
            String query = "select * from cmshdb.patients WHERE userid= '" + uid + "'";
            MySqlConnection MyConn2 = new MySqlConnection(sqlStr);
            MyConn2.Open();
            
            MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);
            MySqlCommand MyCommand3 = new MySqlCommand(query1, MyConn2);

           
            //For offline connection we weill use  MySqlDataAdapter class. 
            try
            {
                var reader = MyCommand2.ExecuteReader();
                while (reader.Read())
                {

                    Console.WriteLine(reader.GetString(0));
                    Console.WriteLine(reader.GetString(1));
                    Console.WriteLine(reader.GetString(2));
                    Console.WriteLine(reader.GetString(3));
                    MessageBox.Show(reader.GetString(2));

                    //User user = new User();
                    patnt.Userid = reader.GetInt32(0);
                    patnt.Bgroup = reader.GetString(1);
                    patnt.BDay = reader.GetString(2);
                    patnt.Gender = reader.GetString(3);
                    patnt.Address = reader.GetString(4);
                 
                
                }
                reader.Close();
                var reader1 = MyCommand3.ExecuteReader();
                while(reader1.Read())
                {
                    
                    Console.WriteLine(reader1.GetString(0));
                    Console.WriteLine(reader1.GetString(1));
                    Console.WriteLine(reader1.GetString(2));
                    Console.WriteLine(reader1.GetString(6));

                    //User user = new User();
                    user.Userid = reader1.GetInt32(0);
                    user.Fname = reader1.GetString(1);
                    user.Lname = reader1.GetString(2);
                    user.Contact = reader1.GetString(3);
                    user.Nic = reader1.GetString(4);
                    user.Username = reader1.GetString(5);
                    user.Password = reader1.GetString(6);
                    user.Acctype = reader1.GetString(7);
                    //user.Pic = reader1.(8);
                }
                reader1.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            MyConn2.Close();
           
        }
        public void getdatafrmdctrs(Doctors doctors,int uid)
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
                    Console.WriteLine(reader.GetString(3));

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
            MyConn2.Close();
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
                        Doctors dctr = new Doctors();
                        getdatafrmdctrs(dctr,user.Userid);
                        View.FormDoctoracc FDA = new View.FormDoctoracc();
                        FDA.set_values(user,dctr);
                        


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
                        FormHomePage hpg6 = new FormHomePage();
                        hpg6.Hide();

                        View.FormPatient FPA = new View.FormPatient();
                        FPA.Show();
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
        public void getdatafrmrecmndcheckups(Checkups chkps)
        {

            String sqlStr = "Server=127.0.0.1;Uid=root;";
            MySqlConnection con = new MySqlConnection(sqlStr);
            String query = "select MAX(checkupno) from cmshdb.recmndcheckups WHERE patientid= '" + chkps.Pid+ "' AND receiptid=SELECT MAX(receiptid)from cmshdb.recmndcheckups";
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

                    //Console.WriteLine(reader.GetString(0));
                    //Console.WriteLine(reader.GetString(1));
                    //Console.WriteLine(reader.GetString(2));
                    //Console.WriteLine(reader.GetString(3));

                    //User user = new User();
                   // chkps.Receiptid = reader.GetInt32(1);
                    chkps.Checkupno = reader.GetInt32(0);

                   
                   



                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /*public Checkups[] getdatafrmrecmndcheckupsTEST()
        {

            String sqlStr = "Server=127.0.0.1;Uid=root;";
            //MySqlConnection con = new MySqlConnection(sqlStr);
            String query = "select * from cmshdb.recmndcheckups ";
            MySqlConnection MyConn2 = new MySqlConnection(sqlStr);
            
            MyConn2.Open();
            MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);
             
            //For offline connection we weill use  MySqlDataAdapter class. 
            try
            {
                
                var reader = MyCommand2.ExecuteReader();
                
                //Checkups[] newCheck = new Checkups[reader.FieldCount];
                
                int i = 0;
                
                
                
                //
                while (reader.Read())
                {   i++;

                    
                }
                reader.Close();
                Checkups[] newCheck = new Checkups[i];
                i = 0;
                reader = MyCommand2.ExecuteReader();
                while (reader.Read())
                {
                    newCheck[i].Pid = int.Parse(reader["patientid"].ToString());
                    newCheck[i].Receiptid = int.Parse(reader["receiptid"].ToString());
                    newCheck[i].Checkupno = int.Parse(reader["checkupno"].ToString());
                    newCheck[i].Date = reader["dte"].ToString();
                    newCheck[i].Checkup = reader["checkup"].ToString();
                    newCheck[i].Complete_status = reader["complete_status"].ToString();

                }

                MyConn2.Close();
                return newCheck;
            }
            catch (Exception e)
            {
                Checkups[] newCheck = new Checkups[0];
                Console.WriteLine(e.Message);
                MyConn2.Close();
                return newCheck;
            }
            
        }*/

    }
}
