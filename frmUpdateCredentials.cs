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

namespace Design_Document_Mock_Up
{
    public partial class frmUpdateCredentials : Form
    {
        private string connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private string sql = null;
        public frmUpdateCredentials()
        {
            InitializeComponent();
        }

        

        private bool usernameCheck()
        {
            Boolean userNameCHK = false;
            string strID = txt_userName.Text.ToString();
            int match = 0;
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();
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
            string strID = txt_phNum.Text.ToString();
            int match = 0;

            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();
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

        private void btn_addDonor_Click(object sender, EventArgs e)
        {
            // need to update these
            //Boolean userNM = usernameCheck();
            Boolean userNM = false;
            //Boolean emailCHK = emailCheck();
            Boolean emailCHK = false;
            //Boolean phCHK = phoneCheck();
            Boolean phCHK = false;
            try
            {
                if (chk_Agreement.Checked == false)
                {
                    string message = "Please Agree to the Privacy Policy!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_firstName.Text == "")
                {
                    string message = "Add your Name!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_Age.Text == "")
                {
                    string message = "Add your Age!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_phNum.Text == "")
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
                else if (txt_streetNum.Text == "")
                {
                    string message = "Add your Street Number!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_streetName.Text == "")
                {
                    string message = "Add your Street Name!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (radb_Male.Checked == false && radb_Female.Checked == false)
                {
                    string message = "Select your Gender!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (radb_TypeA.Checked == false
                    && radb_TypeB.Checked == false
                    && radb_TypeAB.Checked == false
                    && radb_O.Checked == false)
                {
                    string message = "Select your Blood Type!";
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
                    string message = "Enter your Username!";
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
                    string message = "Enter your Password!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_confirmPass.Text == "")
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
                else if (txt_passWord.Text != txt_confirmPass.Text)
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
                    string num = frmMain.donorNum[0].donorNumber;
                    // ADD SQL STUFF 
                    cnn = new SqlConnection(connectionString);
                    /// Open the connection  
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                    connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                    cnn.ConnectionString = connectionString;
                    cnn.Open();

                    string gender = genderSelect();
                    string bGroup = bloodGroup();
                    string address = fullAddress();

                    sql = "UPDATE test_table SET LastName = '" + txt_lastName.Text.ToString() +
                        "', FirstName = '" + txt_firstName.Text.ToString() +
                        "', Password = '" + txt_passWord.Text.ToString() +
                        "', PhoneNumber = '" + txt_phNum.Text.ToString() +
                        "', EmailAddress = '" + txt_emailAdd.Text.ToString() +
                        "', Gender = '" + gender + 
                        "', BloodGroup = '" + bGroup + 
                        "', UserName = '" + txt_userName.Text.ToString() +
                        "', Address = '" + address + 
                        "', Age = '" + txt_Age.Text.ToString() +
                        "' WHERE Number = '" + num + "'";
                    ExecuteSQLStmt(sql);


                    // Username should be searched upon to prevent duplicates!
                    // Email Address field needs proofing!
                    string message = "Donor Account Updated!";
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
            txt_firstName.Text = "";
            txt_lastName.Text = "";
            txt_userName.Text = "";
            txt_passWord.Text = "";
            txt_confirmPass.Text = "";
            txt_phNum.Text = "";
            txt_emailAdd.Text = "";
            txt_streetNum.Text = "";
            txt_streetName.Text = "";
            txt_Age.Text = "";
            chk_Agreement.Checked = false;
            radb_Female.Checked = false;
            radb_Male.Checked = false;
            radb_O.Checked = false;
            radb_TypeA.Checked = false;
            radb_TypeAB.Checked = false;
            radb_TypeB.Checked = false;
        }

        public string genderSelect()
        {
            string temp = "";

            if (radb_Male.Checked == true)
                temp = "Male";
            if (radb_Female.Checked == true)
                temp = "Female";

            return temp;
        }

        public string bloodGroup()
        {
            string temp = "";

            if (radb_TypeA.Checked == true)
                temp = "A";
            if (radb_TypeB.Checked == true)
                temp = "B";
            if (radb_TypeAB.Checked == true)
                temp = "AB";
            if (radb_O.Checked == true)
                temp = "O";

            return temp;
        }

        public string fullAddress()
        {
            string temp = "";

            temp = txt_streetNum.Text.ToString() + " " + txt_streetName.Text.ToString();

            return temp;
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

        private void txt_streetNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_phNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
