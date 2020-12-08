namespace Design_Document_Mock_Up
{
    partial class frmDonorSplash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_appmntSched = new System.Windows.Forms.Button();
            this.btn_sendReminder = new System.Windows.Forms.Button();
            this.btn_UpdateCredentials = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_changePic = new System.Windows.Forms.Button();
            this.btn_WindowScheme = new System.Windows.Forms.Button();
            this.pct_Image = new System.Windows.Forms.PictureBox();
            this.prnt_Reminder = new System.Drawing.Printing.PrintDocument();
            this.btn_printReminder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_appmntSched
            // 
            this.btn_appmntSched.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_appmntSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appmntSched.Location = new System.Drawing.Point(12, 12);
            this.btn_appmntSched.Name = "btn_appmntSched";
            this.btn_appmntSched.Size = new System.Drawing.Size(217, 114);
            this.btn_appmntSched.TabIndex = 6;
            this.btn_appmntSched.Text = "Schedule Appointment";
            this.btn_appmntSched.UseVisualStyleBackColor = false;
            this.btn_appmntSched.Click += new System.EventHandler(this.btn_appmntSched_Click);
            // 
            // btn_sendReminder
            // 
            this.btn_sendReminder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_sendReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendReminder.Location = new System.Drawing.Point(235, 12);
            this.btn_sendReminder.Name = "btn_sendReminder";
            this.btn_sendReminder.Size = new System.Drawing.Size(217, 114);
            this.btn_sendReminder.TabIndex = 7;
            this.btn_sendReminder.Text = "Send Appointment Reminder";
            this.btn_sendReminder.UseVisualStyleBackColor = false;
            this.btn_sendReminder.Click += new System.EventHandler(this.btn_sendReminder_Click);
            // 
            // btn_UpdateCredentials
            // 
            this.btn_UpdateCredentials.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_UpdateCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateCredentials.Location = new System.Drawing.Point(12, 132);
            this.btn_UpdateCredentials.Name = "btn_UpdateCredentials";
            this.btn_UpdateCredentials.Size = new System.Drawing.Size(217, 114);
            this.btn_UpdateCredentials.TabIndex = 8;
            this.btn_UpdateCredentials.Text = "Update Credentials";
            this.btn_UpdateCredentials.UseVisualStyleBackColor = false;
            this.btn_UpdateCredentials.Click += new System.EventHandler(this.btn_UpdateCredentials_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(571, 324);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(217, 114);
            this.btn_Logout.TabIndex = 9;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_changePic
            // 
            this.btn_changePic.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_changePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changePic.Location = new System.Drawing.Point(12, 252);
            this.btn_changePic.Name = "btn_changePic";
            this.btn_changePic.Size = new System.Drawing.Size(217, 114);
            this.btn_changePic.TabIndex = 11;
            this.btn_changePic.Text = "Change Profile Picture";
            this.btn_changePic.UseVisualStyleBackColor = false;
            this.btn_changePic.Click += new System.EventHandler(this.btn_changePic_Click);
            // 
            // btn_WindowScheme
            // 
            this.btn_WindowScheme.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_WindowScheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WindowScheme.Location = new System.Drawing.Point(235, 252);
            this.btn_WindowScheme.Name = "btn_WindowScheme";
            this.btn_WindowScheme.Size = new System.Drawing.Size(217, 114);
            this.btn_WindowScheme.TabIndex = 12;
            this.btn_WindowScheme.Text = "Change Window Scheme";
            this.btn_WindowScheme.UseVisualStyleBackColor = false;
            this.btn_WindowScheme.Click += new System.EventHandler(this.btn_WindowScheme_Click);
            // 
            // pct_Image
            // 
            this.pct_Image.Image = global::Design_Document_Mock_Up.Properties.Resources.defaultpic;
            this.pct_Image.Location = new System.Drawing.Point(571, 12);
            this.pct_Image.Name = "pct_Image";
            this.pct_Image.Size = new System.Drawing.Size(217, 164);
            this.pct_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_Image.TabIndex = 13;
            this.pct_Image.TabStop = false;
            // 
            // prnt_Reminder
            // 
            this.prnt_Reminder.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prnt_Reminder_PrintPage);
            // 
            // btn_printReminder
            // 
            this.btn_printReminder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_printReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printReminder.Location = new System.Drawing.Point(235, 132);
            this.btn_printReminder.Name = "btn_printReminder";
            this.btn_printReminder.Size = new System.Drawing.Size(217, 114);
            this.btn_printReminder.TabIndex = 14;
            this.btn_printReminder.Text = "Print Appointment Reminder";
            this.btn_printReminder.UseVisualStyleBackColor = false;
            this.btn_printReminder.Click += new System.EventHandler(this.btn_printReminder_Click);
            // 
            // frmDonorSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_printReminder);
            this.Controls.Add(this.pct_Image);
            this.Controls.Add(this.btn_WindowScheme);
            this.Controls.Add(this.btn_changePic);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_UpdateCredentials);
            this.Controls.Add(this.btn_sendReminder);
            this.Controls.Add(this.btn_appmntSched);
            this.Name = "frmDonorSplash";
            this.Text = "frmDonorSplash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDonorSplash_FormClosing);
            this.Load += new System.EventHandler(this.frmDonorSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_appmntSched;
        private System.Windows.Forms.Button btn_sendReminder;
        private System.Windows.Forms.Button btn_UpdateCredentials;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_changePic;
        private System.Windows.Forms.Button btn_WindowScheme;
        private System.Windows.Forms.PictureBox pct_Image;
        private System.Drawing.Printing.PrintDocument prnt_Reminder;
        private System.Windows.Forms.Button btn_printReminder;
    }
}