using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Municipal_management.DAL;

namespace Municipal_management.BLL
{
    public class Admin
    {
        Connection cn = new Connection();
        
        public DataTable  getdata()
        {
           return cn.datagrid();
        }
        /*public string serialNo { get; set; }*/
    }
}
