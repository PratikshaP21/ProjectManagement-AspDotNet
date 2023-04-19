using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectManagement_AspDotNet
{
    public partial class Employee : System.Web.UI.Page
    {
        string Gender;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                clsProject objC = new clsProject();               //Country DataFatch
                DataTable dt = new DataTable();
                dt = objC.GetCountry();
                drpCountry.DataSource = dt;
                drpCountry.DataValueField = "CountryId";
                drpCountry.DataTextField = "CountryName";
                drpCountry.DataBind();

                clsProject objt = new clsProject();               //Type DataFatch
                DataTable dtT = new DataTable();
                dtT = objt.GetType();
                drpType.DataSource = dtT;
                drpType.DataValueField = "TypeID";
                drpType.DataTextField = "TypeName";
                drpType.DataBind();






            }


        }

        protected void drpCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(drpCountry.SelectedValue.ToString());
            clsProject objState = new clsProject(Id);
            DataTable dtState = new DataTable();
            dtState = objState.GetState();
            drpState.DataSource = dtState;
            drpState.DataValueField = "StateID";
            drpState.DataTextField = "StateName";
            drpState.DataBind();    
        }

        protected void drpState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(drpState.SelectedValue.ToString());
            clsProject objCity = new clsProject(Id);
            DataTable dtCity = new DataTable();
            dtCity = objCity.GetCity();
            drpCity.DataSource = dtCity;
            drpCity.DataValueField = "CityID";
            drpCity.DataTextField = "CityName";
            drpCity.DataBind();
        }

        protected void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        protected void rdbFamale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if((rdbMale.Checked)==true)
            {
                Gender = "Male";
            }
            if ((rdbFemale.Checked) == true)
            {
                Gender = "Female";
            }
            //int country = Convert .ToInt32(drpCountry.SelectedValue.ToString());
            //int State = Convert.ToInt32(drpState.SelectedValue.ToString());
            int City = Convert.ToInt32(drpCity.SelectedValue.ToString());

            clsProject obj = new clsProject(Convert.ToInt32(drpType.SelectedValue.ToString()), txtName.Text, txtEmail.Text, txtPhone.Text, Gender,City, txtPassword.Text);
            obj.SaveEmployeeData();
              Response.Write("<script>alert('Employee Registered....!')</script>");
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = null;
            txtPassword.Text = null;
            txtPhone.Text = null;
            txtEmail.Text = null;
            drpCountry.SelectedIndex = 0;
            drpState.SelectedIndex = 0;
            drpCity.SelectedIndex = 0;
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
        }

        protected void drpCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}