
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
            this.checkSelectionDropdown = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.numberOfPositiveInterventionsLabel = new System.Windows.Forms.Label();
            this.positiveInterventionAmountTextBox = new System.Windows.Forms.TextBox();
            this.positiveInterventionCommentsTextBox = new System.Windows.Forms.TextBox();
            this.positiveInterventionCommentsLabel = new System.Windows.Forms.Label();
            this.NegativeInterventionAmountTextBox = new System.Windows.Forms.TextBox();
            this.numberOfNegativeInterventionsLabel = new System.Windows.Forms.Label();
            this.NegativeInterventionCommentsTextBox = new System.Windows.Forms.TextBox();
            this.NegativeInterventionCommentsLabel = new System.Windows.Forms.Label();
            this.CompletionSelectionLabel = new System.Windows.Forms.Label();
            this.IsCompletedTextBox = new System.Windows.Forms.ComboBox();
            this.saveCheckButton = new System.Windows.Forms.Button();
            this.categoryPageTitle = new System.Windows.Forms.Label();
            this.lbPositiveInterventions = new System.Windows.Forms.Label();
            this.lbNegativeInterventions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkSelectionDropdown
            // 
            this.checkSelectionDropdown.FormattingEnabled = true;
            this.checkSelectionDropdown.Location = new System.Drawing.Point(177, 62);
            this.checkSelectionDropdown.Name = "checkSelectionDropdown";
            this.checkSelectionDropdown.Size = new System.Drawing.Size(366, 21);
            this.checkSelectionDropdown.TabIndex = 0;
            this.checkSelectionDropdown.Click += new System.EventHandler(this.checkSelectionDropDown_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(434, 361);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 37);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // numberOfPositiveInterventionsLabel
            // 
            this.numberOfPositiveInterventionsLabel.AutoSize = true;
            this.numberOfPositiveInterventionsLabel.Location = new System.Drawing.Point(61, 137);
            this.numberOfPositiveInterventionsLabel.Name = "numberOfPositiveInterventionsLabel";
            this.numberOfPositiveInterventionsLabel.Size = new System.Drawing.Size(164, 13);
            this.numberOfPositiveInterventionsLabel.TabIndex = 2;
            this.numberOfPositiveInterventionsLabel.Text = "Number of Positive Interventions*";
            // 
            // positiveInterventionAmountTextBox
            // 
            this.positiveInterventionAmountTextBox.Location = new System.Drawing.Point(228, 137);
            this.positiveInterventionAmountTextBox.Name = "positiveInterventionAmountTextBox";
            this.positiveInterventionAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.positiveInterventionAmountTextBox.TabIndex = 3;
            this.positiveInterventionAmountTextBox.Leave += new System.EventHandler(this.PositiveInterventionAmountTextBox_Leave);
            // 
            // positiveInterventionCommentsTextBox
            // 
            this.positiveInterventionCommentsTextBox.Location = new System.Drawing.Point(228, 180);
            this.positiveInterventionCommentsTextBox.Name = "positiveInterventionCommentsTextBox";
            this.positiveInterventionCommentsTextBox.Size = new System.Drawing.Size(100, 20);
            this.positiveInterventionCommentsTextBox.TabIndex = 5;
            // 
            // positiveInterventionCommentsLabel
            // 
            this.positiveInterventionCommentsLabel.AutoSize = true;
            this.positiveInterventionCommentsLabel.Location = new System.Drawing.Point(61, 180);
            this.positiveInterventionCommentsLabel.Name = "positiveInterventionCommentsLabel";
            this.positiveInterventionCommentsLabel.Size = new System.Drawing.Size(159, 13);
            this.positiveInterventionCommentsLabel.TabIndex = 4;
            this.positiveInterventionCommentsLabel.Text = "Positive Intervention Comments*";
            // 
            // NegativeInterventionAmountTextBox
            // 
            this.NegativeInterventionAmountTextBox.Location = new System.Drawing.Point(228, 223);
            this.NegativeInterventionAmountTextBox.Name = "NegativeInterventionAmountTextBox";
            this.NegativeInterventionAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.NegativeInterventionAmountTextBox.TabIndex = 7;
            this.NegativeInterventionAmountTextBox.Leave += new System.EventHandler(this.NegativeInterventionAmountTextBox_Leave);
            // 
            // numberOfNegativeInterventionsLabel
            // 
            this.numberOfNegativeInterventionsLabel.AutoSize = true;
            this.numberOfNegativeInterventionsLabel.Location = new System.Drawing.Point(61, 223);
            this.numberOfNegativeInterventionsLabel.Name = "numberOfNegativeInterventionsLabel";
            this.numberOfNegativeInterventionsLabel.Size = new System.Drawing.Size(170, 13);
            this.numberOfNegativeInterventionsLabel.TabIndex = 6;
            this.numberOfNegativeInterventionsLabel.Text = "Number of Negative Interventions*";
            // 
            // NegativeInterventionCommentsTextBox
            // 
            this.NegativeInterventionCommentsTextBox.Location = new System.Drawing.Point(228, 267);
            this.NegativeInterventionCommentsTextBox.Name = "NegativeInterventionCommentsTextBox";
            this.NegativeInterventionCommentsTextBox.Size = new System.Drawing.Size(100, 20);
            this.NegativeInterventionCommentsTextBox.TabIndex = 9;
            // 
            // NegativeInterventionCommentsLabel
            // 
            this.NegativeInterventionCommentsLabel.AutoSize = true;
            this.NegativeInterventionCommentsLabel.Location = new System.Drawing.Point(61, 267);
            this.NegativeInterventionCommentsLabel.Name = "NegativeInterventionCommentsLabel";
            this.NegativeInterventionCommentsLabel.Size = new System.Drawing.Size(165, 13);
            this.NegativeInterventionCommentsLabel.TabIndex = 8;
            this.NegativeInterventionCommentsLabel.Text = "Negative Intervention Comments*";
            // 
            // CompletionSelectionLabel
            // 
            this.CompletionSelectionLabel.AutoSize = true;
            this.CompletionSelectionLabel.Location = new System.Drawing.Point(61, 311);
            this.CompletionSelectionLabel.Name = "CompletionSelectionLabel";
            this.CompletionSelectionLabel.Size = new System.Drawing.Size(110, 13);
            this.CompletionSelectionLabel.TabIndex = 10;
            this.CompletionSelectionLabel.Text = "Is check completed?*";
            // 
            // IsCompletedTextBox
            // 
            this.IsCompletedTextBox.FormattingEnabled = true;
            this.IsCompletedTextBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.IsCompletedTextBox.Location = new System.Drawing.Point(228, 311);
            this.IsCompletedTextBox.Name = "IsCompletedTextBox";
            this.IsCompletedTextBox.Size = new System.Drawing.Size(100, 21);
            this.IsCompletedTextBox.TabIndex = 11;
            // 
            // saveCheckButton
            // 
            this.saveCheckButton.Location = new System.Drawing.Point(540, 361);
            this.saveCheckButton.Name = "saveCheckButton";
            this.saveCheckButton.Size = new System.Drawing.Size(75, 37);
            this.saveCheckButton.TabIndex = 12;
            this.saveCheckButton.Text = "Save and Return";
            this.saveCheckButton.UseVisualStyleBackColor = true;
            this.saveCheckButton.Click += new System.EventHandler(this.saveCheckButton_Click);
            // 
            // categoryPageTitle
            // 
            this.categoryPageTitle.AutoSize = true;
            this.categoryPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryPageTitle.Location = new System.Drawing.Point(33, 14);
            this.categoryPageTitle.Name = "categoryPageTitle";
            this.categoryPageTitle.Size = new System.Drawing.Size(93, 31);
            this.categoryPageTitle.TabIndex = 13;
            this.categoryPageTitle.Text = "autofill";
            // 
            // lbPositiveInterventions
            // 
            this.lbPositiveInterventions.AutoSize = true;
            this.lbPositiveInterventions.ForeColor = System.Drawing.Color.Red;
            this.lbPositiveInterventions.Location = new System.Drawing.Point(347, 141);
            this.lbPositiveInterventions.Name = "lbPositiveInterventions";
            this.lbPositiveInterventions.Size = new System.Drawing.Size(84, 13);
            this.lbPositiveInterventions.TabIndex = 14;
            this.lbPositiveInterventions.Text = "Integer required ";
            this.lbPositiveInterventions.Visible = false;
            // 
            // lbNegativeInterventions
            // 
            this.lbNegativeInterventions.AutoSize = true;
            this.lbNegativeInterventions.ForeColor = System.Drawing.Color.Red;
            this.lbNegativeInterventions.Location = new System.Drawing.Point(349, 227);
            this.lbNegativeInterventions.Name = "lbNegativeInterventions";
            this.lbNegativeInterventions.Size = new System.Drawing.Size(81, 13);
            this.lbNegativeInterventions.TabIndex = 15;
            this.lbNegativeInterventions.Text = "Integer required";
            this.lbNegativeInterventions.Visible = false;
            // 
            // InspectionCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbNegativeInterventions);
            this.Controls.Add(this.lbPositiveInterventions);
            this.Controls.Add(this.categoryPageTitle);
            this.Controls.Add(this.saveCheckButton);
            this.Controls.Add(this.IsCompletedTextBox);
            this.Controls.Add(this.CompletionSelectionLabel);
            this.Controls.Add(this.NegativeInterventionCommentsTextBox);
            this.Controls.Add(this.NegativeInterventionCommentsLabel);
            this.Controls.Add(this.NegativeInterventionAmountTextBox);
            this.Controls.Add(this.numberOfNegativeInterventionsLabel);
            this.Controls.Add(this.positiveInterventionCommentsTextBox);
            this.Controls.Add(this.positiveInterventionCommentsLabel);
            this.Controls.Add(this.positiveInterventionAmountTextBox);
            this.Controls.Add(this.numberOfPositiveInterventionsLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.checkSelectionDropdown);
            this.Name = "InspectionCategory";
            this.Size = new System.Drawing.Size(656, 450);
            this.VisibleChanged += new System.EventHandler(this.InspectionCategory_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox checkSelectionDropdown;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label numberOfPositiveInterventionsLabel;
        private System.Windows.Forms.TextBox positiveInterventionAmountTextBox;
        private System.Windows.Forms.TextBox positiveInterventionCommentsTextBox;
        private System.Windows.Forms.Label positiveInterventionCommentsLabel;
        private System.Windows.Forms.TextBox NegativeInterventionAmountTextBox;
        private System.Windows.Forms.Label numberOfNegativeInterventionsLabel;
        private System.Windows.Forms.TextBox NegativeInterventionCommentsTextBox;
        private System.Windows.Forms.Label NegativeInterventionCommentsLabel;
        private System.Windows.Forms.Label CompletionSelectionLabel;
        private System.Windows.Forms.ComboBox IsCompletedTextBox;
        private System.Windows.Forms.Button saveCheckButton;
        private System.Windows.Forms.Label categoryPageTitle;
        private System.Windows.Forms.Label lbPositiveInterventions;
        private System.Windows.Forms.Label lbNegativeInterventions;
    }
}
