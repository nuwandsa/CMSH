using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSH.Model
{
    class User
    {
        
        int userid;
        string fname;
        string lname;
        string contact;
        string nic;
        string username;
        string password;
        string acctype;

        public int Userid { get => userid; set => userid = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Nic { get => nic; set => nic = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Acctype { get => acctype; set => acctype = value; }
    }

    class Doctors
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
}
