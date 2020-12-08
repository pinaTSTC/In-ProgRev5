﻿using System;
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

// needed for email to work
using System.Net.Mail;

// for printing I guess
using System.Drawing.Printing;

namespace Design_Document_Mock_Up
{
    public partial class frmAdminForm : Form
    {
        private string connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private string sql = null;
        Boolean selectDonor = false;
        Boolean selectWorker = false;
        public frmAdminForm()
        {
            InitializeComponent();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            //adjusts the datagridview to the proper usage
            dgv_donorTable.AllowUserToAddRows = false;
            dgv_donorTable.AllowUserToDeleteRows = false;
            dgv_donorTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_donorTable.MultiSelect = false;
            dgv_donorTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_workerTable.AllowUserToAddRows = false;
            dgv_workerTable.AllowUserToDeleteRows = false;
            dgv_workerTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_workerTable.MultiSelect = false;
            dgv_workerTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //remove all customer data when returning to form main

            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            // Create a data adapter  
            // WORKERS
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM test_table" +
                " WHERE IsWorker = 'Y'", cnn);
            // Create DataSet, fill it and view in data grid  
            DataSet ds = new DataSet("test_table");
            da.Fill(ds, "test_table");
            dgv_workerTable.DataSource = ds.Tables["test_table"].DefaultView;

            // DONORS
            SqlDataAdapter dd = new SqlDataAdapter("SELECT * FROM test_table" +
                " WHERE IsDonor = 'Y'", cnn);
            // Create DataSet, fill it and view in data grid  
            DataSet dsd = new DataSet("test_table");
            dd.Fill(dsd, "test_table");
            dgv_donorTable.DataSource = dsd.Tables["test_table"].DefaultView;

            
        }

        private void btn_createAcc_Click(object sender, EventArgs e)
        {
            //Opening CreateAdmin Form 
            frmCreateAdmin frmCreateAdmin = new frmCreateAdmin();
            //Hides this form
            this.Hide();
            //Opens CreateAdmin Form
            frmCreateAdmin.ShowDialog();
            //Opens THIS form when CreateAdmin closes
            this.Show();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            //Closes the form when RETURN button is clicked
            this.Hide();
        }

        private void btn_sendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dgv_donorTable.CurrentCell.RowIndex;
                string isDonor = dgv_donorTable.Rows[selectedIndex].Cells["IsDonor"].Value.ToString();
                if (selectedIndex > -1 && isDonor == "Y")
                {
                    string rowNum = dgv_donorTable.Rows[selectedIndex].Cells["Number"].Value.ToString();
                    string AppmntDay = dgv_donorTable.Rows[selectedIndex].Cells["AppmntDayWeek"].Value.ToString();
                    string AppmntDateNum = dgv_donorTable.Rows[selectedIndex].Cells["AppmntDateNum"].Value.ToString();
                    string AppmntTime = dgv_donorTable.Rows[selectedIndex].Cells["AppmntTimeDay"].Value.ToString();
                    string emailAdd = dgv_donorTable.Rows[selectedIndex].Cells["EmailAddress"].Value.ToString();
                    dgv_donorTable.Rows.RemoveAt(selectedIndex);
                    dgv_donorTable.Refresh();

                    // ADD SQL STUFF 
                    cnn = new SqlConnection(connectionString);
                    /// Open the connection  
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                    connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                    cnn.ConnectionString = connectionString;
                    cnn.Open();

                    string mailmessage = AppmntDay + " the " + AppmntDateNum + " in the " + AppmntTime;

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("testinganappffs@gmail.com");
                    mail.To.Add(emailAdd);
                    mail.Subject = "Appointment Reminder";
                    mail.Body = "You have an appointment on " + mailmessage;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("testinganappffs", "changeafterfinal");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("Appointment Reminder Sent!");
                }
                else
                {
                    MessageBox.Show("This is not a donor!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_reportPrint_Click(object sender, EventArgs e)
        {
            prnt_Report.Print();
        }

        private void prnt_Report_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgv_donorTable.Width, this.dgv_donorTable.Height);



            dgv_donorTable.DrawToBitmap(bm, new Rectangle(0, 0, this.dgv_donorTable.Width, this.dgv_donorTable.Height));

            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectWorker == true)
                {
                    int selectedIndex = dgv_donorTable.CurrentCell.RowIndex;
                    //DataRow row = (dgv_donorTable.SelectedRows[selectedIndex].DataBoundItem as DataRowView).Row;

                    if (selectedIndex > -1)
                    {
                        string rowNum = dgv_donorTable.Rows[selectedIndex].Cells["Number"].Value.ToString();

                        dgv_donorTable.Rows.RemoveAt(selectedIndex);
                        dgv_donorTable.Refresh();

                        // ADD SQL STUFF 
                        cnn = new SqlConnection(connectionString);
                        /// Open the connection  
                        if (cnn.State == ConnectionState.Open)
                            cnn.Close();
                        connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                        cnn.ConnectionString = connectionString;
                        cnn.Open();

                        sql = "DELETE FROM test_table WHERE id = " + rowNum + "";

                        ExecuteSQLStmt(sql);
                    }
                }
                
                if (selectDonor == true)
                {
                    int selectedIndex = dgv_workerTable.CurrentCell.RowIndex;
                    //DataRow row = (dgv_donorTable.SelectedRows[selectedIndex].DataBoundItem as DataRowView).Row;

                    if (selectedIndex > -1)
                    {
                        string rowNum = dgv_workerTable.Rows[selectedIndex].Cells["Number"].Value.ToString();

                        dgv_workerTable.Rows.RemoveAt(selectedIndex);
                        dgv_workerTable.Refresh();

                        // ADD SQL STUFF 
                        cnn = new SqlConnection(connectionString);
                        /// Open the connection  
                        if (cnn.State == ConnectionState.Open)
                            cnn.Close();
                        connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                        cnn.ConnectionString = connectionString;
                        cnn.Open();

                        sql = "DELETE FROM test_table WHERE id = " + rowNum + "";

                        ExecuteSQLStmt(sql);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void dgv_donorTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectDonor = true;
            selectWorker = false;
            
        }

        private void dgv_workerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectDonor = false;
            selectWorker = true;
        }
    }
}
