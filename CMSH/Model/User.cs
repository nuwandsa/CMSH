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
}
