
namespace DrawingProject_Dll
{
    partial class PenAlignmentForm
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
            this.closeBtn = new CustomControls_dll.MetalButton();
            this.drawDashesBtn = new CustomControls_dll.MetalButton();
            this.centerLbl = new System.Windows.Forms.Label();
            this.insetLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(12, 295);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(0, 0);
            this.closeBtn.TabIndex = 26;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // drawDashesBtn
            // 
            this.drawDashesBtn.Location = new System.Drawing.Point(228, 303);
            this.drawDashesBtn.Name = "drawDashesBtn";
            this.drawDashesBtn.Size = new System.Drawing.Size(91, 28);
            this.drawDashesBtn.TabIndex = 27;
            this.drawDashesBtn.Text = "Draw Dashes";
            this.drawDashesBtn.UseVisualStyleBackColor = true;
            this.drawDashesBtn.Click += new System.EventHandler(this.drawDashesBtn_Click);
            // 
            // centerLbl
            // 
            this.centerLbl.AutoSize = true;
            this.centerLbl.BackColor = System.Drawing.Color.Transparent;
            this.centerLbl.Location = new System.Drawing.Point(258, 203);
            this.centerLbl.Name = "centerLbl";
            this.centerLbl.Size = new System.Drawing.Size(42, 12);
            this.centerLbl.TabIndex = 28;
            this.centerLbl.Text = "Center";
            this.centerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insetLbl
            // 
            this.insetLbl.AutoSize = true;
            this.insetLbl.BackColor = System.Drawing.Color.Transparent;
            this.insetLbl.Location = new System.Drawing.Point(258, 242);
            this.insetLbl.Name = "insetLbl";
            this.insetLbl.Size = new System.Drawing.Size(32, 12);
            this.insetLbl.TabIndex = 29;
            this.insetLbl.Text = "Inset";
            this.insetLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "문자열+a의 길이 - a의 길이 = 문자열의 길이";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = ".PenAlignment 속성을 변경하면, 두께 기준선이 바뀐다.";
            // 
            // PenAlignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(323, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insetLbl);
            this.Controls.Add(this.centerLbl);
            this.Controls.Add(this.drawDashesBtn);
            this.Controls.Add(this.closeBtn);
            this.Name = "PenAlignmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PenAlignmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls_dll.MetalButton closeBtn;
        private CustomControls_dll.MetalButton drawDashesBtn;
        private System.Windows.Forms.Label centerLbl;
        private System.Windows.Forms.Label insetLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}