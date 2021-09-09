namespace BasicProperties_dll
{
    partial class ErrorProviderExampleForm
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
            this.components = new System.ComponentModel.Container();
            this.applicantNameLabel = new System.Windows.Forms.Label();
            this.applicantPhoneLabel = new System.Windows.Forms.Label();
            this.aoanAmountLabel = new System.Windows.Forms.Label();
            this.applicantNameTextBox = new System.Windows.Forms.TextBox();
            this.applicantPhoneTextBox = new System.Windows.Forms.TextBox();
            this.loanAmountTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // applicantNameLabel
            // 
            this.applicantNameLabel.AutoSize = true;
            this.applicantNameLabel.Location = new System.Drawing.Point(16, 22);
            this.applicantNameLabel.Name = "applicantNameLabel";
            this.applicantNameLabel.Size = new System.Drawing.Size(91, 12);
            this.applicantNameLabel.TabIndex = 0;
            this.applicantNameLabel.Text = "ApplicantName";
            this.applicantNameLabel.Click += new System.EventHandler(this.ApplicantNameLabel_Click);
            // 
            // applicantPhoneLabel
            // 
            this.applicantPhoneLabel.AutoSize = true;
            this.applicantPhoneLabel.Location = new System.Drawing.Point(16, 52);
            this.applicantPhoneLabel.Name = "applicantPhoneLabel";
            this.applicantPhoneLabel.Size = new System.Drawing.Size(93, 12);
            this.applicantPhoneLabel.TabIndex = 1;
            this.applicantPhoneLabel.Text = "ApplicantPhone";
            this.applicantPhoneLabel.Click += new System.EventHandler(this.ApplicantPhoneLabel_Click);
            // 
            // aoanAmountLabel
            // 
            this.aoanAmountLabel.AutoSize = true;
            this.aoanAmountLabel.Location = new System.Drawing.Point(16, 82);
            this.aoanAmountLabel.Name = "aoanAmountLabel";
            this.aoanAmountLabel.Size = new System.Drawing.Size(76, 12);
            this.aoanAmountLabel.TabIndex = 2;
            this.aoanAmountLabel.Text = "LoanAmount";
            this.aoanAmountLabel.Click += new System.EventHandler(this.LoanAmountLabel_Click);
            // 
            // applicantNameTextBox
            // 
            this.applicantNameTextBox.Location = new System.Drawing.Point(151, 19);
            this.applicantNameTextBox.Name = "applicantNameTextBox";
            this.applicantNameTextBox.Size = new System.Drawing.Size(146, 21);
            this.applicantNameTextBox.TabIndex = 3;
            this.applicantNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // applicantPhoneTextBox
            // 
            this.applicantPhoneTextBox.Location = new System.Drawing.Point(151, 49);
            this.applicantPhoneTextBox.Name = "applicantPhoneTextBox";
            this.applicantPhoneTextBox.Size = new System.Drawing.Size(146, 21);
            this.applicantPhoneTextBox.TabIndex = 4;
            // 
            // loanAmountTextBox
            // 
            this.loanAmountTextBox.Location = new System.Drawing.Point(151, 79);
            this.loanAmountTextBox.Name = "loanAmountTextBox";
            this.loanAmountTextBox.Size = new System.Drawing.Size(146, 21);
            this.loanAmountTextBox.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ErrorProviderExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 124);
            this.Controls.Add(this.loanAmountTextBox);
            this.Controls.Add(this.applicantPhoneTextBox);
            this.Controls.Add(this.applicantNameTextBox);
            this.Controls.Add(this.aoanAmountLabel);
            this.Controls.Add(this.applicantPhoneLabel);
            this.Controls.Add(this.applicantNameLabel);
            this.Name = "ErrorProviderExampleForm";
            this.Text = "ErrorProviderExampleForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label applicantNameLabel;
        private System.Windows.Forms.Label applicantPhoneLabel;
        private System.Windows.Forms.Label aoanAmountLabel;
        private System.Windows.Forms.TextBox applicantNameTextBox;
        private System.Windows.Forms.TextBox applicantPhoneTextBox;
        private System.Windows.Forms.TextBox loanAmountTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}