namespace WindowsFormsApp1
{
    partial class EmployeePortal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panelEmployeeInfo = new System.Windows.Forms.Panel();
            this.lblEmployeeInfo = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOfficeCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReportsTo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelRecentOrders = new System.Windows.Forms.Panel();
            this.lblRecentOrders = new System.Windows.Forms.Label();
            this.dgvRecentOrders = new System.Windows.Forms.DataGridView();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            this.panelEmployeeInfo.SuspendLayout();
            this.panelRecentOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Controls.Add(this.lblDateTime);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 75);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(20, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(207, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, [User]";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDateTime.Location = new System.Drawing.Point(22, 47);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(92, 20);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "[DateTime]";
            // 
            // panelEmployeeInfo
            // 
            this.panelEmployeeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEmployeeInfo.Controls.Add(this.lblEmployeeInfo);
            this.panelEmployeeInfo.Controls.Add(this.lblJobTitle);
            this.panelEmployeeInfo.Controls.Add(this.label2);
            this.panelEmployeeInfo.Controls.Add(this.lblOfficeCode);
            this.panelEmployeeInfo.Controls.Add(this.label4);
            this.panelEmployeeInfo.Controls.Add(this.lblReportsTo);
            this.panelEmployeeInfo.Controls.Add(this.label6);
            this.panelEmployeeInfo.Location = new System.Drawing.Point(20, 94);
            this.panelEmployeeInfo.Name = "panelEmployeeInfo";
            this.panelEmployeeInfo.Size = new System.Drawing.Size(300, 169);
            this.panelEmployeeInfo.TabIndex = 1;
            // 
            // lblEmployeeInfo
            // 
            this.lblEmployeeInfo.AutoSize = true;
            this.lblEmployeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeInfo.Location = new System.Drawing.Point(10, 9);
            this.lblEmployeeInfo.Name = "lblEmployeeInfo";
            this.lblEmployeeInfo.Size = new System.Drawing.Size(133, 20);
            this.lblEmployeeInfo.TabIndex = 0;
            this.lblEmployeeInfo.Text = "Employee Info:";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(120, 47);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(87, 15);
            this.lblJobTitle.TabIndex = 2;
            this.lblJobTitle.Text = "[JobTitle]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Job Title:";
            // 
            // lblOfficeCode
            // 
            this.lblOfficeCode.AutoSize = true;
            this.lblOfficeCode.Location = new System.Drawing.Point(120, 75);
            this.lblOfficeCode.Name = "lblOfficeCode";
            this.lblOfficeCode.Size = new System.Drawing.Size(103, 15);
            this.lblOfficeCode.TabIndex = 4;
            this.lblOfficeCode.Text = "[OfficeCode]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(20, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Office Code:";
            // 
            // lblReportsTo
            // 
            this.lblReportsTo.AutoSize = true;
            this.lblReportsTo.Location = new System.Drawing.Point(120, 103);
            this.lblReportsTo.Name = "lblReportsTo";
            this.lblReportsTo.Size = new System.Drawing.Size(95, 15);
            this.lblReportsTo.TabIndex = 6;
            this.lblReportsTo.Text = "[ReportsTo]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(20, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Reports To:";
            // 
            // panelRecentOrders
            // 
            this.panelRecentOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecentOrders.Controls.Add(this.lblRecentOrders);
            this.panelRecentOrders.Controls.Add(this.dgvRecentOrders);
            this.panelRecentOrders.Location = new System.Drawing.Point(340, 94);
            this.panelRecentOrders.Name = "panelRecentOrders";
            this.panelRecentOrders.Size = new System.Drawing.Size(540, 281);
            this.panelRecentOrders.TabIndex = 2;
            // 
            // lblRecentOrders
            // 
            this.lblRecentOrders.AutoSize = true;
            this.lblRecentOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblRecentOrders.Location = new System.Drawing.Point(10, 9);
            this.lblRecentOrders.Name = "lblRecentOrders";
            this.lblRecentOrders.Size = new System.Drawing.Size(138, 20);
            this.lblRecentOrders.TabIndex = 1;
            this.lblRecentOrders.Text = "Recent Orders:";
            // 
            // dgvRecentOrders
            // 
            this.dgvRecentOrders.AllowUserToAddRows = false;
            this.dgvRecentOrders.AllowUserToDeleteRows = false;
            this.dgvRecentOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentOrders.Location = new System.Drawing.Point(10, 38);
            this.dgvRecentOrders.Name = "dgvRecentOrders";
            this.dgvRecentOrders.ReadOnly = true;
            this.dgvRecentOrders.RowHeadersWidth = 51;
            this.dgvRecentOrders.RowTemplate.Height = 24;
            this.dgvRecentOrders.Size = new System.Drawing.Size(520, 234);
            this.dgvRecentOrders.TabIndex = 0;
            this.dgvRecentOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentOrders_CellContentClick);
            // 
            // panelActions
            // 
            this.panelActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActions.Controls.Add(this.btnLogout);
            this.panelActions.Controls.Add(this.btnUpdateProfile);
            this.panelActions.Controls.Add(this.btnViewOrders);
            this.panelActions.Controls.Add(this.btnViewCustomers);
            this.panelActions.Location = new System.Drawing.Point(20, 281);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(300, 94);
            this.panelActions.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightCoral;
            this.btnLogout.Location = new System.Drawing.Point(150, 47);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 28);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateProfile.Location = new System.Drawing.Point(20, 47);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(120, 28);
            this.btnUpdateProfile.TabIndex = 2;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.LightGreen;
            this.btnViewOrders.Location = new System.Drawing.Point(150, 9);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(120, 28);
            this.btnViewOrders.TabIndex = 1;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.BackColor = System.Drawing.Color.LightGreen;
            this.btnViewCustomers.Location = new System.Drawing.Point(20, 9);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(120, 28);
            this.btnViewCustomers.TabIndex = 0;
            this.btnViewCustomers.Text = "View Customers";
            this.btnViewCustomers.UseVisualStyleBackColor = false;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // EmployeePortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 394);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelRecentOrders);
            this.Controls.Add(this.panelEmployeeInfo);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EmployeePortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Dashboard";
            this.Load += new System.EventHandler(this.EmployeePortal_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelEmployeeInfo.ResumeLayout(false);
            this.panelEmployeeInfo.PerformLayout();
            this.panelRecentOrders.ResumeLayout(false);
            this.panelRecentOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel panelEmployeeInfo;
        private System.Windows.Forms.Label lblEmployeeInfo;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOfficeCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblReportsTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelRecentOrders;
        private System.Windows.Forms.Label lblRecentOrders;
        private System.Windows.Forms.DataGridView dgvRecentOrders;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.Timer timerDateTime;
    }
}
