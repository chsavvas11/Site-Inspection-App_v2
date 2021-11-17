
namespace App
{
    partial class InspectionDetails
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
            this.numberOfInterventionsInput = new System.Windows.Forms.TextBox();
            this.InterventionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberOfInterventionsInput
            // 
            this.numberOfInterventionsInput.Location = new System.Drawing.Point(154, 166);
            this.numberOfInterventionsInput.Name = "numberOfInterventionsInput";
            this.numberOfInterventionsInput.Size = new System.Drawing.Size(100, 22);
            this.numberOfInterventionsInput.TabIndex = 0;
            // 
            // InterventionsLabel
            // 
            this.InterventionsLabel.AutoSize = true;
            this.InterventionsLabel.Location = new System.Drawing.Point(17, 169);
            this.InterventionsLabel.Name = "InterventionsLabel";
            this.InterventionsLabel.Size = new System.Drawing.Size(121, 16);
            this.InterventionsLabel.TabIndex = 1;
            this.InterventionsLabel.Text = "No. of interventions";
            // 
            // InspectionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InterventionsLabel);
            this.Controls.Add(this.numberOfInterventionsInput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InspectionDetails";
            this.Size = new System.Drawing.Size(875, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberOfInterventionsInput;
        private System.Windows.Forms.Label InterventionsLabel;
    }
}
