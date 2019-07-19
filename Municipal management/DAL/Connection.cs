using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Municipal_management.BLL;

namespace Municipal_management.DAL
{
    public class Connection 
    {
        signing s = new signing();
        //Admin a = new Admin();
        //reg
        public int insert(signing s)
        {
           
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Municipal management\Registration.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Reg (FirstName,LastName,UserName,Password,ConfirmPassword,MobileNo,DateofBirth,Gender)values('"+s.firstName+"','"+s.lastName+"','"+s.userName+"','"+s.password+"','"+s.confirmPassword+"','"+s.mobileNo+"','"+s.dob+"','"+s.gender+"')",con);
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                con.Close();
                throw;
            }
        }
        //login
         public DataTable Select(signing s)
          {
                DataTable dt = new DataTable("Reg");
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Municipal management\Registration.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Reg where UserName ='"+s.userName+"' and Password ='"+s.password+"'",con );
                try
                {
                    SqlDataReader rd =  cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    dt.Load(rd);
                    return dt;
                }
                catch
                {
                    con.Close();
                    throw;
                }
                
             }
        //appointment
        public int insertAppointment(appointment_administrator aa)
         {
             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Appointment.mdf;Integrated Security=True;Connect Timeout=30");
             con.Open();
             SqlCommand cmd = new SqlCommand("insert into Appointment (IdNo,AppointmentDate)values('" + aa.IdNo + "','" + aa.AppointmentDate + "')", con);
             try
             {
                 return cmd.ExecuteNonQuery();
             }
             catch
             {
                 con.Close();
                 throw;
             }
         }
         public DataTable searchAppointment(appointment_administrator a)
         {
             DataSet ds = new DataSet();
             DataTable dt = new DataTable();
             appointment_administrator aa = new appointment_administrator();
             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Appointment.mdf;Integrated Security=True;Connect Timeout=30");
             con.Open();

             try
             {
                 SqlCommand cmd = new SqlCommand("select * from Appointment where IdNo ='" + aa.IdNo + "'", con);
                 SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                 //SqlDataReader reader = cmd.ExecuteReader();
                 adapter.Fill(ds);
                 dt = ds.Tables[0];
                 //dt = reader;
                 return dt;
                 // return reader;
             }
             catch
             {
                 con.Close();
                 throw;
             }

         }

         public DataTable datagrid()
         {
             DataSet ds = new DataSet();
             DataTable dt =new DataTable();
             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Appointment.mdf;Integrated Security=True;Connect Timeout=30");
             con.Open();

             SqlCommand cmd = new SqlCommand("select * from Appointment", con);
             try
             {
                 SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                 adapter.Fill(ds);
                 dt = ds.Tables[0];
                 return dt;
                 
             }
             catch
             {
                 con.Close();
                 throw;
             }
         }
         public DataTable datagridBs()
         {
             DataSet ds = new DataSet();
             DataTable dt = new DataTable();
             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Birth_Certificate.mdf;Integrated Security=True;Connect Timeout=30");
             con.Open();

             SqlCommand cmd = new SqlCommand("select * from BS", con);
             try
             {
                 SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                 adapter.Fill(ds);
                 dt = ds.Tables[0];
                 return dt;

             }
             catch
             {
                 con.Close();
                 throw;
             }

         }
        //insert into birth certificate
         public int insertBS(BirthC b)
         {
             
             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Birth_Certificate.mdf;Integrated Security=True;Connect Timeout=30");
             con.Open();
             SqlCommand cmd = new SqlCommand("insert into BS(DateofIssue,Name,FathersName,MothersName,DateofBirth,PermanentAddress,PresentAddress,Nationality,Gender)values('"+b.dateofIssue+"','"+b.Name+"','"+b.fathersName+"','"+b.mothersName+"','"+b.dob+"','"+b.permanentAddress+"','"+b.presentAddress+"','"+b.nationality+"','"+b.gender+"')",con);
             try
             {
                 return cmd.ExecuteNonQuery();
             }
             catch
             {
                 con.Close();
                 throw;
             }
 
         }
        
