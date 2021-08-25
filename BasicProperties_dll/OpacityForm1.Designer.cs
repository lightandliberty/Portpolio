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
            this.CenterBtn.TabIndex = 0;
            this.CenterBtn.Text = "Click On Me!";
            this.CenterBtn.UseVisualStyleBackColor = true;
            this.CenterBtn.Click += new System.EventHandler(this.CenterBtn_Click);
            // 
            // OpacityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 112);
            this.Controls.Add(this.CenterBtn);
            this.Name = "OpacityForm";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.OpacityForm_Activated);
            this.Deactivate += new System.EventHandler(this.OpacityForm_Deactivate);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CenterBtn;
    }
}