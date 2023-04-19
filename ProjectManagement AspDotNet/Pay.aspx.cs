using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectManagement_AspDotNet
{
    public partial class Pay : System.Web.UI.Page
    {
        public int ProjectID;
        public int TLId;
        public int Amount;
        public string Status;
        protected void Page_Load(object sender, EventArgs e)
        {
            string ProjectName = Request.QueryString["ProjectName"];
            Amount = Convert.ToInt32(Request.QueryString["Amount"]);
            string ProjectManager = Request.QueryString["PMId"];
            string TLId = Request.QueryString["TLId"];
            string Eemail = Request.QueryString["Eemail"];
            string EPhoneNo = Request.QueryString["EPhoneNo"];
        }

        protected void btnPayment_Click(object sender, EventArgs e)
        {
            ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            string PaymentStatus = "Payment Done";
            clsProject obj = new clsProject(TLId,ProjectID,Amount,PaymentStatus);
            obj.SavePayment();
            Response.Write("<script language='javascript'>alert(Payment Completed Succesfully...!);</script>");
        }
    }
}