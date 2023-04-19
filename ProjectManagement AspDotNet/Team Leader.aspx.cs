using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 

namespace ProjectManagement_AspDotNet
{
    public partial class Team_Leader3 : System.Web.UI.Page
    {
        int EmployeeID;
        string Email; 
        string status;
        int ProjectID;
        protected void Page_Load(object sender, EventArgs e)
        {
           
               // ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
             //   EmployeeID = Convert.ToInt32(Session["EmployeeID"].ToString());
                Email = Session["Eemail"].ToString();
                clsProject obj = new clsProject(Email);
                SqlDataReader dr;
                dr = obj.GetTeamdata();
                while (dr.Read())
                {
                    lblTlName.Text = dr["EName"].ToString();
                    lblProjectName.Text = dr["ProjectName"].ToString();
                    Label3.Text = dr["ProjectName"].ToString();
                    Label4.Text = dr["ProjectName"].ToString();
                    Label5.Text = dr["ProjectName"].ToString();
                    EmployeeID = Convert.ToInt32(dr["TLId"].ToString());
                    status = dr["Status"].ToString();

                }
                
            if (status == " Pending")
            {
                btnComplete1.Enabled = true;
                btnComplete2.Enabled = false;
                btnComplete3.Enabled = false;
            }

            if (status == "Itration1 Completed") 
            {
                btnComplete3.Enabled = false;
                btnComplete2.Enabled = true;
                btnComplete1.Enabled=false;
            }

            if (status == "Itration2 Completed")
            {
                btnComplete3.Enabled = true;
                btnComplete2.Enabled = false;
            }
            if (status == "Project Copmleted")
            {
                btnComplete1.Enabled = false;
                btnComplete2.Enabled = false;
                btnComplete3.Enabled = false;
            }


        }

        protected void btnComplete1_Click(object sender, EventArgs e)
        {
            string Status = "Itration1 Completed";
           if(status == "Itration1 Completed")
            {
                btnComplete2.Enabled = true;
            }

            else
            {
                clsProject obj = new clsProject(Status, EmployeeID);
                obj.StatusUpdateTL(); 
                
                    btnComplete2.Enabled = true;
                    btnComplete3.Enabled = false;
                    btnComplete1.Enabled = false;

            }
            
           
        }

        protected void btnComplete2_Click(object sender, EventArgs e)
        {
            string Status1 = "Itration2 Copmleted";
            if(status == "Itration2 Copmleted")
            {
                btnComplete3.Enabled = true;
            }
            else
            {
                clsProject obj = new clsProject(Status1, EmployeeID);
                obj. StatusUpdateTL();
                btnComplete1.Enabled = false;
                btnComplete3.Enabled = true;
                btnComplete2.Enabled = false;
            }
        }

        protected void btnComplete3_Click(object sender, EventArgs e)
        {
            string Status2 = "Project Copmleted";
            if(status == "Project Copmleted")
            {
                btnComplete3.Enabled = true;
            }
            else
            {
                clsProject obj = new clsProject(Status2, EmployeeID);
                obj.StatusUpdateTL();
                Response.Write("<script>alert('Project Completed SuccesFully....!')</script>");

                btnComplete1.Enabled = false;
                btnComplete2.Enabled = false;
                btnComplete3.Enabled = false;
            }
           
             
        }
    }
}