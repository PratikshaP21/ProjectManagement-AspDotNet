using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectManagement_AspDotNet
{
    public partial class Completed_Project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsProject obj = new clsProject();
           DataTable dt = new DataTable();
            dt = obj.CompletedProject();
            grdCompletedProject.DataSource = dt;
            grdCompletedProject.DataBind();
            //grdCompletedProject.Columns[6].Visible = false;
            //grdCompletedProject.Columns[7].Visible= false;


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ProjectName = grdCompletedProject.SelectedRow.Cells[0].Text;

            string TeamLeader = grdCompletedProject.SelectedRow.Cells[1].Text;
            string ProjectManager = grdCompletedProject.SelectedRow.Cells[2].Text;
            string Eemail = grdCompletedProject.SelectedRow.Cells[3].Text;
            string EPhoneNo = grdCompletedProject.SelectedRow.Cells[4].Text;
          // string AssignDate = grdCompletedProject.SelectedRow.Cells[5].Text;
            int TLId = Convert.ToInt32(grdCompletedProject.SelectedRow.Cells[6].Text);
            int ProjectID = Convert.ToInt32(grdCompletedProject.SelectedRow.Cells[7].Text);
            int Amount = 50000;
            Session["ProjectID"] = ProjectID;
            Response.Redirect("Pay.aspx?ProjectName=" + ProjectName + "&ProjectManager=" + ProjectManager + "&TeamLeader=" + TeamLeader + "&Eemail=" + Eemail + "&PhoneNo" + EPhoneNo + "&Amount" + Amount + "&ProjectID" + ProjectID + "&TLID" + TLId);

        }
    }
}