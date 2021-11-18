
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
            this.workingStandardsSelection = new System.Windows.Forms.Button();
            this.qualitySelection = new System.Windows.Forms.Button();
            this.siteRulesSelection = new System.Windows.Forms.Button();
            this.environmentalSelection = new System.Windows.Forms.Button();
            this.POISelection = new System.Windows.Forms.Button();
            this.TCOESelection = new System.Windows.Forms.Button();
            this.miscellaneousSelection = new System.Windows.Forms.Button();
            this.CompleteInspectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workingStandardsSelection
            // 
            this.workingStandardsSelection.Location = new System.Drawing.Point(70, 110);
            this.workingStandardsSelection.Margin = new System.Windows.Forms.Padding(2);
            this.workingStandardsSelection.Name = "workingStandardsSelection";
            this.workingStandardsSelection.Size = new System.Drawing.Size(82, 50);
            this.workingStandardsSelection.TabIndex = 1;
            this.workingStandardsSelection.Text = "Working Standards";
            this.workingStandardsSelection.UseVisualStyleBackColor = true;
            this.workingStandardsSelection.Click += new System.EventHandler(this.workingStandardsSelection_Click);
            // 
            // qualitySelection
            // 
            this.qualitySelection.Location = new System.Drawing.Point(222, 111);
            this.qualitySelection.Margin = new System.Windows.Forms.Padding(2);
            this.qualitySelection.Name = "qualitySelection";
            this.qualitySelection.Size = new System.Drawing.Size(98, 37);
            this.qualitySelection.TabIndex = 2;
            this.qualitySelection.Text = "Qaulity";
            this.qualitySelection.UseVisualStyleBackColor = true;
            this.qualitySelection.Click += new System.EventHandler(this.qualitySelection_Click);
            // 
            // siteRulesSelection
            // 
            this.siteRulesSelection.Location = new System.Drawing.Point(400, 110);
            this.siteRulesSelection.Margin = new System.Windows.Forms.Padding(2);
            this.siteRulesSelection.Name = "siteRulesSelection";
            this.siteRulesSelection.Size = new System.Drawing.Size(99, 39);
            this.siteRulesSelection.TabIndex = 3;
            this.siteRulesSelection.Text = "Site Rules";
            this.siteRulesSelection.UseVisualStyleBackColor = true;
            this.siteRulesSelection.Click += new System.EventHandler(this.siteRulesSelection_Click);
            // 
            // environmentalSelection
            // 
            this.environmentalSelection.Location = new System.Drawing.Point(70, 196);
            this.environmentalSelection.Margin = new System.Windows.Forms.Padding(2);
            this.environmentalSelection.Name = "environmentalSelection";
            this.environmentalSelection.Size = new System.Drawing.Size(87, 40);
            this.environmentalSelection.TabIndex = 4;
            this.environmentalSelection.Text = "Environmental";
            this.environmentalSelection.UseVisualStyleBackColor = true;
            this.environmentalSelection.Click += new System.EventHandler(this.environmentalSelection_Click);
            // 
            // POISelection
            // 
            this.POISelection.Location = new System.Drawing.Point(222, 196);
            this.POISelection.Margin = new System.Windows.Forms.Padding(2);
            this.POISelection.Name = "POISelection";
            this.POISelection.Size = new System.Drawing.Size(98, 40);
            this.POISelection.TabIndex = 5;
            this.POISelection.Text = "Protection Of Individuals";
            this.POISelection.UseVisualStyleBackColor = true;
            this.POISelection.Click += new System.EventHandler(this.POISelection_Click);
            // 
            // TCOESelection
            // 
            this.TCOESelection.Location = new System.Drawing.Point(440, 187);
            this.TCOESelection.Margin = new System.Windows.Forms.Padding(2);
            this.TCOESelection.Name = "TCOESelection";
            this.TCOESelection.Size = new System.Drawing.Size(136, 58);
            this.TCOESelection.TabIndex = 6;
            this.TCOESelection.Text = "Tools, Cables and Other Equipment";
            this.TCOESelection.UseVisualStyleBackColor = true;
            this.TCOESelection.Click += new System.EventHandler(this.TCOESelection_Click);
            // 
            // miscellaneousSelection
            // 
            this.miscellaneousSelection.Location = new System.Drawing.Point(216, 313);
            this.miscellaneousSelection.Margin = new System.Windows.Forms.Padding(2);
            this.miscellaneousSelection.Name = "miscellaneousSelection";
            this.miscellaneousSelection.Size = new System.Drawing.Size(104, 42);
            this.miscellaneousSelection.TabIndex = 7;
            this.miscellaneousSelection.Text = "Miscellaneous";
            this.miscellaneousSelection.UseVisualStyleBackColor = true;
            this.miscellaneousSelection.Click += new System.EventHandler(this.miscellaneousSelection_Click);
            // 
            // CompleteInspectionButton
            // 
            this.CompleteInspectionButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CompleteInspectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteInspectionButton.Location = new System.Drawing.Point(457, 369);
            this.CompleteInspectionButton.Name = "CompleteInspectionButton";
            this.CompleteInspectionButton.Size = new System.Drawing.Size(141, 49);
            this.CompleteInspectionButton.TabIndex = 8;
            this.CompleteInspectionButton.Text = "Complete Inspection";
            this.CompleteInspectionButton.UseVisualStyleBackColor = false;
            this.CompleteInspectionButton.Click += new System.EventHandler(this.CompleteInspectionButton_Click);
            // 
            // InspectionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CompleteInspectionButton);
            this.Controls.Add(this.miscellaneousSelection);
            this.Controls.Add(this.TCOESelection);
            this.Controls.Add(this.POISelection);
            this.Controls.Add(this.environmentalSelection);
            this.Controls.Add(this.siteRulesSelection);
            this.Controls.Add(this.qualitySelection);
            this.Controls.Add(this.workingStandardsSelection);
            this.Name = "InspectionMenu";
            this.Size = new System.Drawing.Size(656, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button workingStandardsSelection;
        private System.Windows.Forms.Button qualitySelection;
        private System.Windows.Forms.Button siteRulesSelection;
        private System.Windows.Forms.Button environmentalSelection;
        private System.Windows.Forms.Button POISelection;
        private System.Windows.Forms.Button TCOESelection;
        private System.Windows.Forms.Button miscellaneousSelection;
        private System.Windows.Forms.Button CompleteInspectionButton;
    }
}
