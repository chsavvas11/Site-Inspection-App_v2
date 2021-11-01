
namespace App
{
    partial class Container
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
            this.SidePanel = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.InspectorDashboard = new App.InspectorDashboard();
            this.InspectionsList = new App.InspectionsList();
            this.InspectionOverview = new App.InspectionOverview();
            this.InspectionMenu = new App.InspectionMenu();
            this.InspectionInformation = new App.InspectionInformation();
            this.InspectionDetails = new App.InspectionDetails();
            this.InspectionCategory = new App.InspectionCategory();
            this.AdminDashboard = new App.AdminDashboard();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.CanvasPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SidePanel.Controls.Add(this.LogOutButton);
            this.SidePanel.Controls.Add(this.DashboardButton);
            this.SidePanel.Controls.Add(this.UsernameLabel);
            this.SidePanel.Controls.Add(this.UserPictureBox);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(144, 450);
            this.SidePanel.TabIndex = 0;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(30, 398);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(85, 23);
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.Location = new System.Drawing.Point(30, 359);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(85, 23);
            this.DashboardButton.TabIndex = 2;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(37, 88);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Image = global::App.Properties.Resources.icons8_user_64px;
            this.UserPictureBox.Location = new System.Drawing.Point(40, 12);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(63, 62);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPictureBox.TabIndex = 0;
            this.UserPictureBox.TabStop = false;
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Controls.Add(this.InspectorDashboard);
            this.CanvasPanel.Controls.Add(this.InspectionsList);
            this.CanvasPanel.Controls.Add(this.InspectionOverview);
            this.CanvasPanel.Controls.Add(this.InspectionMenu);
            this.CanvasPanel.Controls.Add(this.InspectionInformation);
            this.CanvasPanel.Controls.Add(this.InspectionDetails);
            this.CanvasPanel.Controls.Add(this.InspectionCategory);
            this.CanvasPanel.Controls.Add(this.AdminDashboard);
            this.CanvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CanvasPanel.Location = new System.Drawing.Point(144, 0);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(656, 450);
            this.CanvasPanel.TabIndex = 1;
            // 
            // InspectorDashboard
            // 
            this.InspectorDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InspectorDashboard.Location = new System.Drawing.Point(0, 0);
            this.InspectorDashboard.Name = "InspectorDashboard";
            this.InspectorDashboard.Size = new System.Drawing.Size(656, 450);
            this.InspectorDashboard.TabIndex = 7;
            this.InspectorDashboard.Visible = false;
            // 
            // InspectionsList
            // 
            this.InspectionsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InspectionsList.Location = new System.Drawing.Point(0, 0);
            this.InspectionsList.Name = "InspectionsList";
            this.InspectionsList.Size = new System.Drawing.Size(656, 450);
            this.InspectionsList.TabIndex = 6;
            this.InspectionsList.Visible = false;
            // 
            // InspectionOverview
            // 
            this.InspectionOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InspectionOverview.Location = new System.Drawing.Point(0, 0);
            this.InspectionOverview.Name = "InspectionOverview";
            this.InspectionOverview.Size = new System.Drawing.Size(656, 450);
            this.InspectionOverview.TabIndex = 5;
            this.InspectionOverview.Visible = false;
            // 
            // InspectionMenu
            // 
            this.InspectionMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InspectionMenu.Location = new System.Drawing.Point(0, 0);
            this.InspectionMenu.Name = "InspectionMenu";
            this.InspectionMenu.Size = new System.Drawing.Size(656, 450);
            this.InspectionMenu.TabIndex = 4;
            this.InspectionMenu.Visible = false;
            // 
            // InspectionInformation
            // 
            this.InspectionInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InspectionInformation.Location = new System.Drawing.Point(0, 0);
            this.InspectionInformation.Name = "InspectionInformation";
            this.InspectionInformation.Size = new System.Drawing.Size(656, 450);
            this.InspectionInformation.TabIndex = 3;
            this.InspectionInformation.Visible = false;
            // 
            // InspectionDetails
            // 
            this.InspectionDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InspectionDetails.Location = new System.Drawing.Point(0, 0);
            this.InspectionDetails.Name = "InspectionDetails";
            this.InspectionDetails.Size = new System.Drawing.Size(656, 450);
            this.InspectionDetails.TabIndex = 2;
            this.InspectionDetails.Visible = false;
            // 
            // InspectionCategory
            // 
            this.InspectionCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InspectionCategory.Location = new System.Drawing.Point(0, 0);
            this.InspectionCategory.Name = "InspectionCategory";
            this.InspectionCategory.Size = new System.Drawing.Size(656, 450);
            this.InspectionCategory.TabIndex = 1;
            this.InspectionCategory.Visible = false;
            // 
            // AdminDashboard
            // 
            this.AdminDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminDashboard.Location = new System.Drawing.Point(0, 0);
            this.AdminDashboard.Name = "AdminDashboard";
            this.AdminDashboard.Size = new System.Drawing.Size(656, 450);
            this.AdminDashboard.TabIndex = 0;
            this.AdminDashboard.Visible = false;
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.SidePanel);
            this.Name = "Container";
            this.Text = "Site Inspection";
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.CanvasPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel CanvasPanel;
        private AdminDashboard AdminDashboard;
        private InspectionCategory InspectionCategory;
        private InspectionDetails InspectionDetails;
        private InspectionInformation InspectionInformation;
        private InspectionMenu InspectionMenu;
        private InspectionOverview InspectionOverview;
        private InspectionsList InspectionsList;
        private InspectorDashboard InspectorDashboard;
        private System.Windows.Forms.PictureBox UserPictureBox;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Label UsernameLabel;
    }
}

