using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InformixTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            IBM.Data.Informix.IfxConnection conn = new IBM.Data.Informix.IfxConnection();
            conn.ConnectionString = "Host=ifx11;Server=demo_on;Service=9088;;User ID=informix;Password=batman;database=gechague;";
            try
            {
                conn.Open();
                TextBox1.Text = "Made connection!";
            }
            catch (IBM.Data.Informix.IfxException ex)
            {
                TextBox1.Text = "Problem with connection attempt: " + ex.Message;
            }
        }
    }
}