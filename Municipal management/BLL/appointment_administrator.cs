using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Municipal_management.DAL;
using Municipal_management.BLL;
using System.Data;

namespace Municipal_management.BLL
{
    public class appointment_administrator
    {
       Connection cn = new Connection();

        public string IdNo { get; set; }
        public string AppointmentDate { get; set; }

        public int getA(appointment_administrator a)
        {
            return cn.insertAppointment(a);
        }
        public DataTable getApppointment(appointment_administrator b)
        {
            return cn.searchAppointment(b);
        }
    }
}
