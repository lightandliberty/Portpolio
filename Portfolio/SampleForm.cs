using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio
{
	class SampleForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
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
            this.instructionLbl = new System.Windows.Forms.Label();
            this.drawJoinsBtn = new CustomControls_dll.MetalButton();
            this.closeBtn = new CustomControls_dll.MetalButton();
            this.SuspendLayout();
            // 
            // instructionLbl
            // 
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Location = new System.Drawing.Point(12, 205);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(264, 24);
            this.instructionLbl.TabIndex = 32;
            this.instructionLbl.Text = "MiterClipped는 Miter와 같아 보이지만, \r\n각도에 따라 Bevel 또는 Miter로 효과가 변경 됨.";
            // 
            // drawJoinsBtn
            // 
            this.drawJoinsBtn.Location = new System.Drawing.Point(235, 232);
            this.drawJoinsBtn.Name = "drawJoinsBtn";
            this.drawJoinsBtn.Size = new System.Drawing.Size(91, 28);
            this.drawJoinsBtn.TabIndex = 31;
            this.drawJoinsBtn.Text = "Draw Joins";
            this.drawJoinsBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(12, 226);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(0, 0);
            this.closeBtn.TabIndex = 30;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // SampleForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(334, 269);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.drawJoinsBtn);
            this.Controls.Add(this.closeBtn);
            this.Name = "SampleForm";
            this.Text = "sample";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Label instructionLbl;
		private CustomControls_dll.MetalButton drawJoinsBtn;
		private CustomControls_dll.MetalButton closeBtn;

    }
}