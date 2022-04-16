
namespace DrawingProject_Dll
{
    partial class LineJoinsForm
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
            this.drawJoinsBtn = new CustomControls_dll.MetalButton();
            this.closeBtn = new CustomControls_dll.MetalButton();
            this.label1 = new System.Windows.Forms.Label();
            this.drawJoins2Btn = new CustomControls_dll.MetalButton();
            this.SuspendLayout();
            // 
            // drawJoinsBtn
            // 
            this.drawJoinsBtn.Location = new System.Drawing.Point(180, 267);
            this.drawJoinsBtn.Name = "drawJoinsBtn";
            this.drawJoinsBtn.Size = new System.Drawing.Size(91, 28);
            this.drawJoinsBtn.TabIndex = 28;
            this.drawJoinsBtn.Text = "Draw Joins";
            this.drawJoinsBtn.UseVisualStyleBackColor = true;
            this.drawJoinsBtn.Click += new System.EventHandler(this.drawJoinsBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(12, 261);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(68, 41);
            this.closeBtn.TabIndex = 27;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "MiterClipped는 Miter와 같아 보이지만, \r\n각도에 따라 Bevel 또는 Miter로 효과가 변경 됨.";
            // 
            // drawJoins2Btn
            // 
            this.drawJoins2Btn.Location = new System.Drawing.Point(281, 267);
            this.drawJoins2Btn.Name = "drawJoins2Btn";
            this.drawJoins2Btn.Size = new System.Drawing.Size(91, 28);
            this.drawJoins2Btn.TabIndex = 30;
            this.drawJoins2Btn.Text = "Draw Joins2";
            this.drawJoins2Btn.UseVisualStyleBackColor = true;
            this.drawJoins2Btn.Click += new System.EventHandler(this.drawJoins2Btn_Click);
            // 
            // LineJoinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.drawJoins2Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawJoinsBtn);
            this.Controls.Add(this.closeBtn);
            this.Name = "LineJoinsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LineJoinsForm";
            this.Load += new System.EventHandler(this.LineJoinsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls_dll.MetalButton drawJoinsBtn;
        private CustomControls_dll.MetalButton closeBtn;
        private System.Windows.Forms.Label label1;
        private CustomControls_dll.MetalButton drawJoins2Btn;
    }
}