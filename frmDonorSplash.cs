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

// for printing I guess
using System.Drawing.Printing;

namespace Design_Document_Mock_Up
{
    public partial class frmDonorSplash : Form
    {
        private string connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private string sql = null;
        string filedir = "C:/Users/admin/Documents/Visual Studio 2019/Projects/BDMS - In Progress/bin/";

        public frmDonorSplash()
        {
            InitializeComponent();
        }

        private void btn_appmntSched_Click(object sender, EventArgs e)
        {
            //Opening AddDonor Form 
            frmDonorPage frmDonorPage = new frmDonorPage();
            //Hides this form
            this.Hide();
            //Opens AddDonor Form
            frmDonorPage.ShowDialog();
            //Opens THIS form when CreateWorker closes
            this.Show();
        }

        private string getPassword()
        {
            string num = frmMain.donorNum[0].donorNumber;
            string appstring = "";

            //first part
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Password FROM test_table " +
                "WHERE Number = '" + num + "'", cnn);

            SqlDataAdapter counter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            counter.Fill(ds);

            appstring += " " + cmd.ExecuteScalar().ToString();
            counter.Dispose();
            cmd.Dispose();

            return appstring;
        }

       

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frmMain.donorNum.Clear();
            this.Hide();
        }

        private void btn_changePic_Click(object sender, EventArgs e)
        {
            //Opening AddDonor Form 
            frmProfileImage frmProfileImage = new frmProfileImage();
            //Hides this form
            this.Hide();
            //Opens AddDonor Form
            frmProfileImage.ShowDialog();
            //Opens THIS form when CreateWorker closes
            this.Show();
        }

        private void frmDonorSplash_Load(object sender, EventArgs e)
        {
            string num = frmMain.donorNum[0].donorNumber;
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT SetImage FROM test_table " +
                "WHERE Number = '" + num + "'", cnn);

            SqlDataAdapter counter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            counter.Fill(ds);
                        
            string image = cmd.ExecuteScalar().ToString();
            counter.Dispose();
            cmd.Dispose();

            if (image == "")
                pct_Image.Image = Image.FromFile(filedir + "defaultpic.png");
            else
                pct_Image.Image = Image.FromFile(filedir + image);
            fontNScheme();
        }

        private void fontNScheme()
        {
            string num = frmMain.donorNum[0].donorNumber;
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT FONT FROM test_table " +
                "WHERE Number = '" + num + "'", cnn);

            SqlDataAdapter counter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            counter.Fill(ds);

            string sFont = cmd.ExecuteScalar().ToString();
            counter.Dispose();
            cmd.Dispose();

            //second part
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            cmd = new SqlCommand("SELECT Scheme FROM test_table " +
                "WHERE Number = '" + num + "'", cnn);
            counter = new SqlDataAdapter(cmd);
            counter.Fill(ds);
            
            string sScheme = cmd.ExecuteScalar().ToString();
            counter.Dispose();
            cmd.Dispose();

            int setFont = Int32.Parse(sFont);
            if (setFont == 1)
            {
                btn_appmntSched.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_changePic.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_UpdateCredentials.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_sendReminder.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_printReminder.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_WindowScheme.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_Logout.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
            }
            if (setFont == 2)
            {
                btn_appmntSched.Font = new Font("Calibri", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_changePic.Font = new Font("Calibri", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_UpdateCredentials.Font = new Font("Calibri", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_sendReminder.Font = new Font("Calibri", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_printReminder.Font = new Font("Calibri", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_WindowScheme.Font = new Font("Calibri", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_Logout.Font = new Font("Calibri", 12, FontStyle.Bold, GraphicsUnit.Point);
            }
            if (setFont == 3)
            {
                btn_appmntSched.Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_changePic.Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_UpdateCredentials.Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_sendReminder.Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_printReminder.Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_WindowScheme.Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_Logout.Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
            }
            int setScheme = Int32.Parse(sScheme);
            if (setScheme == 1)
            {
                this.BackColor = Color.DarkGray;
            }
            if (setScheme == 2)
            {
                this.BackColor = Color.PowderBlue;
            }
            if (setScheme == 3)
            {
                this.BackColor = Color.Black;
            }
        }

        private void ExecuteSQLStmt(string sql)
        {
            cnn = new SqlConnection(connectionString);
            // Open the connection  
            if (cnn.State != ConnectionState.Open)
                cnn.Open();
            //cnn = new SqlConnection(connectionString);
            //if (cnn.State == ConnectionState.Open)
            //    cnn.Close();
            //cnn.Open();
            cmd = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            try
            {
                adapter.InsertCommand.ExecuteNonQuery();
            }
            catch (SqlException ae)
            {
                MessageBox.Show(ae.Message.ToString());
            }
        }

        private void btn_sendReminder_Click(object sender, EventArgs e)
        {
            try
            {
                string num = frmMain.donorNum[0].donorNumber;

                cnn = new SqlConnection(connectionString);
                /// Open the connection  
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                cnn.ConnectionString = connectionString;
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT EmailAddress FROM test_table " +
                    "WHERE Number = '" + num + "'", cnn);

                SqlDataAdapter counter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                counter.Fill(ds);

                string emailAdd = cmd.ExecuteScalar().ToString();
                string mailmessage = combineAppmt();
                counter.Dispose();
                cmd.Dispose();

                if (mailmessage == "nope")
                {
                    MessageBox.Show("Need to Set Appointment");
                }
                else
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("testinganappffs@gmail.com");
                    mail.To.Add(emailAdd);
                    mail.Subject = "Test Mail";
                    mail.Body = "You have an appointment on " + mailmessage;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("testinganappffs", "changeafterfinal");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("Appointment Reminder Sent!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // because sql didn't like a 30 vachar even if you changed it to 50
        private string combineAppmt()
        {
            string num = frmMain.donorNum[0].donorNumber;
            string appstring = "";

            //first part
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT AppmntDayWeek FROM test_table " +
                "WHERE Number = '" + num + "'", cnn);

            SqlDataAdapter counter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            counter.Fill(ds);

            appstring += " " + cmd.ExecuteScalar().ToString();
            counter.Dispose();
            cmd.Dispose();

            if (appstring == " ")
            {
                appstring = "nope";
            }
            else
            {
                //second part
                cnn = new SqlConnection(connectionString);
                /// Open the connection  
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                cnn.ConnectionString = connectionString;
                cnn.Open();

                cmd = new SqlCommand("SELECT AppmntDateNum FROM test_table " +
                    "WHERE Number = '" + num + "'", cnn);
                counter = new SqlDataAdapter(cmd);
                counter.Fill(ds);
                appstring += " the " + cmd.ExecuteScalar().ToString();
                counter.Dispose();
                cmd.Dispose();

                //third part
                cnn = new SqlConnection(connectionString);
                /// Open the connection  
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                cnn.ConnectionString = connectionString;
                cnn.Open();

                cmd = new SqlCommand("SELECT AppmntTimeDay FROM test_table " +
                    "WHERE Number = '" + num + "'", cnn);
                counter = new SqlDataAdapter(cmd);
                counter.Fill(ds);
                appstring += " in the " + cmd.ExecuteScalar().ToString();
                counter.Dispose();
                cmd.Dispose();
            }
            return appstring;
        }

        private void btn_WindowScheme_Click(object sender, EventArgs e)
        {
            //Opening AddDonor Form 
            frmPreferences frmPreferences = new frmPreferences();
            //Hides this form
            this.Hide();
            //Opens AddDonor Form
            frmPreferences.ShowDialog();
            //Opens THIS form when CreateWorker closes
            this.Show();
        }

        private void btn_printReminder_Click(object sender, EventArgs e)
        {
            try
            {
                string mailmessage = "You have an appointment on " + combineAppmt();

                if (mailmessage == "You have an appointment on nope")
                {
                    MessageBox.Show("Need to Set Appointment!");
                }    
                else
                {
                    PrintDocument p = new PrintDocument();
                    p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                    {
                        e1.Graphics.DrawString(mailmessage, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
                    };
                    p.Print();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
            
        }

        private void prnt_Reminder_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //
        }

        private void btn_UpdateCredentials_Click(object sender, EventArgs e)
        {
            //Opening Donor Splash Form 
            frmUpdateCredentials frmUpdateCredentials = new frmUpdateCredentials();
            //Hides this form
            this.Hide();
            //Opens Donor Splash Form
            frmUpdateCredentials.ShowDialog();
            //Opens THIS form when CreateWorker closes
            this.Show();
        }

        private void frmDonorSplash_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.donorNum.Clear();
            //Opening AddDonor Form 
            this.Hide();
        }
    }
}
