
namespace DrawingProject_Dll
{
    partial class DrawImage_MainForm
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
            this.instructionTextBox = new System.Windows.Forms.TextBox();
            this.cancelMetalBtn = new CustomControls_dll.MetalButton();
            this.okMetalBtn = new CustomControls_dll.MetalButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.drawScalingClippingBtn = new CustomControls_dll.MetalButton();
            this.drawPanningBtn = new CustomControls_dll.MetalButton();
            this.drawSkewingBtn = new CustomControls_dll.MetalButton();
            this.drawRotatingFlippingBtn = new CustomControls_dll.MetalButton();
            this.drawRecoloringBtn = new CustomControls_dll.MetalButton();
            this.SuspendLayout();
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
            this.titleLabel.Size = new System.Drawing.Size(170, 24);
            this.titleLabel.TabIndex = 22;
            this.titleLabel.Text = "Drawing Figures";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // drawScalingClippingBtn
            // 
            this.drawScalingClippingBtn.Location = new System.Drawing.Point(24, 158);
            this.drawScalingClippingBtn.Name = "drawScalingClippingBtn";
            this.drawScalingClippingBtn.Size = new System.Drawing.Size(166, 36);
            this.drawScalingClippingBtn.TabIndex = 23;
            this.drawScalingClippingBtn.Text = "Draw Scaling & Clipping";
            this.drawScalingClippingBtn.UseVisualStyleBackColor = true;
            this.drawScalingClippingBtn.Click += new System.EventHandler(this.drawScalingClippingBtn_Click);
            // 
            // drawPanningBtn
            // 
            this.drawPanningBtn.Location = new System.Drawing.Point(24, 200);
            this.drawPanningBtn.Name = "drawPanningBtn";
            this.drawPanningBtn.Size = new System.Drawing.Size(166, 36);
            this.drawPanningBtn.TabIndex = 24;
            this.drawPanningBtn.Text = "Draw Panning";
            this.drawPanningBtn.UseVisualStyleBackColor = true;
            this.drawPanningBtn.Click += new System.EventHandler(this.drawPanningBtn_Click);
            // 
            // drawSkewingBtn
            // 
            this.drawSkewingBtn.Location = new System.Drawing.Point(24, 242);
            this.drawSkewingBtn.Name = "drawSkewingBtn";
            this.drawSkewingBtn.Size = new System.Drawing.Size(166, 36);
            this.drawSkewingBtn.TabIndex = 25;
            this.drawSkewingBtn.Text = "Draw Skewing";
            this.drawSkewingBtn.UseVisualStyleBackColor = true;
            this.drawSkewingBtn.Click += new System.EventHandler(this.drawSkewingBtn_Click);
            // 
            // drawRotatingFlippingBtn
            // 
            this.drawRotatingFlippingBtn.Location = new System.Drawing.Point(24, 284);
            this.drawRotatingFlippingBtn.Name = "drawRotatingFlippingBtn";
            this.drawRotatingFlippingBtn.Size = new System.Drawing.Size(166, 36);
            this.drawRotatingFlippingBtn.TabIndex = 26;
            this.drawRotatingFlippingBtn.Text = "Draw Rotating & Flipping";
            this.drawRotatingFlippingBtn.UseVisualStyleBackColor = true;
            this.drawRotatingFlippingBtn.Click += new System.EventHandler(this.drawRotatingFlippingBtn_Click);
            // 
            // drawRecoloringBtn
            // 
            this.drawRecoloringBtn.Location = new System.Drawing.Point(24, 326);
            this.drawRecoloringBtn.Name = "drawRecoloringBtn";
            this.drawRecoloringBtn.Size = new System.Drawing.Size(166, 36);
            this.drawRecoloringBtn.TabIndex = 27;
            this.drawRecoloringBtn.Text = "Draw Recoloring";
            this.drawRecoloringBtn.UseVisualStyleBackColor = true;
            this.drawRecoloringBtn.Click += new System.EventHandler(this.drawRecoloringBtn_Click);
            // 
            // DrawImage_MainForm
            // 
            this.AcceptButton = this.okMetalBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelMetalBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawRecoloringBtn);
            this.Controls.Add(this.drawRotatingFlippingBtn);
            this.Controls.Add(this.drawSkewingBtn);
            this.Controls.Add(this.drawPanningBtn);
            this.Controls.Add(this.drawScalingClippingBtn);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.cancelMetalBtn);
            this.Controls.Add(this.okMetalBtn);
            this.Controls.Add(this.instructionTextBox);
            this.Name = "DrawImage_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DrawingPensForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox instructionTextBox;
        private CustomControls_dll.MetalButton cancelMetalBtn;
        private CustomControls_dll.MetalButton okMetalBtn;
        private System.Windows.Forms.Label titleLabel;
        private CustomControls_dll.MetalButton drawScalingClippingBtn;
        private CustomControls_dll.MetalButton drawPanningBtn;
        private CustomControls_dll.MetalButton drawSkewingBtn;
        private CustomControls_dll.MetalButton drawRotatingFlippingBtn;
        private CustomControls_dll.MetalButton drawRecoloringBtn;
    }
}