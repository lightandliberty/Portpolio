namespace MultiThread_dll
{
    partial class DigitsOfPiForm
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
            this.digitsOfPiLbl = new System.Windows.Forms.Label();
            this.numDigitsUpDown = new System.Windows.Forms.NumericUpDown();
            this.cancelMetalBtn = new CustomControls_dll.MetalButton();
            this.calcMetalBtn = new CustomControls_dll.MetalButton();
            this.piTextBox = new System.Windows.Forms.TextBox();
            this.piProgressBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numDigitsUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // digitsOfPiLbl
            // 
            this.digitsOfPiLbl.AutoSize = true;
            this.digitsOfPiLbl.Location = new System.Drawing.Point(12, 13);
            this.digitsOfPiLbl.Name = "digitsOfPiLbl";
            this.digitsOfPiLbl.Size = new System.Drawing.Size(65, 12);
            this.digitsOfPiLbl.TabIndex = 0;
            this.digitsOfPiLbl.Text = "Digits of Pi";
            // 
            // numDigitsUpDown
            // 
            this.numDigitsUpDown.Location = new System.Drawing.Point(95, 9);
            this.numDigitsUpDown.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numDigitsUpDown.Name = "numDigitsUpDown";
            this.numDigitsUpDown.Size = new System.Drawing.Size(50, 21);
            this.numDigitsUpDown.TabIndex = 1;
            this.numDigitsUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumDigitsUpDown_KeyDown);
            // 
            // cancelMetalBtn
            // 
            this.cancelMetalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelMetalBtn.CausesValidation = false;
            this.cancelMetalBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelMetalBtn.Location = new System.Drawing.Point(121, 7);
            this.cancelMetalBtn.Name = "cancelMetalBtn";
            this.cancelMetalBtn.Size = new System.Drawing.Size(0, 0);
            this.cancelMetalBtn.TabIndex = 24;
            this.cancelMetalBtn.Text = "Cancel";
            this.cancelMetalBtn.UseVisualStyleBackColor = true;
            this.cancelMetalBtn.Click += new System.EventHandler(this.CancelMetalBtn);
            // 
            // calcMetalBtn
            // 
            this.calcMetalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calcMetalBtn.Location = new System.Drawing.Point(164, 5);
            this.calcMetalBtn.Name = "calcMetalBtn";
            this.calcMetalBtn.Size = new System.Drawing.Size(81, 28);
            this.calcMetalBtn.TabIndex = 23;
            this.calcMetalBtn.Text = "Calc";
            this.calcMetalBtn.UseVisualStyleBackColor = true;
            this.calcMetalBtn.Click += new System.EventHandler(this.CalcMetalBtn_Click);
            // 
            // piTextBox
            // 
            this.piTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.piTextBox.Location = new System.Drawing.Point(0, 43);
            this.piTextBox.Multiline = true;
            this.piTextBox.Name = "piTextBox";
            this.piTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.piTextBox.Size = new System.Drawing.Size(258, 215);
            this.piTextBox.TabIndex = 25;
            // 
            // piProgressBar
            // 
            this.piProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.piProgressBar.Location = new System.Drawing.Point(0, 258);
            this.piProgressBar.Maximum = 1;
            this.piProgressBar.Name = "piProgressBar";
            this.piProgressBar.Size = new System.Drawing.Size(258, 23);
            this.piProgressBar.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.digitsOfPiLbl);
            this.panel1.Controls.Add(this.numDigitsUpDown);
            this.panel1.Controls.Add(this.calcMetalBtn);
            this.panel1.Controls.Add(this.cancelMetalBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 43);
            this.panel1.TabIndex = 28;
            // 
            // DigitsOfPiForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.cancelMetalBtn;
            this.ClientSize = new System.Drawing.Size(258, 281);
            this.Controls.Add(this.piTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.piProgressBar);
            this.Name = "DigitsOfPiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DigitsOfPiForm";
            this.Shown += new System.EventHandler(this.DigitsOfPiForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numDigitsUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label digitsOfPiLbl;
        private System.Windows.Forms.NumericUpDown numDigitsUpDown;
        private CustomControls_dll.MetalButton cancelMetalBtn;
        private CustomControls_dll.MetalButton calcMetalBtn;
        private System.Windows.Forms.TextBox piTextBox;
        private System.Windows.Forms.ProgressBar piProgressBar;
        private System.Windows.Forms.Panel panel1;
    }
}