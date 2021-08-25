namespace BasicProperties_dll
{
    partial class TransparentForm
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
            this.CenterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CenterBtn
            // 
            this.CenterBtn.Location = new System.Drawing.Point(144, 117);
            this.CenterBtn.Name = "CenterBtn";
            this.CenterBtn.Size = new System.Drawing.Size(157, 48);
            this.CenterBtn.TabIndex = 0;
            this.CenterBtn.Text = "타원 TransparentForm";
            this.CenterBtn.UseVisualStyleBackColor = true;
            // 
            // TransparentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 285);
            this.Controls.Add(this.CenterBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransparentForm";
            this.Text = "TransparentForm";
            this.Load += new System.EventHandler(this.TransparentForm_Load);
            this.SizeChanged += new System.EventHandler(this.TransparentForm_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TransparentForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TransparentForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TransparentForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TransparentForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CenterBtn;
    }
}