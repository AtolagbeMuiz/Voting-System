using System;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VotingSystem
{
    public partial class VotersPortal : System.Web.UI.Page
    {
        //SqlConnection sqlConn = new SqlConnection("Server=.;Database=VoterRegister;User Id=muiz;Password=oluwadamilare;");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            VoterPortalDetails();
        }

        public void VoterPortalDetails()
        {
            try
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["VotingSytemConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ViewVoterDetails";

                
                string VoterID = "";
                cmd.Parameters.Add("@VoterID", System.Data.SqlDbType.VarChar).Value = VoterID;
                SqlDataReader getrecord1 = null;

                getrecord1 = cmd.ExecuteReader();
                getrecord1.Read();


                //Getting Data from the Database
                if (getrecord1.HasRows == true)
                {
                    if (getrecord1["Surname"].Equals(DBNull.Value) == true)
                    {

                        this.lblSurname.Text = "";

                    }
                    else
                    {

                        this.lblSurname.Text = getrecord1["Surname"].ToString();
                    }



                    if (getrecord1["Other Names"].Equals(DBNull.Value) == true)
                    {

                        this.lblOthernames.Text = "";

                    }
                    else
                    {

                        this.lblOthernames.Text = getrecord1["Other Names"].ToString();
                    }
                    if (getrecord1["Email"].Equals(DBNull.Value) == true)
                    {

                        this.lblEmail.Text = "";

                    }
                    else
                    {

                        this.lblEmail.Text = getrecord1["Email"].ToString();
                    }
                    if (getrecord1["Date Of Birth"].Equals(DBNull.Value) == true)
                    {

                        this.lblDOB.Text = "";

                    }
                    else
                    {

                        this.lblDOB.Text = getrecord1["Date Of Birth"].ToString();
                    }
                    if (getrecord1["Blood Group"].Equals(DBNull.Value) == true)
                    {

                        this.lblBloodGroup.Text = "";

                    }
                    else
                    {

                        this.lblBloodGroup.Text = getrecord1["Blood Group"].ToString();
                    }
                    if (getrecord1["Address"].Equals(DBNull.Value) == true)
                    {

                        this.lblAddress.Text = "";

                    }
                    else
                    {

                        this.lblAddress.Text = getrecord1["Address"].ToString();
                    }



                    if (getrecord1["Genotype"].Equals(DBNull.Value) == true)
                    {

                        this.lblGenotype.Text = "";

                    }
                    else
                    {

                        this.lblGenotype.Text = getrecord1["Genotype"].ToString();
                    }
                    if (getrecord1["Telephone"].Equals(DBNull.Value) == true)
                    {

                        this.lblTel.Text = "";

                    }
                    else
                    {

                        this.lblTel.Text = getrecord1["Telephone"].ToString();
                    }
                    if (getrecord1["Next Of Kin"].Equals(DBNull.Value) == true)
                    {

                        this.lblNextOfKin.Text = "";

                    }
                    else
                    {

                        this.lblNextOfKin.Text = getrecord1["Next Of Kin"].ToString();
                    }
                    if (getrecord1["Next Of Kin's Number"].Equals(DBNull.Value) == true)
                    {

                        this.lblNextOfKinNumber.Text = "";

                    }
                    else
                    {

                        this.lblNextOfKinNumber.Text = getrecord1["Next Of Kin's Number"].ToString();
                    }

                    if (getrecord1["Address Of Next Of Kin"].Equals(DBNull.Value) == true)
                    {

                        this.lblAddressofNextofKin.Text = "";

                    }
                    else
                    {

                        this.lblAddressofNextofKin.Text = getrecord1["Address Of Next Of Kin"].ToString();
                    }


                }
                con.Close();
            }
            catch (Exception)
            {
                //Do Nothing
            }
           
        }
    }
}