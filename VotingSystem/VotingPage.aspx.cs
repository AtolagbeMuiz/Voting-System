using System;
using System.Data;
using System.Data.SqlClient;
using System.Timers;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VotingSystem
{
    public partial class VotingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblMesaage.Visible = false;
        }

        protected void Vote_Click(object sender, EventArgs e)
        {
            CheckVoterID();
        }

        protected void rbtnOptions()
        {
            try
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["VotingSytemConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SaveVotes";

                //Selects a chosen option of radio button and insert it to the database
                cmd.Parameters.Add("@DateTime", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@VoterID", SqlDbType.VarChar).Value = txtVoterID.Text;
                cmd.Parameters.Add("@President", System.Data.SqlDbType.VarChar).Value = rbtnPresidentOption.SelectedValue;
                cmd.Parameters.Add("@VicePresident", System.Data.SqlDbType.VarChar).Value = rbtnVicePresidentOption.SelectedValue;
                cmd.Parameters.Add("@GeneralSecretary", System.Data.SqlDbType.VarChar).Value = rbtnGeneralSecretaryOption.SelectedValue;


                //Sqlcmd.ExecuteNonQuery executes the sqlcommands
                cmd.ExecuteNonQuery();

                
                this.lblMesaage.Visible = true;
                this.lblMesaage.ForeColor = System.Drawing.Color.Green;
                this.lblMesaage.Text = "Voted Successfully";

                con.Close();
            }
            catch (Exception ex)
            {

                this.lblMesaage.Visible = true;
                this.lblMesaage.Text = ex.Message;
            }
            
        }


        public void CheckVoterID()
        {
            try
            {
                // Declaring Connection String
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["VotingSytemConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);

                //Open Connection String
                con.Open();

                
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CheckVoterID";

                cmd.Parameters.Add("@VoterID", SqlDbType.VarChar).Value = txtVoterID.Text;

                int codereturn = (int)cmd.ExecuteScalar();
                if (codereturn==1)
                {
                    VotingTimeEnds();
                }
                else
                {
                    this.lblMesaage.Visible = true;
                    this.lblMesaage.ForeColor = System.Drawing.Color.Red;
                    this.lblMesaage.Text = "VoterID doesnt Exist";
                }
                   con.Close();
            }
            catch (Exception ex)
            {
                this.lblMesaage.Visible = true;
                this.lblMesaage.Text = ex.Message;
            }
        }

        public void CheckUserDontVoteTwice()
        {
            try
            {
                // Declaring Connection String
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["VotingSytemConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);

                //Open Connection String
                con.Open();


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DontVoteTwice";

                cmd.Parameters.Add("@VoterID", SqlDbType.VarChar).Value = txtVoterID.Text;

                int codereturn = (int)cmd.ExecuteScalar();
                if (codereturn == 1)
                {
                    this.lblMesaage.Visible = true;
                    this.lblMesaage.ForeColor = System.Drawing.Color.Red;
                    this.lblMesaage.Text = "You can't vote more than once!!!";
                }
                else
                {
                    rbtnOptions();
                }
                con.Close();




                //cmd.ExecuteReader();

                //if (reader.HasRows)
                //{
                //    this.lblMesaage.Visible = true;
                //    this.lblMesaage.ForeColor = System.Drawing.Color.Red;
                //    this.lblMesaage.Text = "You cant Vote More than Once!!!";
                //}
                //else
                //{
                //    rbtnOptions();
                //}
                //con.Close();
            }
            catch (Exception ex)
            {

                lblMesaage.Visible = true;
                lblMesaage.ForeColor = System.Drawing.Color.Red;
                lblMesaage.Text= ex.Message;
            }
        }   

        public void VotingTimeEnds()
        {
            try
            {
                DateTime endVoting = new DateTime(2020, 08, 31, 12, 0, 0);
                if (DateTime.Now > endVoting)
                {
                    this.lblMesaage.ForeColor = System.Drawing.Color.Red;
                    this.lblMesaage.Visible = true;
                    this.lblMesaage.Text = "Ooops!! Sorry, Voting Time has ended";
                }

                else
                {
                    CheckUserDontVoteTwice();
                }
               
            }
            catch (Exception ex)
            {
                this.lblMesaage.ForeColor = System.Drawing.Color.Red;
                this.lblMesaage.Visible = true;
                this.lblMesaage.Text = ex.Message;
            }
        }


    }
}