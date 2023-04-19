using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectManagement_AspDotNet
{
    public partial class Login : System.Web.UI.Page
    {
        string Type;
        public int ProjectID;
        public int EmployeeID;
        public string EmailID;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            
            
           
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            clsProject obj = new clsProject(txtEmail.Text, txtPassword.Text);
            SqlDataReader dr;
            dr = obj.Login();
            while (dr.Read())
            {
                EmployeeID = Convert.ToInt32( dr["EmployeeID"].ToString());
                Type = dr["TypeID"].ToString();
                EmailID = dr["Eemail"].ToString();
            //    ProjectID = Convert.ToInt32(dr["ProjectID"].ToString());
               // Password = dr["EPassword"].ToString();
            }
            if (dr.HasRows == true)
            {
                if (dr.HasRows && Type == "1")          //Admin
                {
                    
                     Response.Redirect("All Project");                  //AssignProject To Project Manager 

                    Response.Write("<script>alert('Login Successfully....!')</script>");

                }
                else if(dr.HasRows && Type == "3")           //ProjectManager
                {
                    
                    Session["Eemail"] = Email;
                    Response.Redirect("Project Manager");                 //Assign ProjectManager  to TeamLeader
                    Response.Write("<script>alert('Login Successe....!')</script>");

                }
                else if (dr.HasRows && Type == "2")          //TeamLeader    
                {
                  //  Session["ProjectID"] = ProjectID;
                    Session["Eemail"] = EmailID;
                  //  Session["EmployeeID"] = EmployeeID;
                    Response.Redirect("Team Leader.aspx");         // Team Leader Project Report

                }
            }
        }
    }
}