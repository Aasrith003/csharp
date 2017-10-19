using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace SqlService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SqlSendService" in both code and config file together.
    public class SqlSendService : ISqlSendService
    {
        string error;
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Marks;Integrated Security=True");
        public void SendToSql(int student_roll, string student_name, int maths, int physics, int chemistry, int social, int english, int computers, string secondlang, int secondlang_marks, string if_passed)
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                if (error != null)
                {
                    error = error + ex.Message;
                }
                else
                {
                    error = ex.Message;
                }
                string send_cmd = "insert into Marks_Main values(" + student_roll + "," + "'" + student_name + "'" + "," + maths + "," + physics + "," + chemistry + "," + social + "," + english + "," + computers + "'" + secondlang + "'" + "," + secondlang_marks + ","+"'"  + if_passed + "'" + ")" +"go";
                SqlCommand cmd = new SqlCommand(send_cmd, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}

