
namespace App
{
    partial class InspectorDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newInspectionButton = new System.Windows.Forms.Button();
            this.viewInspectionsButton = new System.Windows.Forms.Button();
            this.inspectorDashboardLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newInspectionButton
            // 
            this.newInspectionButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newInspectionButton.Location = new System.Drawing.Point(69, 192);
            this.newInspectionButton.Name = "newInspectionButton";
            this.newInspectionButton.Size = new System.Drawing.Size(211, 55);
            this.newInspectionButton.TabIndex = 0;
            this.newInspectionButton.Text = "New Inspection";
            this.newInspectionButton.UseVisualStyleBackColor = true;
            this.newInspectionButton.Click += new System.EventHandler(this.newInspectionButton_Click);
            // 
            // viewInspectionsButton
            // 
            this.viewInspectionsButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInspectionsButton.Location = new System.Drawing.Point(360, 192);
            this.viewInspectionsButton.Name = "viewInspectionsButton";
            this.viewInspectionsButton.Size = new System.Drawing.Size(214, 55);
            this.viewInspectionsButton.TabIndex = 1;
            this.viewInspectionsButton.Text = "View Inspections";
            this.viewInspectionsButton.UseVisualStyleBackColor = true;
            // 
            // inspectorDashboardLabel
            // 
            this.inspectorDashboardLabel.AutoSize = true;
            this.inspectorDashboardLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inspectorDashboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.inspectorDashboardLabel.Location = new System.Drawing.Point(121, 55);
            this.inspectorDashboardLabel.Name = "inspectorDashboardLabel";
            this.inspectorDashboardLabel.Size = new System.Drawing.Size(387, 38);
            this.inspectorDashboardLabel.TabIndex = 2;
            this.inspectorDashboardLabel.Text = "INSPECTOR DASHBOARD";
            // 
            // InspectorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inspectorDashboardLabel);
            this.Controls.Add(this.viewInspectionsButton);
            this.Controls.Add(this.newInspectionButton);
            this.Name = "InspectorDashboard";
            this.Size = new System.Drawing.Size(656, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newInspectionButton;
        private System.Windows.Forms.Button viewInspectionsButton;
        private System.Windows.Forms.Label inspectorDashboardLabel;
    }
}
