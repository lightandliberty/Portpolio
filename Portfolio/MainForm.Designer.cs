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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.버전정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseFormBtn = new CustomControls_dll.MetalButton();
            this.BasicPropertiesBtn = new CustomControls_dll.MetalButton();
            this.neonButtonProjectBtn = new CustomControls_dll.MetalButton();
            this.DrawingMetalBtn = new CustomControls_dll.MetalButton();
            this.enterNeonModeBtn = new CustomControls_dll.NeonButton();
            this.neonCloseBtn = new CustomControls_dll.NeonButton();
            this.neonChangeIntervalTimer = new System.Windows.Forms.Timer(this.components);
            this.MultiThreadBtn = new CustomControls_dll.MetalButton();
            this.RawInputBtn = new CustomControls_dll.MetalButton();
            this.shadowButton1 = new CustomControls_dll.ShadowButton();
            this.shadowButton2 = new CustomControls_dll.ShadowButton();
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
            // BasicPropertiesBtn
            // 
            this.BasicPropertiesBtn.Location = new System.Drawing.Point(24, 39);
            this.BasicPropertiesBtn.Name = "BasicPropertiesBtn";
            this.BasicPropertiesBtn.Size = new System.Drawing.Size(112, 36);
            this.BasicPropertiesBtn.TabIndex = 5;
            this.BasicPropertiesBtn.Text = "BasicProperties";
            this.BasicPropertiesBtn.UseVisualStyleBackColor = true;
            this.BasicPropertiesBtn.Click += new System.EventHandler(this.BasicPropertiesBtn_Click);
            // 
            // neonButtonProjectBtn
            // 
            this.neonButtonProjectBtn.Location = new System.Drawing.Point(24, 90);
            this.neonButtonProjectBtn.Name = "neonButtonProjectBtn";
            this.neonButtonProjectBtn.Size = new System.Drawing.Size(112, 36);
            this.neonButtonProjectBtn.TabIndex = 8;
            this.neonButtonProjectBtn.Text = "Neon Buttons";
            this.neonButtonProjectBtn.UseVisualStyleBackColor = true;
            this.neonButtonProjectBtn.Click += new System.EventHandler(this.NeonButtonProjectBtn_Click);
            // 
            // DrawingMetalBtn
            // 
            this.DrawingMetalBtn.Location = new System.Drawing.Point(24, 208);
            this.DrawingMetalBtn.Name = "DrawingMetalBtn";
            this.DrawingMetalBtn.Size = new System.Drawing.Size(112, 36);
            this.DrawingMetalBtn.TabIndex = 9;
            this.DrawingMetalBtn.Text = "Drawing";
            this.DrawingMetalBtn.UseVisualStyleBackColor = true;
            this.DrawingMetalBtn.Click += new System.EventHandler(this.DrawingMetalBtn_Click);
            // 
            // enterNeonModeBtn
            // 
            this.enterNeonModeBtn.ButtonColor = CustomControls_dll.NeonButton.KeyColor.Pink;
            this.enterNeonModeBtn.Location = new System.Drawing.Point(676, 39);
            this.enterNeonModeBtn.Name = "enterNeonModeBtn";
            this.enterNeonModeBtn.Size = new System.Drawing.Size(112, 36);
            this.enterNeonModeBtn.TabIndex = 10;
            this.enterNeonModeBtn.Text = "Neon Mode";
            this.enterNeonModeBtn.UseVisualStyleBackColor = true;
            this.enterNeonModeBtn.Click += new System.EventHandler(this.EnterNeonModeBtn_Click);
            this.enterNeonModeBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EnterNeonModeBtn_MouseDown);
            // 
            // neonCloseBtn
            // 
            this.neonCloseBtn.ButtonColor = CustomControls_dll.NeonButton.KeyColor.Pink;
            this.neonCloseBtn.Location = new System.Drawing.Point(676, 340);
            this.neonCloseBtn.Name = "neonCloseBtn";
            this.neonCloseBtn.Size = new System.Drawing.Size(112, 36);
            this.neonCloseBtn.TabIndex = 11;
            this.neonCloseBtn.Text = "종료";
            this.neonCloseBtn.UseVisualStyleBackColor = true;
            this.neonCloseBtn.Visible = false;
            this.neonCloseBtn.Click += new System.EventHandler(this.neonCloseBtn_Click);
            // 
            // neonChangeIntervalTimer
            // 
            this.neonChangeIntervalTimer.Interval = 500;
            this.neonChangeIntervalTimer.Tick += new System.EventHandler(this.NeonChangeIntervalTimer_Tick);
            // 
            // MultiThreadBtn
            // 
            this.MultiThreadBtn.Location = new System.Drawing.Point(24, 265);
            this.MultiThreadBtn.Name = "MultiThreadBtn";
            this.MultiThreadBtn.Size = new System.Drawing.Size(112, 36);
            this.MultiThreadBtn.TabIndex = 12;
            this.MultiThreadBtn.Text = "Multi Thread";
            this.MultiThreadBtn.UseVisualStyleBackColor = true;
            this.MultiThreadBtn.Click += new System.EventHandler(this.MultiThreadBtn_Click);
            // 
            // RawInputBtn
            // 
            this.RawInputBtn.Location = new System.Drawing.Point(676, 90);
            this.RawInputBtn.Name = "RawInputBtn";
            this.RawInputBtn.Size = new System.Drawing.Size(112, 36);
            this.RawInputBtn.TabIndex = 13;
            this.RawInputBtn.Text = "RawInput";
            this.RawInputBtn.UseVisualStyleBackColor = true;
            this.RawInputBtn.Click += new System.EventHandler(this.getRawInputBtn_Click);
            // 
            // shadowButton1
            // 
            this.shadowButton1.BackColor = System.Drawing.Color.Transparent;
            this.shadowButton1.BackgroundGradientMode = CustomControls_dll.PanelGradientMode.Vertical;
            this.shadowButton1.EdgeWidth = 0;
            this.shadowButton1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.shadowButton1.FlatAppearance.BorderSize = 0;
            this.shadowButton1.FlatBorderColor = System.Drawing.Color.ForestGreen;
            this.shadowButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shadowButton1.FocusScaleHeight = 0.85F;
            this.shadowButton1.FocusScaleWidth = 0.95F;
            this.shadowButton1.Location = new System.Drawing.Point(188, 90);
            this.shadowButton1.Name = "shadowButton1";
            this.shadowButton1.NeonColor = CustomControls_dll.NeonColor.Pink;
            this.shadowButton1.RectRadius = 20;
            this.shadowButton1.ShadowColor = System.Drawing.Color.DimGray;
            this.shadowButton1.ShadowShift = 20;
            this.shadowButton1.ShadowStyle = CustomControls_dll.ShadowMode.ForwardDiagonal;
            this.shadowButton1.Size = new System.Drawing.Size(186, 73);
            this.shadowButton1.StartColor = System.Drawing.Color.ForestGreen;
            this.shadowButton1.Style = CustomControls_dll.BevelStyle.Raised;
            this.shadowButton1.TabIndex = 14;
            this.shadowButton1.Text = "Shadow Button";
            this.shadowButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.shadowButton1.UseVisualStyleBackColor = false;
            // 
            // shadowButton2
            // 
            this.shadowButton2.BackColor = System.Drawing.Color.Transparent;
            this.shadowButton2.BackgroundGradientMode = CustomControls_dll.PanelGradientMode.Vertical;
            this.shadowButton2.EdgeWidth = -5;
            this.shadowButton2.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(190)))));
            this.shadowButton2.FlatAppearance.BorderSize = 0;
            this.shadowButton2.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(190)))));
            this.shadowButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shadowButton2.FocusScaleHeight = 0.65F;
            this.shadowButton2.FocusScaleWidth = 0.77F;
            this.shadowButton2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.shadowButton2.Location = new System.Drawing.Point(188, 171);
            this.shadowButton2.Name = "shadowButton2";
            this.shadowButton2.NeonColor = CustomControls_dll.NeonColor.Pink;
            this.shadowButton2.RectRadius = 20;
            this.shadowButton2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(190)))));
            this.shadowButton2.ShadowShift = 20;
            this.shadowButton2.ShadowStyle = CustomControls_dll.ShadowMode.Surrounded;
            this.shadowButton2.Size = new System.Drawing.Size(227, 106);
            this.shadowButton2.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(190)))));
            this.shadowButton2.Style = CustomControls_dll.BevelStyle.Neon;
            this.shadowButton2.TabIndex = 15;
            this.shadowButton2.Text = "Neon";
            this.shadowButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.shadowButton2.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.CancelButton = this.CloseFormBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shadowButton2);
            this.Controls.Add(this.shadowButton1);
            this.Controls.Add(this.RawInputBtn);
            this.Controls.Add(this.MultiThreadBtn);
            this.Controls.Add(this.neonCloseBtn);
            this.Controls.Add(this.enterNeonModeBtn);
            this.Controls.Add(this.DrawingMetalBtn);
            this.Controls.Add(this.neonButtonProjectBtn);
            this.Controls.Add(this.CloseFormBtn);
            this.Controls.Add(this.BasicPropertiesBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private CustomControls_dll.MetalButton CloseFormBtn;
        private CustomControls_dll.MetalButton neonButtonProjectBtn;
        private CustomControls_dll.MetalButton DrawingMetalBtn;
        private CustomControls_dll.NeonButton enterNeonModeBtn;
        private CustomControls_dll.NeonButton neonCloseBtn;
        private System.Windows.Forms.Timer neonChangeIntervalTimer;
        private CustomControls_dll.MetalButton MultiThreadBtn;
        private CustomControls_dll.MetalButton RawInputBtn;
        private CustomControls_dll.ShadowButton shadowButton1;
        private CustomControls_dll.ShadowButton shadowButton2;
    }
}