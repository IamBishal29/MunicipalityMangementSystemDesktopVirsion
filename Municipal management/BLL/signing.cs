using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Municipal_management.DAL;

namespace Municipal_management.BLL
{
    public class signing
    {
        //Connection cn = new Connection();

        public string firstName { get; set;}
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string mobileNo { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }

        /*public void M(signing s)
        {
            cn.insert(s);
        }*/
    }
}
