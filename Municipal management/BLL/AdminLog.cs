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
   public class AdminLog
    {
       public string UserName { get; set; }
       public string Password{get;set;}

       public DataTable getAdminData(AdminLog a)
       {
           Connection cn = new Connection();
           return cn.SelectAd(a);
       }
    }
}
