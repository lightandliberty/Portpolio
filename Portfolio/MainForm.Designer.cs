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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.버전정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseFormBtn = new CustomControls_dll.MetalButton();
            this.RawInputBtn = new CustomControls_dll.MetalButton();
            this.BasicPropertiesBtn = new CustomControls_dll.MetalButton();
            this.neonButtonProjectBtn = new CustomControls_dll.MetalButton();
            this.DrawingMetalBtn = new CustomControls_dll.MetalButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.버전정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 버전정보ToolStripMenuItem
            // 
            this.버전정보ToolStripMenuItem.Name = "버전정보ToolStripMenuItem";
            this.버전정보ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.버전정보ToolStripMenuItem.Text = "버전 정보";
            this.버전정보ToolStripMenuItem.Click += new System.EventHandler(this.버전정보ToolStripMenuItem_Click);
            // 
            // CloseFormBtn
            // 
            this.CloseFormBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseFormBtn.Location = new System.Drawing.Point(676, 402);
            this.CloseFormBtn.Name = "CloseFormBtn";
            this.CloseFormBtn.Size = new System.Drawing.Size(112, 36);
            this.CloseFormBtn.TabIndex = 7;
            this.CloseFormBtn.Text = "종료";
            this.CloseFormBtn.UseVisualStyleBackColor = true;
            this.CloseFormBtn.Click += new System.EventHandler(this.CloseFormBtn_Click);
            // 
            // RawInputBtn
            // 
            this.RawInputBtn.Location = new System.Drawing.Point(676, 39);
            this.RawInputBtn.Name = "RawInputBtn";
            this.RawInputBtn.Size = new System.Drawing.Size(112, 36);
            this.RawInputBtn.TabIndex = 6;
            this.RawInputBtn.Text = "RawInput";
            this.RawInputBtn.UseVisualStyleBackColor = true;
            this.RawInputBtn.Click += new System.EventHandler(this.RawInputBtn_Click);
            // 
            // BasicPropertiesBtn
            // 
            this.BasicPropertiesBtn.Location = new System.Drawing.Point(12, 39);
            this.BasicPropertiesBtn.Name = "BasicPropertiesBtn";
            this.BasicPropertiesBtn.Size = new System.Drawing.Size(112, 36);
            this.BasicPropertiesBtn.TabIndex = 5;
            this.BasicPropertiesBtn.Text = "BasicProperties";
            this.BasicPropertiesBtn.UseVisualStyleBackColor = true;
            this.BasicPropertiesBtn.Click += new System.EventHandler(this.BasicPropertiesBtn_Click);
            // 
            // neonButtonProjectBtn
            // 
            this.neonButtonProjectBtn.Location = new System.Drawing.Point(12, 90);
            this.neonButtonProjectBtn.Name = "neonButtonProjectBtn";
            this.neonButtonProjectBtn.Size = new System.Drawing.Size(112, 36);
            this.neonButtonProjectBtn.TabIndex = 8;
            this.neonButtonProjectBtn.Text = "Neon Buttons";
            this.neonButtonProjectBtn.UseVisualStyleBackColor = true;
            this.neonButtonProjectBtn.Click += new System.EventHandler(this.NeonButtonProjectBtn_Click);
            // 
            // DrawingMetalBtn
            // 
            this.DrawingMetalBtn.Location = new System.Drawing.Point(12, 217);
            this.DrawingMetalBtn.Name = "DrawingMetalBtn";
            this.DrawingMetalBtn.Size = new System.Drawing.Size(112, 36);
            this.DrawingMetalBtn.TabIndex = 9;
            this.DrawingMetalBtn.Text = "Drawing";
            this.DrawingMetalBtn.UseVisualStyleBackColor = true;
            this.DrawingMetalBtn.Click += new System.EventHandler(this.DrawingMetalBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseFormBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DrawingMetalBtn);
            this.Controls.Add(this.neonButtonProjectBtn);
            this.Controls.Add(this.CloseFormBtn);
            this.Controls.Add(this.RawInputBtn);
            this.Controls.Add(this.BasicPropertiesBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 버전정보ToolStripMenuItem;
        private CustomControls_dll.MetalButton BasicPropertiesBtn;
        private CustomControls_dll.MetalButton RawInputBtn;
        private CustomControls_dll.MetalButton CloseFormBtn;
        private CustomControls_dll.MetalButton neonButtonProjectBtn;
        private CustomControls_dll.MetalButton DrawingMetalBtn;
    }
}