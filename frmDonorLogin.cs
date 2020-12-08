using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// needed for MsSql to work
using System.Data.SqlClient;

// needed for email to work
using System.Net.Mail;

namespace Design_Document_Mock_Up
{
    public partial class frmDonorLogin : Form
    {
        private string connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private string sql = null;

        public frmDonorLogin()
        {
            InitializeComponent();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            //Closes the form when RETURN button is clicked
            this.Hide();
        }

        private void btn_accCreate_Click(object sender, EventArgs e)
        {
            //Opening AddDonor Form 
            frmAddDonor frmAddDonor = new frmAddDonor();
            //Hides this form
            this.Hide();
            //Opens AddDonor Form
            frmAddDonor.ShowDialog();
            //Opens THIS form when CreateWorker closes
            this.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            int match = 0;

            try
            {
                // ADD SQL STUFF 
                cnn = new SqlConnection(connectionString);
                /// Open the connection  
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                cnn.ConnectionString = connectionString;
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM test_table WHERE UserName = '" +
                    txt_userName.Text + "' AND Password = '" +
                    txt_password.Text + "' AND IsDonor = 'Y'", cnn);

                SqlDataAdapter counter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                counter.Fill(ds);

                // If unique return value, valid login
                match = ds.Tables[0].Rows.Count;

                if (match == 1)
                    loginSuccess();
                else
                {
                    // Username should be searched upon to prevent duplicates!
                    // Email Address field needs proofing!
                    string message = "Incorrect Username or Password!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void loginSuccess()
        {
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Number FROM test_table WHERE UserName = '" +
                    txt_userName.Text + "' AND Password = '" +
                    txt_password.Text + "' AND IsDonor = 'Y'", cnn);
            
            txt_userName.Text = "";
            txt_password.Text = "";

            SqlDataAdapter counter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            counter.Fill(ds);

            counter.Dispose();
            cmd.Dispose();

            frmMain.donorID DonorLogin = new frmMain.donorID();
            string count = cmd.ExecuteScalar().ToString();
            DonorLogin.donorNumber = count;
            frmMain.donorNum.Add(DonorLogin);

            //Opening AddDonor Form 
            frmDonorSplash frmDonorSplash = new frmDonorSplash();
            //Hides this form
            this.Hide();
            //Opens AddDonor Form
            frmDonorSplash.ShowDialog();
            //Opens THIS form when CreateWorker closes
            this.Show();
        }

        private void btn_sendRec_Click(object sender, EventArgs e)
        {
            try
            {
                string getEmail = txt_EnterEmail.Text;

                cnn = new SqlConnection(connectionString);
                /// Open the connection  
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                cnn.ConnectionString = connectionString;
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT Password FROM test_table " +
                    "WHERE EmailAddress = '" + getEmail + "'", cnn);

                SqlDataAdapter counter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                counter.Fill(ds);

                string password = cmd.ExecuteScalar().ToString();
                
                counter.Dispose();
                cmd.Dispose();

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("testinganappffs@gmail.com");
                mail.To.Add(getEmail);
                mail.Subject = "Email Reminder";
                mail.Body = "Your password is " + password;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("testinganappffs", "changeafterfinal");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Password Reminder Sent to Email!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
