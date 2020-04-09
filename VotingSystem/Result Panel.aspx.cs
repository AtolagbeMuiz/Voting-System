using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VotingSystem
{
    public partial class Result_Panel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblMessage.Visible = false;
        }

        protected void btnShowAllResults_Click(object sender, EventArgs e)
        {
            CountAPCPresVotes();
            CountPDPPresVotes();
            CountAACPresVotes();

            CountAPCVicePresVotes();
            CountPDPVicePresVotes();
            CountAACVicePresVotes();

            CountAPCGenSecVotes();
            CountPDPGenSecVotes();
            CountAACGenSecVotes();
        }

        //Presidential Results
        public void CountAPCPresVotes()
        {
            try
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["VotingSytemConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CountAPCPresVotes";


                int APCPresidentialResult = (int)cmd.ExecuteScalar();
                this.txtAPCPres.Text = APCPresidentialResult.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                this.lblMessage.Visible = false;
                this.lblMessage.ForeColor = System.Drawing.Color.Red;
                this.lblMessage.Text = ex.Message;
            }
        }

        public void CountPDPPresVotes()
        {
            try
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["VotingSytemConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CountPDPPresVotes";


                int PDPPresidentialResult = (int)cmd.ExecuteScalar();
                this.txtPDPPres.Text = PDPPresidentialResult.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                this.lblMessage.Visible = false;
                this.lblMessage.ForeColor = System.Drawing.Color.Red;
                this.lblMessage.Text = ex.Message;
            }
        }

        public void CountAACPresVotes()
        {
            try
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["VotingSytemConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CountAACPresVotes";


                int AACPresidentialResult = (int)cmd.ExecuteScalar();
                this.txtAACPres.Text = AACPresidentialResult.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                this.lblMessage.Visible = false;
                this.lblMessage.ForeColor = System.Drawing.Color.Red;
                this.lblMessage.Text = ex.Message;
            }
        }


        //Vice Presidential Results
        public void CountAPCVicePresVotes()
        {
            try
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["VotingSytemConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CountAPCVicePresVotes";


                int APCVicePresidentialResult = (int)cmd.ExecuteScalar();
                this.txtAPCVice.Text = APCVicePresidentialResult.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                this.lblMessage.Visible = false;
                this.lblMessage.ForeColor = System.Drawing.Color.Red;
                this.lblMessage.Text = ex.Message;
            }
        }

        public void CountPDPVicePresVotes()
        {
            try
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["VotingSytemConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CountPDPVicePresVotes";


                int PDPVicePresidentialResult = (int)cmd.ExecuteScalar();
                this.txtPDPVice.Text = PDPVicePresidentialResult.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                this.lblMessage.Visible = false;
                this.lblMessage.ForeColor = System.Drawing.Color.Red;
                this.lblMessage.Text = ex.Message;
            }
        }

        public void CountAACVicePresVotes()
        {
            try
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["VotingSytemConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CountAACVicePresVotes";


                int AACVicePresidentialResult = (int)cmd.ExecuteScalar();
                this.txtAACVice.Text = AACVicePresidentialResult.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                this.lblMessage.Visible = false;
                this.lblMessage.ForeColor = System.Drawing.Color.Red;
                this.lblMessage.Text = ex.Message;
            }
        }


        //General Secretary Results
        public void CountAPCGenSecVotes()
        {
            try
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["VotingSytemConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CountAPCGenSecResult";


                int APCGenSecResult = (int)cmd.ExecuteScalar();
                this.txtAPCGenSec.Text = APCGenSecResult.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                this.lblMessage.Visible = false;
                this.lblMessage.ForeColor = System.Drawing.Color.Red;
                this.lblMessage.Text = ex.Message;
            }
        }

        public void CountPDPGenSecVotes()
        {
            try
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["VotingSytemConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CountPDPGenSecResult";


                int PDPGenSecResult = (int)cmd.ExecuteScalar();
                this.txtPDPGenSec.Text = PDPGenSecResult.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                this.lblMessage.Visible = false;
                this.lblMessage.ForeColor = System.Drawing.Color.Red;
                this.lblMessage.Text = ex.Message;
            }
        }

        public void CountAACGenSecVotes()
        {
            try
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["VotingSytemConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CountAACGenSecResult";


                int AACGenSecResult = (int)cmd.ExecuteScalar();
                this.txtAACGenSec.Text = AACGenSecResult.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                this.lblMessage.Visible = false;
                this.lblMessage.ForeColor = System.Drawing.Color.Red;
                this.lblMessage.Text = ex.Message;
            }
        }




        protected void DeclareWinner_Click(object sender, EventArgs e)
        {
            declarePresidentWinner();

            declareVicePresidentWinner();

            declareGenSecWinner();
        }



        public void declarePresidentWinner()
        {
            try
            {
                if (int.Parse(txtAPCPres.Text) > int.Parse(txtPDPPres.Text) && int.Parse(txtAPCPres.Text) > int.Parse(txtAACPres.Text))
                {
                    this.txtPresWinner.Text = "APC";
                }


                if (int.Parse(txtPDPPres.Text) > int.Parse(txtAPCPres.Text) && int.Parse(txtPDPPres.Text) > int.Parse(txtAACPres.Text))
                {
                    this.txtPresWinner.Text = "PDP";
                }

                if (int.Parse(txtAACPres.Text) > int.Parse(txtAPCPres.Text) && int.Parse(txtAACPres.Text) > int.Parse(txtPDPPres.Text))
                {
                    this.txtPresWinner.Text = "AAC";
                }
            }
            catch (Exception ex)
            {
                this.lblMessage.Text = ex.Message;
            }

        }

        public void declareVicePresidentWinner()
        {
            try
            {
                if (int.Parse(txtAPCVice.Text) > int.Parse(txtPDPVice.Text) && int.Parse(txtAPCVice.Text) > int.Parse(txtAACVice.Text))
                {
                    this.txtVicePresWinner.Text = "APC";
                }


                if (int.Parse(txtPDPVice.Text) > int.Parse(txtAPCVice.Text) && int.Parse(txtPDPVice.Text) > int.Parse(txtAACVice.Text))
                {
                    this.txtVicePresWinner.Text = "PDP";
                }

                if (int.Parse(txtAACVice.Text) > int.Parse(txtAPCVice.Text) && int.Parse(txtAACVice.Text) > int.Parse(txtPDPVice.Text))
                {
                    this.txtVicePresWinner.Text = "AAC";
                }
            }
            catch (Exception ex)
            {
                this.lblMessage.Text = ex.Message;
            }


        }

        public void declareGenSecWinner()
        {
            try
            {
                if (int.Parse(txtAPCGenSec.Text) > int.Parse(txtPDPGenSec.Text) && int.Parse(txtAPCGenSec.Text) > int.Parse(txtAACGenSec.Text))
                {
                    this.txtGenSecWinner.Text = "APC";
                }


                if (int.Parse(txtPDPGenSec.Text) > int.Parse(txtAPCGenSec.Text) && int.Parse(txtPDPGenSec.Text) > int.Parse(txtAACGenSec.Text))
                {
                    this.txtGenSecWinner.Text = "PDP";
                }

                if (int.Parse(txtAACGenSec.Text) > int.Parse(txtAPCGenSec.Text) && int.Parse(txtAACGenSec.Text) > int.Parse(txtPDPGenSec.Text))
                {
                    this.txtGenSecWinner.Text = "AAC";
                }
            }
            catch (Exception ex)
            {
                this.lblMessage.Text = ex.Message;
            }


        }



    }
    }