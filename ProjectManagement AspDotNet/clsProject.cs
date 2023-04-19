using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel.Design;

namespace ProjectManagement_AspDotNet
{
    public class clsProject
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DCO3HP2\\SQLEXPRESS01;Initial Catalog=ProjectManagementASP;Integrated Security=True");

        public int CountryID { get; set; }
        public int Type { get; set; }
        public string EName { get; set; }
        public string Eemail { get; set; }
        public string EPhoneNo { get; set; }
        public string EGender { get; set; }
        public int StateID { get; set; }
        public int CityID { get; set; }
        public string Password { get; set; }
        public string ProjectType { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ProjectID { get; set; }
        public int EmployeeID { get; set; }
        public string Status { get; set; }
        public DateTime AssignDate { get; set; }
        public int PMId { get; set; }
        public int TLId { get; set; }
        public int PaymentAmount { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }

        public clsProject(int Tlid,int Projectid,int Paymentamount,string Paymentstatus)
        {
            TLId= Tlid;
            ProjectID= Projectid;
            PaymentAmount= Paymentamount;
            PaymentStatus= Paymentstatus;
        }
        public void SavePayment()     //Payment Save 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SavePayment");
            cmd.Parameters.AddWithValue("@TLId", TLId);
            cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
            cmd.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
            cmd.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public clsProject(int projectID,int Pmid)
        {
            ProjectID=projectID;
            PMId=Pmid;
            //Status=status;
            //AssignDate=Assigndate;
        }
        public void AssignProjectSave()     //ProjectManager Save
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType =CommandType.StoredProcedure; 
            cmd.Parameters.AddWithValue("@Flag", "AssignProjectSave");
            cmd.Parameters.AddWithValue("@ProjectID", ProjectID); 
            cmd.Parameters.AddWithValue("@PMId", PMId);
            //cmd.Parameters.AddWithValue("@Status", Status);
            //cmd.Parameters.AddWithValue("@AssignDate", AssignDate);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void AssignTeamLeader()     //TeamLeader Update
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AssignTeamLeader");
            cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
            cmd.Parameters.AddWithValue("@TLId", PMId);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public clsProject(int type, string Ename , string Email,string Ephone,string Egender,int city,string Epassword )
        {
            Type = type;
            EName = Ename;
            Eemail = Email;
            EPhoneNo = Ephone;
            EGender = Egender;
            CityID = city;
            Password = Epassword;
        }
        public void SaveEmployeeData()          //Employee Save  
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveEmployeeData");
            cmd.Parameters.AddWithValue("@TypeID", Type);
            cmd.Parameters.AddWithValue("@EName", EName);
            cmd.Parameters.AddWithValue("@Eemail", Eemail);
            cmd.Parameters.AddWithValue("@EPhoneNo", EPhoneNo);
            cmd.Parameters.AddWithValue("@EGender", EGender);
            cmd.Parameters.AddWithValue("@CityID", CityID);
            cmd.Parameters.AddWithValue("@EPassword", Password);         
            cmd.ExecuteNonQuery();
            con.Close();
        }
       public clsProject(string projectType,string projectname ,DateTime Startdate,DateTime Enddate)
       {
            ProjectType = projectType;
            ProjectName= projectname;
            StartDate= Startdate;
            EndDate= Enddate;
       }
        public void SaveProjectData()          //Prohject Save  
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "SaveProjectData");
            cmd.Parameters.AddWithValue("@ProjectType", ProjectType);
            cmd.Parameters.AddWithValue("@ProjectName", ProjectName);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsProject( int countryID)
        {
            CountryID = countryID;
        }
        public clsProject(string Email)
        {
            Eemail = Email;
        }
        public clsProject()
        {

        }
        public clsProject(string Email,string Epassword)
        {
            Eemail = Email;
            Password= Epassword;
        }
        public SqlDataReader Login()            // Login  
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Login");
            cmd.Parameters.AddWithValue("@Eemail", Eemail);
            cmd.Parameters.AddWithValue("@EPassword", Password);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;    
            con.Close();
        }

        public DataTable GetType()            //get Type
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetType");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable GetCountry()            //get Country
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCountry");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetState()            //get State
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetState");
            cmd.Parameters.AddWithValue("@CountryID", CountryID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
       public DataTable GetCity()              //get City
       {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCity");
            cmd.Parameters.AddWithValue("@StateID", CountryID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable AllProject()  ///after login Admin All Project  
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AllProject");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public DataTable GetTeamLeaderProject()            //get TeamLeader ProjectName
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTeamLeaderProject");
            cmd.Parameters.AddWithValue("@Eemail", Eemail);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetProjectManager()            //get ProjectManaher
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetProjectManager");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetTeamLeader()            //get TeamLeader
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTeamLeader");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable drpProject()            //get Project name after team leader login TlPage
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "drpProject");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public SqlDataReader GetTeamdata()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTeamdata");
            cmd.Parameters.AddWithValue("@Eemail", Eemail);
            SqlDataReader dr;
            dr =cmd.ExecuteReader();
            return dr;
            con.Close();    
        }
        public clsProject(String status,int pid)
        {
            Status = status;
            ProjectID = pid;
        }
        public void StatusUpdateTL()     //TeamLeader Update Status tblassign
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "StatusUpdateTL");
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@TLId", ProjectID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable CompletedProject()  ///after login Admin Completed Project Project  
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CompletedProject");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
    }
}