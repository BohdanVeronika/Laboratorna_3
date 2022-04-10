using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Labwork3
{
    public partial class LoginPage : System.Web.UI.Page
    {
        Dictionary<string, string> users = new Dictionary<string, string>
        {
            {"user", "password" },
            {"admin", "admin" }
        };

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            foreach (var user in users)
            {
                if (user.Key == UserTextBox.Text && user.Value == PasswordTextBox.Text)
                    Response.Redirect("Default.aspx");
                Response.Write(@"<script>alert('Invalid username or password! Try again.')</script>");
            }
        }
    }
}