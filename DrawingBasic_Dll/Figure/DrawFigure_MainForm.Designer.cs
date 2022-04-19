
namespace DrawingProject_Dll
{
    partial class DrawFigure_MainForm
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
            this.drawFigureBtn = new CustomControls_dll.MetalButton();
            this.instructionTextBox = new System.Windows.Forms.TextBox();
            this.cancelMetalBtn = new CustomControls_dll.MetalButton();
            this.okMetalBtn = new CustomControls_dll.MetalButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.drawCurveBtn = new CustomControls_dll.MetalButton();
            this.drawBeziersBtn = new CustomControls_dll.MetalButton();
            this.drawSmoothingModesBtn = new CustomControls_dll.MetalButton();
            this.drawPathBtn = new CustomControls_dll.MetalButton();
            this.SuspendLayout();
            // 
            // drawFigureBtn
            // 
            this.drawFigureBtn.Location = new System.Drawing.Point(24, 158);
            this.drawFigureBtn.Name = "drawFigureBtn";
            this.drawFigureBtn.Size = new System.Drawing.Size(112, 36);
            this.drawFigureBtn.TabIndex = 18;
            this.drawFigureBtn.Text = "Draw Figures";
            this.drawFigureBtn.UseVisualStyleBackColor = true;
            this.drawFigureBtn.Click += new System.EventHandler(this.drawFigureBtn_Click);
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
            // drawCurveBtn
            // 
            this.drawCurveBtn.Location = new System.Drawing.Point(24, 200);
            this.drawCurveBtn.Name = "drawCurveBtn";
            this.drawCurveBtn.Size = new System.Drawing.Size(112, 36);
            this.drawCurveBtn.TabIndex = 23;
            this.drawCurveBtn.Text = "Draw Curves";
            this.drawCurveBtn.UseVisualStyleBackColor = true;
            this.drawCurveBtn.Click += new System.EventHandler(this.drawCurveBtn_Click);
            // 
            // drawBeziersBtn
            // 
            this.drawBeziersBtn.Location = new System.Drawing.Point(24, 242);
            this.drawBeziersBtn.Name = "drawBeziersBtn";
            this.drawBeziersBtn.Size = new System.Drawing.Size(112, 36);
            this.drawBeziersBtn.TabIndex = 24;
            this.drawBeziersBtn.Text = "Draw Beziers";
            this.drawBeziersBtn.UseVisualStyleBackColor = true;
            this.drawBeziersBtn.Click += new System.EventHandler(this.drawBeziersBtn_Click);
            // 
            // drawSmoothingModesBtn
            // 
            this.drawSmoothingModesBtn.Location = new System.Drawing.Point(24, 284);
            this.drawSmoothingModesBtn.Name = "drawSmoothingModesBtn";
            this.drawSmoothingModesBtn.Size = new System.Drawing.Size(112, 36);
            this.drawSmoothingModesBtn.TabIndex = 25;
            this.drawSmoothingModesBtn.Text = "Draw Smoothing Modes";
            this.drawSmoothingModesBtn.UseVisualStyleBackColor = true;
            this.drawSmoothingModesBtn.Click += new System.EventHandler(this.drawSmoothingModesBtn_Click);
            // 
            // drawPathBtn
            // 
            this.drawPathBtn.Location = new System.Drawing.Point(24, 326);
            this.drawPathBtn.Name = "drawPathBtn";
            this.drawPathBtn.Size = new System.Drawing.Size(112, 36);
            this.drawPathBtn.TabIndex = 26;
            this.drawPathBtn.Text = "Draw Path";
            this.drawPathBtn.UseVisualStyleBackColor = true;
            this.drawPathBtn.Click += new System.EventHandler(this.drawPathBtn_Click);
            // 
            // DrawFigure_MainForm
            // 
            this.AcceptButton = this.okMetalBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelMetalBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawPathBtn);
            this.Controls.Add(this.drawSmoothingModesBtn);
            this.Controls.Add(this.drawBeziersBtn);
            this.Controls.Add(this.drawCurveBtn);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.cancelMetalBtn);
            this.Controls.Add(this.okMetalBtn);
            this.Controls.Add(this.instructionTextBox);
            this.Controls.Add(this.drawFigureBtn);
            this.Name = "DrawFigure_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DrawingPensForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls_dll.MetalButton drawFigureBtn;
        private System.Windows.Forms.TextBox instructionTextBox;
        private CustomControls_dll.MetalButton cancelMetalBtn;
        private CustomControls_dll.MetalButton okMetalBtn;
        private System.Windows.Forms.Label titleLabel;
        private CustomControls_dll.MetalButton drawCurveBtn;
        private CustomControls_dll.MetalButton drawBeziersBtn;
        private CustomControls_dll.MetalButton drawSmoothingModesBtn;
        private CustomControls_dll.MetalButton drawPathBtn;
    }
}