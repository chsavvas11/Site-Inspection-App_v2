
namespace App
{
    partial class InspectionMenu
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
            this.newInspection = new System.Windows.Forms.Button();
            this.viewInspections = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newInspection
            // 
            this.newInspection.Location = new System.Drawing.Point(146, 191);
            this.newInspection.Name = "newInspection";
            this.newInspection.Size = new System.Drawing.Size(124, 47);
            this.newInspection.TabIndex = 0;
            this.newInspection.Text = "New Inspection";
            this.newInspection.UseVisualStyleBackColor = true;
            this.newInspection.Click += new System.EventHandler(this.newInspection_Click);
            // 
            // viewInspections
            // 
            this.viewInspections.Location = new System.Drawing.Point(367, 191);
            this.viewInspections.Name = "viewInspections";
            this.viewInspections.Size = new System.Drawing.Size(127, 47);
            this.viewInspections.TabIndex = 1;
            this.viewInspections.Text = "View Inspections";
            this.viewInspections.UseVisualStyleBackColor = true;
            this.viewInspections.Click += new System.EventHandler(this.viewInspections_Click);
            // 
            // InspectionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewInspections);
            this.Controls.Add(this.newInspection);
            this.Name = "InspectionMenu";
            this.Size = new System.Drawing.Size(656, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newInspection;
        private System.Windows.Forms.Button viewInspections;
    }
}
