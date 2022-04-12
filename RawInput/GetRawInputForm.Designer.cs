
namespace RawInput_dll
{
    partial class GetRawInputForm
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
            this.CloseFormBtn = new CustomControls_dll.MetalButton();
            this.instLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keyboardNameLbl = new System.Windows.Forms.Label();
            this.mouseNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseFormBtn
            // 
            this.CloseFormBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseFormBtn.Location = new System.Drawing.Point(282, 397);
            this.CloseFormBtn.Name = "CloseFormBtn";
            this.CloseFormBtn.Size = new System.Drawing.Size(112, 36);
            this.CloseFormBtn.TabIndex = 8;
            this.CloseFormBtn.Text = "종료";
            this.CloseFormBtn.UseVisualStyleBackColor = true;
            this.CloseFormBtn.Click += new System.EventHandler(this.CloseFormBtn_Click);
            // 
            // instLbl
            // 
            this.instLbl.AutoSize = true;
            this.instLbl.Location = new System.Drawing.Point(92, 42);
            this.instLbl.Name = "instLbl";
            this.instLbl.Size = new System.Drawing.Size(233, 36);
            this.instLbl.TabIndex = 9;
            this.instLbl.Text = "마우스를 움직이거나 키보드를 누르면,\r\n장치의 이름이 자동으로 입력됩니다.\r\n입력이 완료되면, 자동으로 창이 닫힙니다.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "키보드 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "마우스 이름";
            // 
            // keyboardNameLbl
            // 
            this.keyboardNameLbl.Location = new System.Drawing.Point(85, 107);
            this.keyboardNameLbl.Name = "keyboardNameLbl";
            this.keyboardNameLbl.Size = new System.Drawing.Size(303, 107);
            this.keyboardNameLbl.TabIndex = 12;
            this.keyboardNameLbl.Text = "label3";
            // 
            // mouseNameLbl
            // 
            this.mouseNameLbl.Location = new System.Drawing.Point(85, 221);
            this.mouseNameLbl.Name = "mouseNameLbl";
            this.mouseNameLbl.Size = new System.Drawing.Size(303, 107);
            this.mouseNameLbl.TabIndex = 13;
            this.mouseNameLbl.Text = "label4";
            // 
            // GetRawInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseFormBtn;
            this.ClientSize = new System.Drawing.Size(401, 440);
            this.Controls.Add(this.mouseNameLbl);
            this.Controls.Add(this.keyboardNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instLbl);
            this.Controls.Add(this.CloseFormBtn);
            this.Name = "GetRawInputForm";
            this.Text = "GetRawInputForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GetRawInputForm_FormClosing);
            this.Shown += new System.EventHandler(this.GetRawInputForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls_dll.MetalButton CloseFormBtn;
        private System.Windows.Forms.Label instLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label keyboardNameLbl;
        private System.Windows.Forms.Label mouseNameLbl;
    }
}