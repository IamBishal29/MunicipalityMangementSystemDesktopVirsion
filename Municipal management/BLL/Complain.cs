using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Municipal_management.DAL;
using System.Data;

namespace Municipal_management.BLL
{
    public class Complain
    {
        Connection cn = new Connection();
        public string complain { get; set; }
        public string id { get; set; }
        public string other { get; set; }

        public int getCmpln(Complain cm)
        {
            return cn.insertCmpln(cm);
        }

        public DataTable getCmplnGrid()
        {
            return cn.datagridcmp();
        }
    }
}
