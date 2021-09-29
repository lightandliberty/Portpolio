namespace DrawingProject_Dll
{
    partial class DrawHatchBrushes
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
            this.cancelMetalBtn = new CustomControls_dll.MetalButton();
            this.SuspendLayout();
            // 
            // cancelMetalBtn
            // 
            this.cancelMetalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelMetalBtn.CausesValidation = false;
            this.cancelMetalBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelMetalBtn.Location = new System.Drawing.Point(707, 410);
            this.cancelMetalBtn.Name = "cancelMetalBtn";
            this.cancelMetalBtn.Size = new System.Drawing.Size(0, 0);
            this.cancelMetalBtn.TabIndex = 12;
            this.cancelMetalBtn.Text = "Cancel";
            this.cancelMetalBtn.UseVisualStyleBackColor = true;
            this.cancelMetalBtn.Click += new System.EventHandler(this.cancelMetalBtn_Click);
            // 
            // DrawHatchBrushes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelMetalBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelMetalBtn);
            this.Name = "DrawHatchBrushes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HatchBrushes";
            this.Load += new System.EventHandler(this.HatchBrushes_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawHatchBrushes_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls_dll.MetalButton cancelMetalBtn;
    }
}