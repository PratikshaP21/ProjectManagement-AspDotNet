using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectManagement_AspDotNet
{
    public partial class Team_Leader1 : System.Web.UI.Page
    {
        string Email;
        protected void Page_Load(object sender, EventArgs e)
        {
            Email = Session["Eemail"].ToString();
            if (!IsPostBack)
            {
                clsProject objt = new clsProject(Email);               //Project DataFetch
                DataTable dtT = new DataTable();
                dtT = objt.GetTeamLeaderProject();
                drpProject.DataSource = dtT;
                drpProject.DataValueField = "ProjectID";
                drpProject.DataTextField = "ProjectName";
                drpProject.DataBind();

            }
            clsProject obj = new clsProject();               //Team Leader DataFatch
            DataTable dt = new DataTable();
            dt = obj.GetTeamLeader();
            drpTeamLeader.DataSource = dt;
            drpTeamLeader.DataValueField = "EmployeeID";
            drpTeamLeader.DataTextField = "EName";
            drpTeamLeader.DataBind();


        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
        
        }

        protected void CalDate_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnAssign_Click(object sender, EventArgs e)
        {
            int ProjectID = Convert.ToInt32(drpProject.SelectedValue.ToString());
            int TLID = Convert.ToInt32(drpTeamLeader.SelectedValue.ToString());
            clsProject obj = new clsProject(ProjectID, TLID);
            obj.AssignTeamLeader();
            Response.Write("<script>alert('Assign Up Successe....!')</script>");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
           
        }
    }
}