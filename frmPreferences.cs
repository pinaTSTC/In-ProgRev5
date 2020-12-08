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
    public partial class frmPreferences : Form
    {
        private string connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private string sql = null;

        public frmPreferences()
        {
            InitializeComponent();
            
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            //Opening AddDonor Form 
            frmDonorSplash frmDonorSplash = new frmDonorSplash();
            //Hides this form
            this.Hide();
            //Opens AddDonor Form
            frmDonorSplash.ShowDialog();
            //Opens THIS form when CreateWorker closes
            this.Show();
        }

        private void frmPreferences_Load(object sender, EventArgs e)
        {
            //radio "SMALL" button is checked by default
            radb_sansSerif.Checked = true;
            radb_Classic.Checked = true;
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

        private int pickFont()
        {
            int sFont = 0;

            if (radb_sansSerif.Checked == true)
                sFont = 1;
            if (radb_Calibri.Checked == true)
                sFont = 2;
            if (radb_comicSans.Checked == true)
                sFont = 3;

            return sFont;
        }

        private int pickScheme()
        {
            int sScheme = 0;

            if (radb_Classic.Checked == true)
                sScheme = 1;
            if (radb_Bright.Checked == true)
                sScheme = 2;
            if (radb_Dark.Checked == true)
                sScheme = 3;

            return sScheme;
        }

        private void btn_SavenExit_Click(object sender, EventArgs e) 
        {
            int selectFont = pickFont();
            int selectScheme = pickScheme();

            string num = frmMain.donorNum[0].donorNumber;
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            string sql = "UPDATE test_table SET Font = '" + selectFont.ToString() + 
                "', Scheme = '" + selectScheme.ToString() + 
                "' WHERE Number = '" + num + "'";

            ExecuteSQLStmt(sql);
        }

    }
}
