using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// needed for MySql to work
using System.Data.SqlClient;

namespace Design_Document_Mock_Up
{
    public partial class frmCreateWorker : Form
    {
        private string connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private string sql = null;

        public frmCreateWorker()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_genIDCode_Click(object sender, EventArgs e)
        {
            lbl_randCode.Text = "";
            lbl_randCode.Text = randID();
        }

        public string randID()
        {
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();
            int match = 0;
            Boolean reroll = true;
            string strID = "";
            Random r = new Random();

            while (reroll == true)
            {
                int getRand = r.Next(100, 999);
                strID = getRand.ToString();
                SqlCommand cmd = new SqlCommand("SELECT * FROM test_table WHERE PersonID = '" + strID + "'", cnn);

                SqlDataAdapter counter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                counter.Fill(ds);
                counter.Dispose();
                cmd.Dispose();

                // If unique return value, valid login
                match = ds.Tables[0].Rows.Count;

                if (match < 1)
                    reroll = false;
            }
            return strID;
        }

        public string scheduleSelect()
        {
            string getSchedule = "";

            if (radb_Morning.Checked == true)
                getSchedule = "Morning";
            if (radb_Noon.Checked == true)
                getSchedule = "Noon";
            if (radb_Afternoon.Checked == true)
                getSchedule = "Afternoon";

            return getSchedule;
        }

        private bool usernameCheck()
        {
            Boolean userNameCHK = false;
            string strID = txt_userName.Text.ToString();
            int match = 0;
            SqlCommand cmd = new SqlCommand("SELECT * FROM test_table WHERE UserName = '" + strID.ToString() + "'", cnn);

            SqlDataAdapter counter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            counter.Fill(ds);


            // If unique return value, valid login
            match = ds.Tables[0].Rows.Count;
            counter.Dispose();
            cmd.Dispose();

            if (match >= 1)
                userNameCHK = true;
            return userNameCHK;
        }

        private bool emailCheck()
        {
            Boolean emailCHK = false;
            string strID = txt_emailAdd.Text.ToString();
            int match = 0;
            SqlCommand cmd = new SqlCommand("SELECT * FROM test_table WHERE EmailAddress = '" + strID.ToString() + "'", cnn);

            SqlDataAdapter counter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            counter.Fill(ds);


            // If unique return value, valid login
            match = ds.Tables[0].Rows.Count;
            counter.Dispose();
            cmd.Dispose();

            if (match >= 1)
                emailCHK = true;

            return emailCHK;
        }

        private bool phoneCheck()
        {
            Boolean phoneCHK = false;
            string strID = txt_phoneNum.Text.ToString();
            int match = 0;
            SqlCommand cmd = new SqlCommand("SELECT * FROM test_table WHERE PhoneNumber = '" + strID.ToString() + "'", cnn);

            SqlDataAdapter counter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            counter.Fill(ds);


            // If unique return value, valid login
            match = ds.Tables[0].Rows.Count;
            counter.Dispose();
            cmd.Dispose();

            if (match >= 1)
                phoneCHK = true;

            return phoneCHK;
        }

        private void btn_addWorker_Click(object sender, EventArgs e)
        {
            Boolean userNM = usernameCheck();
            Boolean emailCHK = emailCheck();
            Boolean phCHK = phoneCheck();
            try
            {
                if (radb_Morning.Checked == false
                    && radb_Afternoon.Checked == false
                    && radb_Noon.Checked == false)
                {
                    string message = "Please select your schedule!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_First.Text == "")
                {
                    string message = "Add your First Name!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_Last.Text == "")
                {
                    string message = "Add your Last Name!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_userName.Text == "")
                {
                    string message = "Add your User Name!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (userNM == true)
                {
                    string message = "Username already exists! Choose Another!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_passWord.Text == "")
                {
                    string message = "Add your Password!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_passConf.Text == "")
                {
                    string message = "Confirm your password!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_passWord.Text != txt_passConf.Text)
                {
                    string message = "Passwords do not match!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_phoneNum.Text == "")
                {
                    string message = "Add your Phone Number!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (phCHK == true)
                {
                    string message = "Phone Number already exists! Choose Another!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_emailAdd.Text == "")
                {
                    string message = "Add your Email Address!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (emailCHK == true)
                {
                    string message = "Email already exists! Choose Another!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    // ADD SQL STUFF 
                    cnn = new SqlConnection(connectionString);
                    /// Open the connection  
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                    connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                    cnn.ConnectionString = connectionString;
                    cnn.Open();

                    string gender = "";
                    string bGroup = "";
                    string address = "";
                    string schedule = scheduleSelect();
                    string IDcode = lbl_randCode.Text.ToString();

                    string getNum = newNum();
                    int iterate = Int32.Parse(getNum);
                    iterate++;

                    sql = "INSERT INTO test_table(Number, PersonID, LastName, " +
               "FirstName, Password, PhoneNumber, EmailAddress, " +
               "Gender, BloodGroup, UserName, Address, Age, Schedule, " +
               "IsDonor, IsAdmin, IsWorker) " +
               //values 
               "Values ('"+ iterate.ToString() +
               "', '" + IDcode + 
               "', '" + txt_Last.Text.ToString() +
               "', '" + txt_First.Text.ToString() +
               "', '" + txt_passWord.Text.ToString() +
               "', '" + txt_phoneNum.Text.ToString() +
               "', '" + txt_emailAdd.Text.ToString() +
               "', '" + gender +
               "', '" + bGroup +
               "', '" + txt_userName.Text.ToString() +
               "', '" + address +
               "', '" + "" +
               "', '" + schedule +
               "', 'N', 'N', 'Y')";
                    // Codes for identifying donors, workers, and admins on the database
                    ExecuteSQLStmt(sql);

                    // To DO
                    // Username should be searched upon to prevent duplicates!
                    // ID code needs random generation!
                    //      ID code must also not be a duplicate
                    // Email Address field needs proofing!
                    string message = "Worker Account Created!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                    allClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void allClear()
        {
            txt_First.Text = "";
            txt_Last.Text = "";
            txt_userName.Text = "";
            txt_passWord.Text = "";
            txt_passConf.Text = "";
            txt_phoneNum.Text = "";
            txt_emailAdd.Text = "";
            radb_Afternoon.Checked = false;
            radb_Morning.Checked = false;
            radb_Noon.Checked = false;
        }

        private string newNum()
        {
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT MAX(Number) FROM test_table", cnn);

            SqlDataAdapter counter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            counter.Fill(ds);

            counter.Dispose();
            cmd.Dispose();

            //// If unique return value, valid login
            //int count = ds.Tables[0].Rows.Count;
            sql = "SELECT MAX(Number) FROM test_table";

            //adapter.InsertCommand.ExecuteNonQuery();

            string count = cmd.ExecuteScalar().ToString();
            if (count == "")
                count = "0";
            //ExecuteSQLStmt(sql);
            return count;
        }

        private void frmCreateWorker_Load(object sender, EventArgs e)
        {
            lbl_randCode.Text = randID();
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

        private void txt_phoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
