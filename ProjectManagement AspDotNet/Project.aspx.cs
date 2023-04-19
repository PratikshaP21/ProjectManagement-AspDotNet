using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectManagement_AspDotNet
{
    public partial class Project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CalStartDate.Visible= false;
            }
            if (!IsPostBack)
            {
                CalEndDate.Visible = false;
            }
        }

        protected void btnCalStartDate_Click(object sender, ImageClickEventArgs e)
        {
            if (CalStartDate.Visible)
            {
                CalStartDate.Visible = false;
            }
            else
            {
                CalStartDate.Visible = true;
            }
            CalStartDate.Attributes.Add("style", "position:absolute");
        }

        protected void btnEndDate_Click(object sender, ImageClickEventArgs e)
        {
            if (CalEndDate.Visible)
            {
                CalEndDate.Visible = false;
            }
            else
            {
                CalEndDate.Visible = true;
            }
            CalEndDate.Attributes.Add("style", "position:absolute");

        }

        protected void CalStartDate_SelectionChanged(object sender, EventArgs e)
        {
            txtCalStartDate.Text = CalStartDate.SelectedDate.ToString("dd/MM/yyyy");
            CalStartDate.Visible= false;
        }

        protected void CalEndDate_SelectionChanged(object sender, EventArgs e)
        {

            txtCalEndDate.Text = CalEndDate.SelectedDate.ToString("dd/MM/yyyy");
           CalEndDate.Visible = false;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string type = drpType.Text;
            string projectname = txtProjectName.Text;
            DateTime startDate = Convert .ToDateTime(txtCalStartDate.Text);
            DateTime EndDate = Convert .ToDateTime(txtCalEndDate.Text);
            clsProject obj = new clsProject(type, projectname, startDate, EndDate);
            obj.SaveProjectData();
            Response.Write("<script>alert('Project Save....!')</script>");
        }

        protected void txtCalStartDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}