using System;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VotingSystem
{
    public partial class VotersLoginPage : System.Web.UI.Page
    {
        SqlConnection sqlConn = new SqlConnection("Server=.;Database=VoterRegister;User Id=muiz;Password=oluwadamilare;");
        //string hashedResult = string.Empty;
        //string hashdata = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLoginErrorMessage.Visible = false;
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            try
            {
                txtLoginPassword.Text = SaltHashPassword();
                //Declaring Connection string
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["VotingSytemConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoginUser";

                
                cmd.Parameters.Add("@VoterID", SqlDbType.VarChar).Value = txtLoginVoterID.Text.Trim();
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtLoginPassword.Text;


                int codereturn = (int)cmd.ExecuteScalar();

                if (codereturn == 1)
                {
                    Response.Redirect("VotersPortal.aspx");
                }
                else
                {
                    this.lblLoginErrorMessage.Visible = true;
                    this.lblLoginErrorMessage.ForeColor = System.Drawing.Color.Red;
                    this.lblLoginErrorMessage.Text = "Your VoterID or Password is Invalid";
                }

                con.Close();
            }
            catch (Exception ex)
            {

                this.lblLoginErrorMessage.Visible = true;
                this.lblLoginErrorMessage.ForeColor = System.Drawing.Color.Red;
                this.lblLoginErrorMessage.Text = ex.Message;
            }
        }


        public string SaltHashPassword()
        {

            SHA1 sha = SHA1.Create();
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(txtLoginPassword.Text));
            StringBuilder returnValue = new StringBuilder();

            for (int i = 0; i < hashdata.Length; i++)
            {
                returnValue.Append(hashdata[i].ToString());
            }

            return returnValue.ToString();





            ////Declaring the RandomNumberGenerator(RNG) to randomly genrate salt characters
            //var rngCsp = new System.Security.Cryptography.RNGCryptoServiceProvider();

            ////Getting the bytes(size) of salt
            //byte[] salt = new byte[20];

            ////casting the salt bytes into the RNG. i.e to get the size of the salt randonly generated
            //rngCsp.GetBytes(salt);

            ////Encoding txtPassowrd.Text to get the Bytes of the Entered Password(i.e. txtPassword.Text)
            //var passwordbytes = ASCIIEncoding.ASCII.GetBytes(txtLoginPassword.Text);
            //byte[] datainput = new byte[salt.Length + passwordbytes.Length];

            //for (int i = 0; i < passwordbytes.Length; i++)
            //{
            //    datainput[i] = passwordbytes[i];
            //}

            //for (int i = 0; i < salt.Length; i++)
            //{
            //    datainput[i + passwordbytes.Length] = salt[i];
            //}

            ////Declaring SHA512 hash cryptography
            //System.Security.Cryptography.SHA512 shaM = new System.Security.Cryptography.SHA512Managed();

            ////computing the Hash for datainput(salt.length+passwordbytes.length)
            //var hashedByteArray = shaM.ComputeHash(datainput);

            ////coverting the hashedbytearray to basae64String
            //hashedResult = Convert.ToBase64String(hashedByteArray);


            }
        }
}