         public DataTable searchBS()
         {
             BirthC c = new BirthC(); ;
             //DataSet ds = new DataSet();
             DataTable dt2 = new DataTable();

             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Birth_Certificate.mdf;Integrated Security=True;Connect Timeout=30");
             con.Open();
             SqlCommand cmd = new SqlCommand("select * from BS", con);
             try
             {
                 SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                 adapter.Fill(dt2);
                 //dt2 = ds.Tables[0];
                 return dt2;

             
             }
             
             catch
             {
                 con.Close();
                 throw;
             }
         }
         
        //voterid 
         public int insertVI(VoterId b)
         {

             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Voter_Id.mdf;Integrated Security=True;Connect Timeout=30");
             con.Open();
             SqlCommand cmd = new SqlCommand("insert into VI(Dateofissue,Name,FathersName,MothersName,DOB,Permanentaddress,Nationality,votingarea,Gender)values('" + b.dateofIssue + "','" + b.Name + "','" + b.fathersName + "','" + b.mothersName + "','" + b.dob + "','" + b.permanentAddress + "','"+b.VotingArea+"','" + b.nationality + "','" + b.gender + "')", con);
             try
             {
                 return cmd.ExecuteNonQuery();
             }
             catch
             {
                 con.Close();
                 throw;
             }

         }
         
         public DataTable searchVI()
         {
             VoterId c = new VoterId(); ;
             //DataSet ds = new DataSet();
             DataTable dt2 = new DataTable();

             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Voter_Id.mdf;Integrated Security=True;Connect Timeout=30");
             con.Open();
             SqlCommand cmd = new SqlCommand("select * from VI", con);
             try
             {
                 SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                 adapter.Fill(dt2);
                 //dt2 = ds.Tables[0];
                 return dt2;


             }

             catch
             {
                 con.Close();
                 throw;
             }
         }
         public DataTable datagridvi()
         {
             DataSet ds = new DataSet();
             DataTable dt = new DataTable();
             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Voter_Id.mdf;Integrated Security=True;Connect Timeout=30");
             con.Open();

             SqlCommand cmd = new SqlCommand("select * from VI", con);
             try
             {
                 SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                 adapter.Fill(ds);
                 dt = ds.Tables[0];
                 return dt;

             }
             catch
             {
                 con.Close();
                 throw;
             }

         }












        //cmpln
         public int insertCmpln(Complain c)
         {
             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Documents\Complain_table.mdf;Integrated Security=True;Connect Timeout=30");
             con.Open();
             SqlCommand cmd = new SqlCommand("insert into cmpln(Id,Complain,Others)values('" + c.id + "','" + c.complain+ "','" +c.other + "')", con);
             try
             {
                 return cmd.ExecuteNonQuery();
             }
             catch
             {
                 con.Close();
                 throw;
             }
 
         }
         public DataTable datagridcmp()
         {
             DataSet ds = new DataSet();
             DataTable dt = new DataTable();
             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Documents\Complain_table.mdf;Integrated Security=True;Connect Timeout=30");
             con.Open();

             SqlCommand cmd = new SqlCommand("select * from cmpln ", con);
             try
             {
                 SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                 adapter.Fill(ds);
                 dt = ds.Tables[0];
                 return dt;

             }
             catch
             {
                 con.Close();
                 throw;
             }
         }
         public DataTable SelectAd(AdminLog al)
         {
             DataTable dt = new DataTable("AdminLog");
             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Documents\Admin_Login.mdf;Integrated Security=True;Connect Timeout=30");
             con.Open();
             SqlCommand cmd = new SqlCommand("select * from AdminLog where User_Name ='" + al.UserName + "' and Password ='" + al.Password + "'", con);
             try
             {
                 SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                 dt.Load(rd);
                 return dt;
             }
             catch
             {
                 con.Close();
                 throw;
             }

         }

        }
    }

