using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace client_weBsite
{
    public partial class main_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                SqlService.SqlServiceClient client = new SqlService.SqlServiceClient();
                GridView1.DataSource = client.Get_Data("Marks_Table", int.Parse(TextBox1.Text));
                GridView1.DataMember = "Marks_Table";
                GridView1.DataBind();
            }
            catch(Exception ex)
            {
                if(ex.Message == null)
                {
                    Label3.Text = "no error";

                }
                Label3.Text = ex.Message;
            }
        }
    }
}