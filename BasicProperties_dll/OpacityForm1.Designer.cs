namespace BasicProperties_dll
{
    partial class OpacityForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CenterBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // CenterBtn
            // 
            this.CenterBtn.Location = new System.Drawing.Point(160, 44);
            this.CenterBtn.Name = "CenterBtn";
            this.CenterBtn.Size = new System.Drawing.Size(114, 23);
            this.CenterBtn.TabIndex = 2;
            this.CenterBtn.Text = "ResetTimer";
            this.CenterBtn.UseVisualStyleBackColor = true;
            this.CenterBtn.Click += new System.EventHandler(this.CenterBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.Location = new System.Drawing.Point(315, 44);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "종료";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.FormCloseBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(47, 44);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 0;
            this.ConfirmBtn.Text = "확인";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            // 
            // OpacityForm
            // 
            this.AcceptButton = this.CenterBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(420, 112);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.CenterBtn);
            this.Name = "OpacityForm";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.OpacityForm_Activated);
            this.Deactivate += new System.EventHandler(this.OpacityForm_Deactivate);
            this.Load += new System.EventHandler(this.OpacityForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button CenterBtn;
        public System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}