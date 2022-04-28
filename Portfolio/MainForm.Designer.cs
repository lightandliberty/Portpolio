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
            this.mainNeonSBtn = new CustomControls_dll.ShadowButton();
            this.leftSPnl = new CustomControls_dll.ShadowPanel();
            this.bgSPn = new CustomControls_dll.ShadowPanel();
            this.shadowPanel3 = new CustomControls_dll.ShadowPanel();
            this.menuStrip1.SuspendLayout();
            this.leftSPnl.SuspendLayout();
            this.bgSPn.SuspendLayout();
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
            this.BasicPropertiesBtn.Location = new System.Drawing.Point(13, 27);
            this.BasicPropertiesBtn.Name = "BasicPropertiesBtn";
            this.BasicPropertiesBtn.Size = new System.Drawing.Size(112, 36);
            this.BasicPropertiesBtn.TabIndex = 5;
            this.BasicPropertiesBtn.Text = "BasicProperties";
            this.BasicPropertiesBtn.UseVisualStyleBackColor = true;
            this.BasicPropertiesBtn.Click += new System.EventHandler(this.BasicPropertiesBtn_Click);
            // 
            // neonButtonProjectBtn
            // 
            this.neonButtonProjectBtn.Location = new System.Drawing.Point(13, 69);
            this.neonButtonProjectBtn.Name = "neonButtonProjectBtn";
            this.neonButtonProjectBtn.Size = new System.Drawing.Size(112, 36);
            this.neonButtonProjectBtn.TabIndex = 8;
            this.neonButtonProjectBtn.Text = "Neon Buttons";
            this.neonButtonProjectBtn.UseVisualStyleBackColor = true;
            this.neonButtonProjectBtn.Click += new System.EventHandler(this.NeonButtonProjectBtn_Click);
            // 
            // DrawingMetalBtn
            // 
            this.DrawingMetalBtn.Location = new System.Drawing.Point(13, 188);
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
            this.MultiThreadBtn.Location = new System.Drawing.Point(13, 230);
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
            // mainNeonSBtn
            // 
            this.mainNeonSBtn.BackColor = System.Drawing.Color.Transparent;
            this.mainNeonSBtn.BackgroundGradientMode = CustomControls_dll.PanelGradientMode.Vertical;
            this.mainNeonSBtn.EdgeWidth = 5;
            this.mainNeonSBtn.EndColor = System.Drawing.Color.Magenta;
            this.mainNeonSBtn.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.mainNeonSBtn.FocusScaleHeight = 0.65F;
            this.mainNeonSBtn.FocusScaleWidth = 0.77F;
            this.mainNeonSBtn.Location = new System.Drawing.Point(210, 45);
            this.mainNeonSBtn.Name = "mainNeonSBtn";
            this.mainNeonSBtn.NeonColor = System.Drawing.Color.Magenta;
            this.mainNeonSBtn.RectRadius = 20;
            this.mainNeonSBtn.ShadowColor = System.Drawing.Color.Magenta;
            this.mainNeonSBtn.ShadowShift = 20;
            this.mainNeonSBtn.ShadowStyle = CustomControls_dll.ShadowMode.Surrounded;
            this.mainNeonSBtn.Size = new System.Drawing.Size(281, 99);
            this.mainNeonSBtn.StartColor = System.Drawing.Color.Magenta;
            this.mainNeonSBtn.Style = CustomControls_dll.BevelStyle.Neon;
            this.mainNeonSBtn.TabIndex = 14;
            this.mainNeonSBtn.Text = "mainNeonSBtn";
            this.mainNeonSBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.mainNeonSBtn.UseVisualStyleBackColor = false;
            this.mainNeonSBtn.Click += new System.EventHandler(this.shadowButton1_Click);
            // 
            // leftSPnl
            // 
            this.leftSPnl.BackColor = System.Drawing.Color.Transparent;
            this.leftSPnl.BackgroundGradientMode = CustomControls_dll.PanelGradientMode.Vertical;
            this.leftSPnl.Controls.Add(this.BasicPropertiesBtn);
            this.leftSPnl.Controls.Add(this.neonButtonProjectBtn);
            this.leftSPnl.Controls.Add(this.DrawingMetalBtn);
            this.leftSPnl.Controls.Add(this.MultiThreadBtn);
            this.leftSPnl.EdgeWidth = 2;
            this.leftSPnl.EndColor = System.Drawing.Color.Pink;
            this.leftSPnl.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.leftSPnl.FocusScaleHeight = 0.85F;
            this.leftSPnl.FocusScaleWidth = 0.95F;
            this.leftSPnl.Location = new System.Drawing.Point(12, 39);
            this.leftSPnl.Name = "leftSPnl";
            this.leftSPnl.NeonColor = System.Drawing.Color.Pink;
            this.leftSPnl.RectRadius = 20;
            this.leftSPnl.ShadowColor = System.Drawing.Color.DimGray;
            this.leftSPnl.ShadowShift = 10;
            this.leftSPnl.ShadowStyle = CustomControls_dll.ShadowMode.ForwardDiagonal;
            this.leftSPnl.Size = new System.Drawing.Size(154, 306);
            this.leftSPnl.StartColor = System.Drawing.Color.White;
            this.leftSPnl.Style = CustomControls_dll.BevelStyle.Flat;
            this.leftSPnl.TabIndex = 15;
            this.leftSPnl.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.leftSPnl.TextString = "";
            // 
            // bgSPn
            // 
            this.bgSPn.BackgroundGradientMode = CustomControls_dll.PanelGradientMode.Vertical;
            this.bgSPn.BackgroundImage = global::Portfolio.Properties.Resources.customer_bg1;
            this.bgSPn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bgSPn.Controls.Add(this.mainNeonSBtn);
            this.bgSPn.Controls.Add(this.shadowPanel3);
            this.bgSPn.Controls.Add(this.leftSPnl);
            this.bgSPn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgSPn.EdgeWidth = 5;
            this.bgSPn.EndColor = System.Drawing.Color.Transparent;
            this.bgSPn.FlatBorderColor = System.Drawing.Color.White;
            this.bgSPn.FocusScaleHeight = 0.1F;
            this.bgSPn.FocusScaleWidth = 0.1F;
            this.bgSPn.Location = new System.Drawing.Point(0, 0);
            this.bgSPn.Name = "bgSPn";
            this.bgSPn.NeonColor = System.Drawing.Color.Transparent;
            this.bgSPn.RectRadius = 20;
            this.bgSPn.ShadowColor = System.Drawing.Color.DimGray;
            this.bgSPn.ShadowShift = 0;
            this.bgSPn.ShadowStyle = CustomControls_dll.ShadowMode.Surrounded;
            this.bgSPn.Size = new System.Drawing.Size(800, 450);
            this.bgSPn.StartColor = System.Drawing.Color.White;
            this.bgSPn.Style = CustomControls_dll.BevelStyle.GradientNeon;
            this.bgSPn.TabIndex = 17;
            this.bgSPn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.bgSPn.TextString = "";
            // 
            // shadowPanel3
            // 
            this.shadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.shadowPanel3.BackgroundGradientMode = CustomControls_dll.PanelGradientMode.Vertical;
            this.shadowPanel3.EdgeWidth = 5;
            this.shadowPanel3.EndColor = System.Drawing.Color.Transparent;
            this.shadowPanel3.FlatBorderColor = System.Drawing.Color.White;
            this.shadowPanel3.FocusScaleHeight = 0.65F;
            this.shadowPanel3.FocusScaleWidth = 0.77F;
            this.shadowPanel3.Location = new System.Drawing.Point(12, 349);
            this.shadowPanel3.Name = "shadowPanel3";
            this.shadowPanel3.NeonColor = System.Drawing.Color.Transparent;
            this.shadowPanel3.RectRadius = 20;
            this.shadowPanel3.ShadowColor = System.Drawing.Color.DimGray;
            this.shadowPanel3.ShadowShift = 20;
            this.shadowPanel3.ShadowStyle = CustomControls_dll.ShadowMode.ForwardDiagonal;
            this.shadowPanel3.Size = new System.Drawing.Size(154, 98);
            this.shadowPanel3.StartColor = System.Drawing.Color.White;
            this.shadowPanel3.Style = CustomControls_dll.BevelStyle.Raised;
            this.shadowPanel3.TabIndex = 18;
            this.shadowPanel3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.shadowPanel3.TextString = "Material";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.CancelButton = this.CloseFormBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RawInputBtn);
            this.Controls.Add(this.neonCloseBtn);
            this.Controls.Add(this.enterNeonModeBtn);
            this.Controls.Add(this.CloseFormBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bgSPn);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.leftSPnl.ResumeLayout(false);
            this.bgSPn.ResumeLayout(false);
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
        private CustomControls_dll.ShadowButton mainNeonSBtn;
        private CustomControls_dll.ShadowPanel leftSPnl;
        private CustomControls_dll.ShadowPanel bgSPn;
        private CustomControls_dll.ShadowPanel shadowPanel3;
    }
}