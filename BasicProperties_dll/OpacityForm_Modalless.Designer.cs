namespace BasicProperties_dll
{
    partial class OpacityForm_Modalless
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
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.TickResetBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Location = new System.Drawing.Point(57, 51);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(75, 23);
            this.AcceptBtn.TabIndex = 0;
            this.AcceptBtn.Text = "Accept";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // TickResetBtn
            // 
            this.TickResetBtn.Location = new System.Drawing.Point(166, 51);
            this.TickResetBtn.Name = "TickResetBtn";
            this.TickResetBtn.Size = new System.Drawing.Size(75, 23);
            this.TickResetBtn.TabIndex = 1;
            this.TickResetBtn.Text = "TickReset";
            this.TickResetBtn.UseVisualStyleBackColor = true;
            this.TickResetBtn.Click += new System.EventHandler(this.TickResetBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(277, 51);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // OpacityForm_Modalless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 115);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.TickResetBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Name = "OpacityForm_Modalless";
            this.Text = "OpacityForm_Modalless";
            this.Activated += new System.EventHandler(this.OpacityForm_Modalless_Activated);
            this.Deactivate += new System.EventHandler(this.OpacityForm_Modalless_Deactivate);
            this.Load += new System.EventHandler(this.OpacityForm_Modalless_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button AcceptBtn;
        public System.Windows.Forms.Button TickResetBtn;
        public System.Windows.Forms.Button CloseBtn;
        public System.Windows.Forms.Timer timer1;
    }
}