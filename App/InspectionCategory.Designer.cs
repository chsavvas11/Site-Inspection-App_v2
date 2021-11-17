
namespace App
{
    partial class InspectionCategory
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
            this.SuspendLayout();
            // 
            // workingStandardsSelection
            // 
            this.workingStandardsSelection.Location = new System.Drawing.Point(67, 72);
            this.workingStandardsSelection.Name = "workingStandardsSelection";
            this.workingStandardsSelection.Size = new System.Drawing.Size(109, 62);
            this.workingStandardsSelection.TabIndex = 0;
            this.workingStandardsSelection.Text = "Working Standards";
            this.workingStandardsSelection.UseVisualStyleBackColor = true;
            this.workingStandardsSelection.Click += new System.EventHandler(this.workingStandardsSelection_Click);
            // 
            // qualitySelection
            // 
            this.qualitySelection.Location = new System.Drawing.Point(225, 81);
            this.qualitySelection.Name = "qualitySelection";
            this.qualitySelection.Size = new System.Drawing.Size(131, 45);
            this.qualitySelection.TabIndex = 1;
            this.qualitySelection.Text = "Qaulity";
            this.qualitySelection.UseVisualStyleBackColor = true;
            // 
            // siteRulesSelection
            // 
            this.siteRulesSelection.Location = new System.Drawing.Point(432, 86);
            this.siteRulesSelection.Name = "siteRulesSelection";
            this.siteRulesSelection.Size = new System.Drawing.Size(132, 48);
            this.siteRulesSelection.TabIndex = 2;
            this.siteRulesSelection.Text = "Site Rules";
            this.siteRulesSelection.UseVisualStyleBackColor = true;
            // 
            // environmentalSelection
            // 
            this.environmentalSelection.Location = new System.Drawing.Point(51, 224);
            this.environmentalSelection.Name = "environmentalSelection";
            this.environmentalSelection.Size = new System.Drawing.Size(116, 49);
            this.environmentalSelection.TabIndex = 3;
            this.environmentalSelection.Text = "Environmental";
            this.environmentalSelection.UseVisualStyleBackColor = true;
            // 
            // POISelection
            // 
            this.POISelection.Location = new System.Drawing.Point(226, 224);
            this.POISelection.Name = "POISelection";
            this.POISelection.Size = new System.Drawing.Size(130, 49);
            this.POISelection.TabIndex = 4;
            this.POISelection.Text = "Protection Of Individuals";
            this.POISelection.UseVisualStyleBackColor = true;
            // 
            // TCOESelection
            // 
            this.TCOESelection.Location = new System.Drawing.Point(423, 224);
            this.TCOESelection.Name = "TCOESelection";
            this.TCOESelection.Size = new System.Drawing.Size(182, 71);
            this.TCOESelection.TabIndex = 5;
            this.TCOESelection.Text = "Tools, Cables and Other Equipment";
            this.TCOESelection.UseVisualStyleBackColor = true;
            // 
            // miscellaneousSelection
            // 
            this.miscellaneousSelection.Location = new System.Drawing.Point(225, 344);
            this.miscellaneousSelection.Name = "miscellaneousSelection";
            this.miscellaneousSelection.Size = new System.Drawing.Size(139, 52);
            this.miscellaneousSelection.TabIndex = 6;
            this.miscellaneousSelection.Text = "Miscellaneous";
            this.miscellaneousSelection.UseVisualStyleBackColor = true;
            // 
            // InspectionCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.miscellaneousSelection);
            this.Controls.Add(this.TCOESelection);
            this.Controls.Add(this.POISelection);
            this.Controls.Add(this.environmentalSelection);
            this.Controls.Add(this.siteRulesSelection);
            this.Controls.Add(this.qualitySelection);
            this.Controls.Add(this.workingStandardsSelection);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InspectionCategory";
            this.Size = new System.Drawing.Size(875, 554);
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
    }
}
