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
    public partial class frmProfileImage : Form
    {
        private string connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private string sql = null;
        public frmProfileImage()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private string imageSelect()
        {
            string image = "";

            if (radb_balloon.Checked == true)
                image = "balloon.jpg";
            if (radb_Cactus.Checked == true)
                image = "cactcus.png";
            if (radb_Fire.Checked == true)
                image = "fire.jpg";
            if (radb_Hat.Checked == true)
                image = "hat.png";
            if (radb_Orange.Checked == true)
                image = "orange.png";
            if (radb_Pineapple.Checked == true)
                image = "pineapple.jpg";
            if (radb_strawberry.Checked == true)
                image = "strawberry.png";
            if (radb_Sun.Checked == true)
                image = "sun.jpeg";
            if (radb_Sunflower.Checked == true)
                image = "sunflower.jpg";
            if (radb_Tree.Checked == true)
                image = "tree.png";

            return image;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string choice = imageSelect();
            string num = frmMain.donorNum[0].donorNumber;
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            string sql = "UPDATE test_table SET SetImage = '" + choice + "' " +
                "WHERE Number = '" + num + "'";

            ExecuteSQLStmt(sql);
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
    }
}
