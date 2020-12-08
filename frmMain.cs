using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Document_Mock_Up
{
    public partial class frmMain : Form
    {
        public static List<donorID> donorNum = new List<donorID>();

        public class donorID
        {
            // will help us process and assign information to the following forms
            public string donorNumber { get; set; }

            //public void setdonorNumber(string num)
            //{
            //    donorNumber = num;
            //}

            public donorID()
            {
                //default constructor
            }

            ////remove all donor data when returning to form main
            //donorID.Clear();
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Opening Preferences Form
            frmPreferences frmPreferences = new frmPreferences();
            //Hides this Form
            this.Hide();
            //Opens PREFERENCES form
            frmPreferences.ShowDialog();
            //Opens THIS form when PREFERENCES closes
            this.Show();
        }

        private void btn_Donor_Click(object sender, EventArgs e)
        {
            //Opening DonorLogin Form
            frmDonorLogin frmDonorLogin = new frmDonorLogin();
            //Hides this form
            this.Hide();
            //Opens DonorLogin Form
            frmDonorLogin.ShowDialog();
            //Opens THIS form when DonorLogin closes
            this.Show();
        }

        private void btn_Worker_Click(object sender, EventArgs e)
        {
            //Opening Workers Form 
            frmWorkLogin frmWorkLogin = new frmWorkLogin();
            //Hides this form
            this.Hide();
            //Opens Workers Form
            frmWorkLogin.ShowDialog();
            //Opens THIS form when Workers closes
            this.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
