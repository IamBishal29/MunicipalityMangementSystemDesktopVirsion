using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Municipal_management.BLL;
using Municipal_management.DAL;
using System.Data;

namespace Municipal_management.BLL
{
    public class VoterId
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
        public string VotingArea { get; set; }
        public string IdNo { get; set; }
        public string gender { get; set; }



        public int getVi(VoterId vi)
        {
            return cn.insertVI(vi);
        }
        public DataTable getsrchVi()
        {
            return cn.searchVI();

        }
        public DataTable getdata1()
        {
            return cn.datagridvi();
        }
        

    }
}
