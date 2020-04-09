using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace VotingSystem
{
    public partial class VotersRegistration : System.Web.UI.Page
    {
        SqlConnection sqlConn = new SqlConnection("Server=.;Database=VoterRegister;User Id=muiz;Password=oluwadamilare;");
        //string hashedResult = string.Empty;
        //string hashdata = string.Empty;
        string VotersId = string.Empty;
        string SN = string.Empty;
        string Vot = "ESC000";
        protected void Page_Load(object sender, EventArgs e)
        {
            lblerrormessage.Visible = false;
            lblsuccessmessage.Visible = false;
        }

        protected void RegButtonClick(object sender, EventArgs e)
        {
            //This IF-Block makes sure Empty TextBoses isn't saved into the Database
            if (txtSurname.Text == "" || txtOthernames.Text == "" || txtEmail.Text == "" || txtDOB.Text == "" || txtGenotype.Text == "" || txtNOKAddress.Text == "" || txtNextOfKin.Text == "" || txtNOKTelephone.Text == "" || txtPassword.Text == "" || txtBloodGroup.Text == "" || txtAddress.Text == "")
            {
                lblsuccessmessage.Visible = false;
                lblerrormessage.Visible = true;
                lblerrormessage.ForeColor = System.Drawing.Color.Red;
                lblerrormessage.Text = "Pls, Ensure all forms are filled";
            }

            else
            {
                //calling CheckUser Method to check if User already exists
                CheckUser();
            }

        }

        public void Reg()
        {
            try
            {

                //Registration
                if (sqlConn.State == System.Data.ConnectionState.Closed)
                    sqlConn.Open();
                SqlCommand sqlcmd = new SqlCommand("SaveVotersRecord", sqlConn);
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Casting the VotersId returned in the GetVotersID() method into the txtvoterID.Text
                txtVoterID.Text = GetVotersId();

                //casting the hashed password returned in SaltHashPassword() method into the txtPassword.Text
                txtPassword.Text = SaltHashPassword();

                sqlcmd.Parameters.AddWithValue("@VoterID", txtVoterID.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@OtherNames", txtOthernames.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@DOB", txtDOB.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Telephone", txtTelephone.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Genotype", txtGenotype.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@BloodGroup", txtBloodGroup.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@NextOfKin", txtNextOfKin.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@NextOfKInNumber", txtNOKTelephone.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@NextOfKinAddress", txtNOKAddress.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());



                //Sqlcmd.ExecuteNonQuery executes the sqlcommands
                sqlcmd.ExecuteNonQuery();

                //closes the sqlconnection
                sqlConn.Close();


                //Success Message
                lblerrormessage.Visible = false;
                this.lblsuccessmessage.Visible = true;
                lblsuccessmessage.ForeColor = System.Drawing.Color.Green;
                lblsuccessmessage.Text = "Registration Successful";

                //calling the clear method to clear the Textboxes after Registration
                Clear();
            }
            catch (Exception ex)
            {
                lblsuccessmessage.Visible = false;
                lblerrormessage.Visible = true;
                lblsuccessmessage.ForeColor = System.Drawing.Color.Red;
                lblerrormessage.Text= ex.Message;
            }
        }    

        //public void AutoGenerateVoterID()
        //{
        //    if (sqlConn.State == System.Data.ConnectionState.Closed)
        //        sqlConn.Open();
        //    SqlCommand sqlcmd = new SqlCommand("AutoGenerateVoterID", sqlConn);
        //    sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    object obj = sqlcmd.ExecuteScalar();
        //    this.txtVoterID.Text = obj.ToString();
        //}


        protected string GetVotersId()
        {

            try
            {
                // Declaring Connection String
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["VotingSytemConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                
                //Open Connection String
                con.Open(); 

                //Data Reader
                SqlDataReader getrecord1 = null;
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetSN";

                getrecord1 = cmd.ExecuteReader();
                getrecord1.Read();

                if (getrecord1.HasRows == true)
                {
                    if (getrecord1["SerialNo"].Equals(DBNull.Value) == true)
                    {
                        //SN will be an Empty string if Value isnt found in the database table(SN): Column(SerialNo) 
                        SN = "";

                    }
                    else
                    {
                       //SN is the Value gotten from the database table(SN): Column(SerialNo) 
                       SN = getrecord1["SerialNo"].ToString();
                    }
                   
                }
                else
                {
                    //Error If Row is not found in the database table(SN)
                    this.lblerrormessage.ForeColor = System.Drawing.Color.Red;
                    this.lblerrormessage.Text = "Serial Number not found";
                }
                //Close Connection
                con.Close();

            }

            catch (Exception ex)
            {
                //Handle Error Exception and throw the ex.Message of the Error
                this.lblerrormessage.ForeColor = System.Drawing.Color.Red;
                this.lblerrormessage.Text = ex.Message;
            }

            //Updates the Database Table SN for the the next Record that will be entered
            updateSN();

            //Adds the String-value of Vot and SN value gotten from initially updated SN of the last Record entered
            VotersId = Vot + SN;

            //Returning VotersId
            return VotersId;


        }


        protected void updateSN()
        {
            //Adds 1 to the SN value and updates the SN table: Column(serialNo)
            int AddSn = int.Parse(SN) + 1;
            if (sqlConn.State == System.Data.ConnectionState.Closed)
                sqlConn.Open();
            SqlCommand sqlcmd = new SqlCommand("UpdateSN", sqlConn);
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;

            //inserts AddSn(updated value of SN) into the Database Table SN :Column(SerialNo)
            sqlcmd.Parameters.AddWithValue("@SN1", AddSn);

            sqlcmd.ExecuteNonQuery();

            
            
            //sqlConn.Close();
        }


        public void Clear()
        {
            txtSurname.Text = txtOthernames.Text = txtDOB.Text = txtEmail.Text = txtAddress.Text = txtTelephone.Text = txtGenotype.Text = txtBloodGroup.Text = txtNextOfKin.Text = txtNOKTelephone.Text = txtNOKAddress.Text = txtPassword.Text = "";

            //Disables the Regegister Button after Clearing details in the Textboxes
            btnReg.Enabled = false;

        }

        public string SaltHashPassword()
        {
            SHA1 sha = SHA1.Create();
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(txtPassword.Text));
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
            //var passwordbytes = ASCIIEncoding.ASCII.GetBytes(txtPassword.Text);
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

        public void CheckUser()
        {
            try
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["VotingSytemConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CheckUser";


                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
                cmd.Parameters.Add("@Surname", SqlDbType.VarChar).Value = txtSurname.Text;
                cmd.Parameters.Add("@OtherNames", SqlDbType.VarChar).Value = txtOthernames.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    //User Exists
                    lblsuccessmessage.Visible = false;
                    lblerrormessage.Visible = true;
                    lblerrormessage.ForeColor = System.Drawing.Color.Red;
                    lblerrormessage.Text = "User already exists";
                }

                else
                {
                    //close the reader before Reg() is executed
                    reader.Close();
                    reader.Dispose();
                    Reg();
                }

                 con.Close();

            }

            catch (Exception ex)
            {
                this.lblerrormessage.ForeColor = System.Drawing.Color.Red;
                this.lblerrormessage.Text = ex.Message;
            }
        }

    }
}