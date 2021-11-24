
namespace App
{
    partial class InspectionOverview
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
            this.categoryInterventionsDataGridView = new System.Windows.Forms.DataGridView();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPositiveInterventions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalNegativeInterventions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.overviewHeaderLabel = new System.Windows.Forms.Label();
            this.submitInspectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoryInterventionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryInterventionsDataGridView
            // 
            this.categoryInterventionsDataGridView.AllowUserToAddRows = false;
            this.categoryInterventionsDataGridView.AllowUserToDeleteRows = false;
            this.categoryInterventionsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryInterventionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryInterventionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryName,
            this.TotalPositiveInterventions,
            this.TotalNegativeInterventions});
            this.categoryInterventionsDataGridView.Location = new System.Drawing.Point(33, 107);
            this.categoryInterventionsDataGridView.Name = "categoryInterventionsDataGridView";
            this.categoryInterventionsDataGridView.ReadOnly = true;
            this.categoryInterventionsDataGridView.Size = new System.Drawing.Size(341, 211);
            this.categoryInterventionsDataGridView.TabIndex = 0;
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "Category";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // TotalPositiveInterventions
            // 
            this.TotalPositiveInterventions.HeaderText = "Positive Interventions";
            this.TotalPositiveInterventions.Name = "TotalPositiveInterventions";
            this.TotalPositiveInterventions.ReadOnly = true;
            // 
            // TotalNegativeInterventions
            // 
            this.TotalNegativeInterventions.HeaderText = "Negative Interventions";
            this.TotalNegativeInterventions.Name = "TotalNegativeInterventions";
            this.TotalNegativeInterventions.ReadOnly = true;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(438, 154);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(160, 141);
            this.commentsTextBox.TabIndex = 1;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(446, 119);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(86, 20);
            this.commentsLabel.TabIndex = 2;
            this.commentsLabel.Text = "Comments";
            // 
            // overviewHeaderLabel
            // 
            this.overviewHeaderLabel.AutoSize = true;
            this.overviewHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewHeaderLabel.Location = new System.Drawing.Point(263, 34);
            this.overviewHeaderLabel.Name = "overviewHeaderLabel";
            this.overviewHeaderLabel.Size = new System.Drawing.Size(128, 31);
            this.overviewHeaderLabel.TabIndex = 3;
            this.overviewHeaderLabel.Text = "Overview";
            // 
            // submitInspectionButton
            // 
            this.submitInspectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitInspectionButton.Location = new System.Drawing.Point(299, 373);
            this.submitInspectionButton.Name = "submitInspectionButton";
            this.submitInspectionButton.Size = new System.Drawing.Size(75, 30);
            this.submitInspectionButton.TabIndex = 4;
            this.submitInspectionButton.Text = "Submit";
            this.submitInspectionButton.UseVisualStyleBackColor = true;
            // 
            // InspectionOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.submitInspectionButton);
            this.Controls.Add(this.overviewHeaderLabel);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.categoryInterventionsDataGridView);
            this.Name = "InspectionOverview";
            this.Size = new System.Drawing.Size(656, 450);
            this.VisibleChanged += new System.EventHandler(this.InspectionOverview_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.categoryInterventionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView categoryInterventionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPositiveInterventions;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalNegativeInterventions;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.Label overviewHeaderLabel;
        private System.Windows.Forms.Button submitInspectionButton;
    }
}
