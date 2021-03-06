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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorProviderExampleForm));
            this.applicantNameLabel = new System.Windows.Forms.Label();
            this.applicantPhoneLabel = new System.Windows.Forms.Label();
            this.aoanAmountLabel = new System.Windows.Forms.Label();
            this.applicantNameTextBox = new System.Windows.Forms.TextBox();
            this.applicantPhoneTextBox = new System.Windows.Forms.TextBox();
            this.loanAmountTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.okMetalBtn = new CustomControls_dll.MetalButton();
            this.cancelMetalBtn = new CustomControls_dll.MetalButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.infoProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // applicantNameLabel
            // 
            this.applicantNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.applicantPhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.aoanAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.applicantNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.applicantNameTextBox, "aNameProjectFile.htm#name");
            this.helpProvider1.SetHelpNavigator(this.applicantNameTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.applicantNameTextBox.Location = new System.Drawing.Point(151, 19);
            this.applicantNameTextBox.Name = "applicantNameTextBox";
            this.helpProvider1.SetShowHelp(this.applicantNameTextBox, false);
            this.applicantNameTextBox.Size = new System.Drawing.Size(325, 21);
            this.applicantNameTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.applicantNameTextBox, "이름을 넣어주세요");
            this.applicantNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // applicantPhoneTextBox
            // 
            this.applicantPhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpNavigator(this.applicantPhoneTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.applicantPhoneTextBox.Location = new System.Drawing.Point(151, 49);
            this.applicantPhoneTextBox.Name = "applicantPhoneTextBox";
            this.helpProvider1.SetShowHelp(this.applicantPhoneTextBox, false);
            this.applicantPhoneTextBox.Size = new System.Drawing.Size(325, 21);
            this.applicantPhoneTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.applicantPhoneTextBox, "전화 번호");
            this.applicantPhoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // loanAmountTextBox
            // 
            this.loanAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpNavigator(this.loanAmountTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.loanAmountTextBox.Location = new System.Drawing.Point(151, 79);
            this.loanAmountTextBox.Name = "loanAmountTextBox";
            this.helpProvider1.SetShowHelp(this.loanAmountTextBox, false);
            this.loanAmountTextBox.Size = new System.Drawing.Size(325, 21);
            this.loanAmountTextBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.loanAmountTextBox, "대출금");
            this.loanAmountTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // okMetalBtn
            // 
            this.okMetalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okMetalBtn.Location = new System.Drawing.Point(317, 112);
            this.okMetalBtn.Name = "okMetalBtn";
            this.okMetalBtn.Size = new System.Drawing.Size(81, 28);
            this.okMetalBtn.TabIndex = 8;
            this.okMetalBtn.Text = "OK";
            this.okMetalBtn.UseVisualStyleBackColor = true;
            this.okMetalBtn.Click += new System.EventHandler(this.OKMetalBtn_Click);
            // 
            // cancelMetalBtn
            // 
            this.cancelMetalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelMetalBtn.CausesValidation = false;
            this.cancelMetalBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelMetalBtn.Location = new System.Drawing.Point(420, 112);
            this.cancelMetalBtn.Name = "cancelMetalBtn";
            this.cancelMetalBtn.Size = new System.Drawing.Size(81, 28);
            this.cancelMetalBtn.TabIndex = 9;
            this.cancelMetalBtn.Text = "Cancel";
            this.cancelMetalBtn.UseVisualStyleBackColor = true;
            this.cancelMetalBtn.Click += new System.EventHandler(this.CancelMetalBtn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 4800;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 96;
            this.toolTip1.ShowAlways = true;
            // 
            // infoProvider
            // 
            this.infoProvider.ContainerControl = this;
            this.infoProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("infoProvider.Icon")));
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(18, 150);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(484, 175);
            this.textBox1.TabIndex = 10;
            // 
            // ErrorProviderExampleForm
            // 
            this.AcceptButton = this.okMetalBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelMetalBtn;
            this.ClientSize = new System.Drawing.Size(518, 337);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancelMetalBtn);
            this.Controls.Add(this.okMetalBtn);
            this.Controls.Add(this.loanAmountTextBox);
            this.Controls.Add(this.applicantPhoneTextBox);
            this.Controls.Add(this.applicantNameTextBox);
            this.Controls.Add(this.aoanAmountLabel);
            this.Controls.Add(this.applicantPhoneLabel);
            this.Controls.Add(this.applicantNameLabel);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorProviderExampleForm";
            this.Text = "ErrorProviderExampleForm";
            this.Load += new System.EventHandler(this.ErrorProviderExampleForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ErrorProviderExampleForm_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
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
        private CustomControls_dll.MetalButton okMetalBtn;
        private CustomControls_dll.MetalButton cancelMetalBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider infoProvider;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}