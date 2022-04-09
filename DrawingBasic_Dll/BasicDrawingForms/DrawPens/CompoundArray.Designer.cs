
namespace DrawingProject_Dll
{
    partial class CompoundArray
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
            this.drawRectBtn = new CustomControls_dll.MetalButton();
            this.closeBtn = new CustomControls_dll.MetalButton();
            this.SuspendLayout();
            // 
            // drawRectBtn
            // 
            this.drawRectBtn.Location = new System.Drawing.Point(155, 139);
            this.drawRectBtn.Name = "drawRectBtn";
            this.drawRectBtn.Size = new System.Drawing.Size(81, 28);
            this.drawRectBtn.TabIndex = 23;
            this.drawRectBtn.Text = "Draw Rect";
            this.drawRectBtn.UseVisualStyleBackColor = true;
            this.drawRectBtn.Click += new System.EventHandler(this.drawRectBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(12, 139);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(0, 0);
            this.closeBtn.TabIndex = 24;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // CompoundArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(242, 172);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.drawRectBtn);
            this.Name = "CompoundArray";
            this.Text = "CompoundArray";
            this.Load += new System.EventHandler(this.CompoundArray_Load);
            this.Shown += new System.EventHandler(this.CompoundArray_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls_dll.MetalButton drawRectBtn;
        private CustomControls_dll.MetalButton closeBtn;
    }
}