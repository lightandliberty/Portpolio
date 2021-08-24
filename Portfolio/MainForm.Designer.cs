namespace Portfolio
{
    partial class MainForm
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
            this.RawInputBtn = new System.Windows.Forms.Button();
            this.OCRBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RawInputBtn
            // 
            this.RawInputBtn.Location = new System.Drawing.Point(671, 12);
            this.RawInputBtn.Name = "RawInputBtn";
            this.RawInputBtn.Size = new System.Drawing.Size(117, 36);
            this.RawInputBtn.TabIndex = 0;
            this.RawInputBtn.Text = "RawInput";
            this.RawInputBtn.UseVisualStyleBackColor = true;
            this.RawInputBtn.Click += new System.EventHandler(this.RawInputBtn_Click);
            // 
            // OCRBtn
            // 
            this.OCRBtn.Location = new System.Drawing.Point(671, 54);
            this.OCRBtn.Name = "OCRBtn";
            this.OCRBtn.Size = new System.Drawing.Size(117, 36);
            this.OCRBtn.TabIndex = 1;
            this.OCRBtn.Text = "OCR";
            this.OCRBtn.UseVisualStyleBackColor = true;
            this.OCRBtn.Click += new System.EventHandler(this.OCRBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "BasicProperties";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BasicPropertiesBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OCRBtn);
            this.Controls.Add(this.RawInputBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RawInputBtn;
        private System.Windows.Forms.Button OCRBtn;
        private System.Windows.Forms.Button button1;
    }
}