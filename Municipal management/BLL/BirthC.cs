using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Municipal_management.DAL;

namespace Municipal_management.BLL
{
    public class BirthC
    {
        Connection cn = new Connection();

        public string dateofIssue { get; set; }
        public string Name { get; set; }
        public string fathersName { get; set; }
        public string mothersName { get; set; }
        public string dob { get; set; }
        public string permanentAddress { get; set; }
        public string presentAddress { get; set; }
        public string nationality { get; set; }
        public string gender { get; set; }

        

        public int getBs(BirthC bs)
        {
            return cn.insertBS(bs);
        }
        public DataTable getsrchBs()
        {
            return cn.searchBS();
            
        }
        public DataTable getdata()
        {
            return cn.datagridBs();
        }

    }
}
