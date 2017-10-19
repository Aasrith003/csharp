using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace SqlService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SqlService" in both code and config file together.
    public class SqlService : ISqlService
    {
        public string error; 
        public DataSet marks = new DataSet();
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Marks;Integrated Security=True");
       
        
        public DataSet Get_Data(string dbname,int rollno)
        {
            string Cmd = "select * from Marks_Main where student_roll = " + rollno;
                
                SqlCommand cmd = new SqlCommand(Cmd, con);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                  
                    error = ex.Message;
                }

                SqlDataAdapter adap = new SqlDataAdapter(Cmd, con);

                adap.Fill(marks, dbname);
                con.Close();
                return marks;        
            
        }

        }
    }

