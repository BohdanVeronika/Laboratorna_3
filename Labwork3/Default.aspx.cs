using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Labwork3.DataProvide;

namespace Labwork3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReadData();
                FactoryGridView.DataSource = Workers;
                PremiumsGridView.DataSource = Premiums;
                FactoryGridView.DataBind();
                PremiumsGridView.DataBind();
            }
        }

        protected void Task1Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Task1Page.aspx");
        }

        protected void Task2Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Task2Page.aspx");
        }
    }
}