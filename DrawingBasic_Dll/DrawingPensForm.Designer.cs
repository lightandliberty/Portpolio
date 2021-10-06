namespace DrawingProject_Dll
{
    partial class DrawingPensForm
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
            this.drawLineCapsBtn = new CustomControls_dll.MetalButton();
            this.instructionTextBox = new System.Windows.Forms.TextBox();
            this.cancelMetalBtn = new CustomControls_dll.MetalButton();
            this.okMetalBtn = new CustomControls_dll.MetalButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drawLineCapsBtn
            // 
            this.drawLineCapsBtn.Location = new System.Drawing.Point(24, 158);
            this.drawLineCapsBtn.Name = "drawLineCapsBtn";
            this.drawLineCapsBtn.Size = new System.Drawing.Size(112, 36);
            this.drawLineCapsBtn.TabIndex = 18;
            this.drawLineCapsBtn.Text = "DrawLineCaps";
            this.drawLineCapsBtn.UseVisualStyleBackColor = true;
            this.drawLineCapsBtn.Click += new System.EventHandler(this.DrawLineCapsBtn_Click);
            // 
            // instructionTextBox
            // 
            this.instructionTextBox.Location = new System.Drawing.Point(24, 81);
            this.instructionTextBox.Multiline = true;
            this.instructionTextBox.Name = "instructionTextBox";
            this.instructionTextBox.Size = new System.Drawing.Size(747, 64);
            this.instructionTextBox.TabIndex = 19;
            // 
            // cancelMetalBtn
            // 
            this.cancelMetalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelMetalBtn.CausesValidation = false;
            this.cancelMetalBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelMetalBtn.Location = new System.Drawing.Point(705, 410);
            this.cancelMetalBtn.Name = "cancelMetalBtn";
            this.cancelMetalBtn.Size = new System.Drawing.Size(81, 28);
            this.cancelMetalBtn.TabIndex = 21;
            this.cancelMetalBtn.Text = "Cancel";
            this.cancelMetalBtn.UseVisualStyleBackColor = true;
            this.cancelMetalBtn.Click += new System.EventHandler(this.CancelMetalBtn_Click);
            // 
            // okMetalBtn
            // 
            this.okMetalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okMetalBtn.Location = new System.Drawing.Point(602, 410);
            this.okMetalBtn.Name = "okMetalBtn";
            this.okMetalBtn.Size = new System.Drawing.Size(81, 28);
            this.okMetalBtn.TabIndex = 20;
            this.okMetalBtn.Text = "OK";
            this.okMetalBtn.UseVisualStyleBackColor = true;
            this.okMetalBtn.Click += new System.EventHandler(this.okMetalBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleLabel.Location = new System.Drawing.Point(326, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(149, 24);
            this.titleLabel.TabIndex = 22;
            this.titleLabel.Text = "Drawing Pens";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DrawingPensForm
            // 
            this.AcceptButton = this.okMetalBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelMetalBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.cancelMetalBtn);
            this.Controls.Add(this.okMetalBtn);
            this.Controls.Add(this.instructionTextBox);
            this.Controls.Add(this.drawLineCapsBtn);
            this.Name = "DrawingPensForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DrawingPensForm";
            this.Load += new System.EventHandler(this.DrawingPensForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls_dll.MetalButton drawLineCapsBtn;
        private System.Windows.Forms.TextBox instructionTextBox;
        private CustomControls_dll.MetalButton cancelMetalBtn;
        private CustomControls_dll.MetalButton okMetalBtn;
        private System.Windows.Forms.Label titleLabel;
    }
}