using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSH.Model
{

    public class User
    {
        
        int userid;
        string fname;
        string lname;
        string contact;
        string nic;
        string username;
        string password;
        string acctype;
        byte[] pic;
        int imgsize;

        public int Userid { get => userid; set => userid = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Nic { get => nic; set => nic = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Acctype { get => acctype; set => acctype = value; }
        public byte[] Pic { get => pic; set => pic = value; }
        public int Imgsize { get => imgsize; set => imgsize = value; }
    }

    public class Doctors:User
    {
        int userid;
        string regno;
        string qualification;
        string designation;
        string hospital;

        public int Userid { get => userid; set => userid = value; }
        public string Regno { get => regno; set => regno = value; }
        public string Qualification { get => qualification; set => qualification = value; }
        public string Designation { get => designation; set => designation = value; }
        public string Hospital { get => hospital; set => hospital = value; }
    }

    public class Patients
    {
        int userid;
        string bgroup;
        string gender;
        string bDay;
        string address;

        public int Userid { get => userid;
            set => userid = value; }
        public string Bgroup { get => bgroup; set => bgroup = value; }
        public string Gender { get => gender; set => gender = value; }
        public string BDay { get => bDay; set => bDay = value; }
        public string Address { get => address; set => address = value; }
    }

    public class Tech
    {
        int userid;
        string regno;
        string qualification;
        string designation;
        string workingplce;

        public int Userid { get => userid; set => userid = value; }
        public string Regno { get => regno; set => regno = value; }
        public string Qualification { get => qualification; set => qualification = value; }
        public string Designation { get => designation; set => designation = value; }
        public string Workingplce { get => workingplce; set => workingplce = value; }
    }

    public class chngingvriables
    {
        int userid;
        string smoke;
        int height;
        float weight;

        public int Userid { get => userid; set => userid = value; }
        public string Smoke { get => smoke; set => smoke = value; }
        public int Height { get => height; set => height = value; }
        public float Weight { get => weight; set => weight = value; }
    }

    public class Checkups
    {
        int pid;
        int receiptid;
        int checkupno;
        string date;
       string checkup;
       // List<string> checkupsl;
        string complete_status;

        public int Pid { get => pid; set => pid = value; }
        public int Receiptid { get => receiptid; set => receiptid = value; }
        public int Checkupno { get => checkupno; set => checkupno = value; }
        public string Date { get => date; set => date = value; }
        public string Checkup { get => checkup; set => checkup = value; }
        public string Complete_status { get => complete_status; set => complete_status = value; }
    }
}
