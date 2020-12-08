namespace Design_Document_Mock_Up
{
    partial class frmDonorPage
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.grp_calendar = new System.Windows.Forms.GroupBox();
            this.dgv_Calendar = new System.Windows.Forms.DataGridView();
            this.lbl_donorNum = new System.Windows.Forms.Label();
            this.lbl_listings = new System.Windows.Forms.Label();
            this.grp_timeofDay = new System.Windows.Forms.GroupBox();
            this.radb_Evening = new System.Windows.Forms.RadioButton();
            this.radb_Afternoon = new System.Windows.Forms.RadioButton();
            this.radb_Morning = new System.Windows.Forms.RadioButton();
            this.grp_hourSelect = new System.Windows.Forms.GroupBox();
            this.grp_calendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Calendar)).BeginInit();
            this.grp_timeofDay.SuspendLayout();
            this.grp_hourSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(781, 224);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(247, 152);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.Location = new System.Drawing.Point(781, 44);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(247, 152);
            this.btn_Confirm.TabIndex = 4;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // grp_calendar
            // 
            this.grp_calendar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_calendar.Controls.Add(this.dgv_Calendar);
            this.grp_calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_calendar.Location = new System.Drawing.Point(12, 12);
            this.grp_calendar.Name = "grp_calendar";
            this.grp_calendar.Size = new System.Drawing.Size(763, 249);
            this.grp_calendar.TabIndex = 3;
            this.grp_calendar.TabStop = false;
            this.grp_calendar.Text = "This Month\'s Schedule";
            // 
            // dgv_Calendar
            // 
            this.dgv_Calendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Calendar.Location = new System.Drawing.Point(7, 32);
            this.dgv_Calendar.Name = "dgv_Calendar";
            this.dgv_Calendar.Size = new System.Drawing.Size(750, 191);
            this.dgv_Calendar.TabIndex = 0;
            // 
            // lbl_donorNum
            // 
            this.lbl_donorNum.AutoSize = true;
            this.lbl_donorNum.Location = new System.Drawing.Point(831, 397);
            this.lbl_donorNum.Name = "lbl_donorNum";
            this.lbl_donorNum.Size = new System.Drawing.Size(155, 13);
            this.lbl_donorNum.TabIndex = 6;
            this.lbl_donorNum.Text = "This label will change if it works";
            // 
            // lbl_listings
            // 
            this.lbl_listings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_listings.Location = new System.Drawing.Point(6, 45);
            this.lbl_listings.Name = "lbl_listings";
            this.lbl_listings.Size = new System.Drawing.Size(263, 98);
            this.lbl_listings.TabIndex = 10;
            this.lbl_listings.Text = "CLOSED SUNDAY ON EVENINGS";
            // 
            // grp_timeofDay
            // 
            this.grp_timeofDay.Controls.Add(this.radb_Evening);
            this.grp_timeofDay.Controls.Add(this.radb_Afternoon);
            this.grp_timeofDay.Controls.Add(this.radb_Morning);
            this.grp_timeofDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_timeofDay.Location = new System.Drawing.Point(19, 267);
            this.grp_timeofDay.Name = "grp_timeofDay";
            this.grp_timeofDay.Size = new System.Drawing.Size(251, 171);
            this.grp_timeofDay.TabIndex = 11;
            this.grp_timeofDay.TabStop = false;
            this.grp_timeofDay.Text = "Select Time of Day";
            // 
            // radb_Evening
            // 
            this.radb_Evening.AutoSize = true;
            this.radb_Evening.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radb_Evening.Location = new System.Drawing.Point(34, 115);
            this.radb_Evening.Name = "radb_Evening";
            this.radb_Evening.Size = new System.Drawing.Size(98, 28);
            this.radb_Evening.TabIndex = 2;
            this.radb_Evening.TabStop = true;
            this.radb_Evening.Text = "Evening";
            this.radb_Evening.UseVisualStyleBackColor = true;
            this.radb_Evening.CheckedChanged += new System.EventHandler(this.radb_Evening_CheckedChanged);
            // 
            // radb_Afternoon
            // 
            this.radb_Afternoon.AutoSize = true;
            this.radb_Afternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radb_Afternoon.Location = new System.Drawing.Point(34, 81);
            this.radb_Afternoon.Name = "radb_Afternoon";
            this.radb_Afternoon.Size = new System.Drawing.Size(110, 28);
            this.radb_Afternoon.TabIndex = 1;
            this.radb_Afternoon.TabStop = true;
            this.radb_Afternoon.Text = "Afternoon";
            this.radb_Afternoon.UseVisualStyleBackColor = true;
            this.radb_Afternoon.CheckedChanged += new System.EventHandler(this.radb_Afternoon_CheckedChanged);
            // 
            // radb_Morning
            // 
            this.radb_Morning.AutoSize = true;
            this.radb_Morning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radb_Morning.Location = new System.Drawing.Point(34, 45);
            this.radb_Morning.Name = "radb_Morning";
            this.radb_Morning.Size = new System.Drawing.Size(98, 28);
            this.radb_Morning.TabIndex = 0;
            this.radb_Morning.TabStop = true;
            this.radb_Morning.Text = "Morning";
            this.radb_Morning.UseVisualStyleBackColor = true;
            this.radb_Morning.CheckedChanged += new System.EventHandler(this.radb_Morning_CheckedChanged);
            // 
            // grp_hourSelect
            // 
            this.grp_hourSelect.Controls.Add(this.lbl_listings);
            this.grp_hourSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_hourSelect.Location = new System.Drawing.Point(293, 267);
            this.grp_hourSelect.Name = "grp_hourSelect";
            this.grp_hourSelect.Size = new System.Drawing.Size(275, 171);
            this.grp_hourSelect.TabIndex = 12;
            this.grp_hourSelect.TabStop = false;
            this.grp_hourSelect.Text = "Walk-in Anytime!";
            // 
            // frmDonorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.grp_hourSelect);
            this.Controls.Add(this.grp_timeofDay);
            this.Controls.Add(this.lbl_donorNum);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.grp_calendar);
            this.Name = "frmDonorPage";
            this.Text = "frmDonorPage";
            this.Load += new System.EventHandler(this.frmDonorPage_Load);
            this.grp_calendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Calendar)).EndInit();
            this.grp_timeofDay.ResumeLayout(false);
            this.grp_timeofDay.PerformLayout();
            this.grp_hourSelect.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.GroupBox grp_calendar;
        private System.Windows.Forms.Label lbl_donorNum;
        private System.Windows.Forms.Label lbl_listings;
        private System.Windows.Forms.DataGridView dgv_Calendar;
        private System.Windows.Forms.GroupBox grp_timeofDay;
        private System.Windows.Forms.RadioButton radb_Evening;
        private System.Windows.Forms.RadioButton radb_Afternoon;
        private System.Windows.Forms.RadioButton radb_Morning;
        private System.Windows.Forms.GroupBox grp_hourSelect;
    }
}