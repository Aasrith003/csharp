using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace client_weBsite
{
    public partial class Send_Data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {


                SqlSendData.SqlSendServiceClient client = new SqlSendData.SqlSendServiceClient();
                client.SendToSql(int.Parse(TextBox1.Text), TextBox2.Text, int.Parse(TextBox3.Text), int.Parse(TextBox4.Text), int.Parse(TextBox5.Text), int.Parse(TextBox6.Text), int.Parse(TextBox7.Text), int.Parse(TextBox8.Text), TextBox9.Text, int.Parse(TextBox10.Text), TextBox11.Text);
                Label13.Text = "succesful";

            }
            catch(Exception ex)
            {
                Label13.Text = ex.Message;
            }
        }
    }
}