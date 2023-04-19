using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectManagement_AspDotNet
{
    public partial class Assign_Project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                clsProject objt = new clsProject();               //Project DataFatch
                DataTable dtT = new DataTable();
                dtT = objt.drpProject();
                drpProject.DataSource = dtT;
                drpProject.DataValueField = "ProjectID";
                drpProject.DataTextField = "ProjectName";
                drpProject.DataBind();

            }
            if(!IsPostBack)
            {
                clsProject obj = new clsProject();               //ProjectManager DataFatch
                DataTable dt = new DataTable();
                dt = obj.GetProjectManager();
                drpProjectManager.DataSource = dt;
                drpProjectManager.DataValueField = "EmployeeID";
                drpProjectManager.DataTextField = "EName";
                drpProjectManager.DataBind();
            }
           
                

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
            int PMID = Convert.ToInt32(drpProjectManager.SelectedValue.ToString());
            // DateTime AssignDate = Convert.ToDateTime(txtCalDate.Text);
            //string AssignDate = null;
            //String Status = null;

            clsProject obj = new clsProject(ProjectID,PMID);
            obj.AssignProjectSave();
            Response.Write("<script>alert('Assign Successe....!')</script>");


            clsProject objt = new clsProject();               //Project DataFatch
            DataTable dtT = new DataTable();
            dtT = objt.drpProject();
            drpProject.DataSource = dtT;
            drpProject.DataValueField = "ProjectID";
            drpProject.DataTextField = "ProjectName";
            drpProject.DataBind();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }

        protected void drpProject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}