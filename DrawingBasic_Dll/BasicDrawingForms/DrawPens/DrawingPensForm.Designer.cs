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
            this.drawCompoundArrayBtn = new CustomControls_dll.MetalButton();
            this.drawDashesBtn = new CustomControls_dll.MetalButton();
            this.drawPenAlignmentFormBtn = new CustomControls_dll.MetalButton();
            this.drawLineJoinBtn = new CustomControls_dll.MetalButton();
            this.drawAboutBtn = new CustomControls_dll.MetalButton();
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
            // drawCompoundArrayBtn
            // 
            this.drawCompoundArrayBtn.Location = new System.Drawing.Point(24, 258);
            this.drawCompoundArrayBtn.Name = "drawCompoundArrayBtn";
            this.drawCompoundArrayBtn.Size = new System.Drawing.Size(112, 36);
            this.drawCompoundArrayBtn.TabIndex = 23;
            this.drawCompoundArrayBtn.Text = "Draw CompoundArray";
            this.drawCompoundArrayBtn.UseVisualStyleBackColor = true;
            this.drawCompoundArrayBtn.Click += new System.EventHandler(this.DrawCompoundArrayBtn_Click);
            // 
            // drawDashesBtn
            // 
            this.drawDashesBtn.Location = new System.Drawing.Point(24, 208);
            this.drawDashesBtn.Name = "drawDashesBtn";
            this.drawDashesBtn.Size = new System.Drawing.Size(112, 36);
            this.drawDashesBtn.TabIndex = 24;
            this.drawDashesBtn.Text = "Draw Dashes";
            this.drawDashesBtn.UseVisualStyleBackColor = true;
            this.drawDashesBtn.Click += new System.EventHandler(this.drawDashesBtn_Click);
            // 
            // drawPenAlignmentFormBtn
            // 
            this.drawPenAlignmentFormBtn.Location = new System.Drawing.Point(24, 308);
            this.drawPenAlignmentFormBtn.Name = "drawPenAlignmentFormBtn";
            this.drawPenAlignmentFormBtn.Size = new System.Drawing.Size(112, 36);
            this.drawPenAlignmentFormBtn.TabIndex = 25;
            this.drawPenAlignmentFormBtn.Text = "Draw\r\nPenAlignment";
            this.drawPenAlignmentFormBtn.UseVisualStyleBackColor = true;
            this.drawPenAlignmentFormBtn.Click += new System.EventHandler(this.drawPenAlignmentFormBtn_Click);
            // 
            // drawLineJoinBtn
            // 
            this.drawLineJoinBtn.Location = new System.Drawing.Point(24, 358);
            this.drawLineJoinBtn.Name = "drawLineJoinBtn";
            this.drawLineJoinBtn.Size = new System.Drawing.Size(112, 36);
            this.drawLineJoinBtn.TabIndex = 26;
            this.drawLineJoinBtn.Text = "Draw LineJoins";
            this.drawLineJoinBtn.UseVisualStyleBackColor = true;
            this.drawLineJoinBtn.Click += new System.EventHandler(this.drawLineJoinBtn_Click);
            // 
            // drawAboutBtn
            // 
            this.drawAboutBtn.Location = new System.Drawing.Point(24, 406);
            this.drawAboutBtn.Name = "drawAboutBtn";
            this.drawAboutBtn.Size = new System.Drawing.Size(112, 36);
            this.drawAboutBtn.TabIndex = 27;
            this.drawAboutBtn.Text = "Draw About";
            this.drawAboutBtn.UseVisualStyleBackColor = true;
            this.drawAboutBtn.Click += new System.EventHandler(this.drawAboutBtn_Click);
            // 
            // DrawingPensForm
            // 
            this.AcceptButton = this.okMetalBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelMetalBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawAboutBtn);
            this.Controls.Add(this.drawLineJoinBtn);
            this.Controls.Add(this.drawPenAlignmentFormBtn);
            this.Controls.Add(this.drawDashesBtn);
            this.Controls.Add(this.drawCompoundArrayBtn);
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
        private CustomControls_dll.MetalButton drawCompoundArrayBtn;
        private CustomControls_dll.MetalButton drawDashesBtn;
        private CustomControls_dll.MetalButton drawPenAlignmentFormBtn;
        private CustomControls_dll.MetalButton drawLineJoinBtn;
        private CustomControls_dll.MetalButton drawAboutBtn;
    }
}