using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectManagement_AspDotNet
{
    public partial class All_Project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clsProject obj = new clsProject();
                DataTable dt = new DataTable();
                dt = obj.AllProject();
                grdAllProject.DataSource = dt;
                grdAllProject.DataBind();
            }
           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}