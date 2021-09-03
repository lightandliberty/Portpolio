﻿namespace BasicProperties_dll
{
    partial class Properties
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopMostBtn = new System.Windows.Forms.Button();
            this.ReadFromAppConfigBtn = new System.Windows.Forms.Button();
            this.LoadBitmapBtn = new System.Windows.Forms.Button();
            this.ChangeFormBorderStyleBtn = new System.Windows.Forms.Button();
            this.SetControlBoxBtn = new System.Windows.Forms.Button();
            this.SetMaxiMiniBtn = new System.Windows.Forms.Button();
            this.instructionTextBox = new System.Windows.Forms.TextBox();
            this.SetHelpIconBtn = new System.Windows.Forms.Button();
            this.SetSizeGripStyleBtn = new System.Windows.Forms.Button();
            this.SetShowInTaskbarBtn = new System.Windows.Forms.Button();
            this.PopupOpacityFormBtn = new System.Windows.Forms.Button();
            this.CreateTransparentFormBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.버전정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.foreColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetFlatAppearenceBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IsAnchorLabel = new System.Windows.Forms.Label();
            this.ProcessLayoutEventBtn = new System.Windows.Forms.Button();
            this.MDIBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMostBtn
            // 
            this.TopMostBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMostBtn.Location = new System.Drawing.Point(57, 198);
            this.TopMostBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TopMostBtn.Name = "TopMostBtn";
            this.TopMostBtn.Size = new System.Drawing.Size(286, 34);
            this.TopMostBtn.TabIndex = 0;
            this.TopMostBtn.Text = "최상위창";
            this.TopMostBtn.UseVisualStyleBackColor = true;
            this.TopMostBtn.Click += new System.EventHandler(this.TopMostBtn_Click);
            // 
            // ReadFromAppConfigBtn
            // 
            this.ReadFromAppConfigBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadFromAppConfigBtn.Location = new System.Drawing.Point(57, 154);
            this.ReadFromAppConfigBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReadFromAppConfigBtn.Name = "ReadFromAppConfigBtn";
            this.ReadFromAppConfigBtn.Size = new System.Drawing.Size(286, 34);
            this.ReadFromAppConfigBtn.TabIndex = 2;
            this.ReadFromAppConfigBtn.Text = "App.config에서 값 읽어오기";
            this.ReadFromAppConfigBtn.UseVisualStyleBackColor = true;
            this.ReadFromAppConfigBtn.Click += new System.EventHandler(this.ReadFromAppConfigBtn_Click);
            // 
            // LoadBitmapBtn
            // 
            this.LoadBitmapBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadBitmapBtn.Location = new System.Drawing.Point(57, 242);
            this.LoadBitmapBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadBitmapBtn.Name = "LoadBitmapBtn";
            this.LoadBitmapBtn.Size = new System.Drawing.Size(286, 34);
            this.LoadBitmapBtn.TabIndex = 3;
            this.LoadBitmapBtn.Text = "c:\\cocoa.png 파일 나타내기";
            this.LoadBitmapBtn.UseVisualStyleBackColor = true;
            this.LoadBitmapBtn.Click += new System.EventHandler(this.LoadBitmapBtn_Click);
            // 
            // ChangeFormBorderStyleBtn
            // 
            this.ChangeFormBorderStyleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeFormBorderStyleBtn.Location = new System.Drawing.Point(57, 285);
            this.ChangeFormBorderStyleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChangeFormBorderStyleBtn.Name = "ChangeFormBorderStyleBtn";
            this.ChangeFormBorderStyleBtn.Size = new System.Drawing.Size(286, 34);
            this.ChangeFormBorderStyleBtn.TabIndex = 4;
            this.ChangeFormBorderStyleBtn.Text = "FormBorderStyle속성 설정";
            this.ChangeFormBorderStyleBtn.UseVisualStyleBackColor = true;
            this.ChangeFormBorderStyleBtn.Click += new System.EventHandler(this.ChangeFormBorderStyleBtn_Click);
            // 
            // SetControlBoxBtn
            // 
            this.SetControlBoxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetControlBoxBtn.Location = new System.Drawing.Point(57, 328);
            this.SetControlBoxBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SetControlBoxBtn.Name = "SetControlBoxBtn";
            this.SetControlBoxBtn.Size = new System.Drawing.Size(286, 34);
            this.SetControlBoxBtn.TabIndex = 5;
            this.SetControlBoxBtn.Text = "ControlBox 속성 변경";
            this.SetControlBoxBtn.UseVisualStyleBackColor = true;
            this.SetControlBoxBtn.Click += new System.EventHandler(this.SetControlBoxBtn_Click);
            // 
            // SetMaxiMiniBtn
            // 
            this.SetMaxiMiniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetMaxiMiniBtn.Location = new System.Drawing.Point(57, 372);
            this.SetMaxiMiniBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SetMaxiMiniBtn.Name = "SetMaxiMiniBtn";
            this.SetMaxiMiniBtn.Size = new System.Drawing.Size(286, 34);
            this.SetMaxiMiniBtn.TabIndex = 6;
            this.SetMaxiMiniBtn.Text = "MaximizeBox MinimizeBox 속성";
            this.SetMaxiMiniBtn.UseVisualStyleBackColor = true;
            this.SetMaxiMiniBtn.Click += new System.EventHandler(this.SetMaxiMiniBtn_Click);
            // 
            // instructionTextBox
            // 
            this.instructionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionTextBox.Location = new System.Drawing.Point(57, 60);
            this.instructionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.instructionTextBox.Multiline = true;
            this.instructionTextBox.Name = "instructionTextBox";
            this.instructionTextBox.Size = new System.Drawing.Size(941, 79);
            this.instructionTextBox.TabIndex = 7;
            // 
            // SetHelpIconBtn
            // 
            this.SetHelpIconBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetHelpIconBtn.Location = new System.Drawing.Point(57, 416);
            this.SetHelpIconBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SetHelpIconBtn.Name = "SetHelpIconBtn";
            this.SetHelpIconBtn.Size = new System.Drawing.Size(286, 34);
            this.SetHelpIconBtn.TabIndex = 8;
            this.SetHelpIconBtn.Text = "HelpButton 속성";
            this.SetHelpIconBtn.UseVisualStyleBackColor = true;
            this.SetHelpIconBtn.Click += new System.EventHandler(this.SetHelpIconBtn_Click);
            // 
            // SetSizeGripStyleBtn
            // 
            this.SetSizeGripStyleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetSizeGripStyleBtn.Location = new System.Drawing.Point(57, 459);
            this.SetSizeGripStyleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SetSizeGripStyleBtn.Name = "SetSizeGripStyleBtn";
            this.SetSizeGripStyleBtn.Size = new System.Drawing.Size(286, 34);
            this.SetSizeGripStyleBtn.TabIndex = 9;
            this.SetSizeGripStyleBtn.Text = "SetSizeGripStyle 속성";
            this.SetSizeGripStyleBtn.UseVisualStyleBackColor = true;
            this.SetSizeGripStyleBtn.Click += new System.EventHandler(this.SetSizeGripStyleBtn_Click);
            // 
            // SetShowInTaskbarBtn
            // 
            this.SetShowInTaskbarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetShowInTaskbarBtn.Location = new System.Drawing.Point(57, 502);
            this.SetShowInTaskbarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SetShowInTaskbarBtn.Name = "SetShowInTaskbarBtn";
            this.SetShowInTaskbarBtn.Size = new System.Drawing.Size(286, 34);
            this.SetShowInTaskbarBtn.TabIndex = 10;
            this.SetShowInTaskbarBtn.Text = "ShowInTaskbar 속성";
            this.SetShowInTaskbarBtn.UseVisualStyleBackColor = true;
            this.SetShowInTaskbarBtn.Click += new System.EventHandler(this.SetShowInTaskbarBtn_Click);
            // 
            // PopupOpacityFormBtn
            // 
            this.PopupOpacityFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PopupOpacityFormBtn.Location = new System.Drawing.Point(57, 546);
            this.PopupOpacityFormBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PopupOpacityFormBtn.Name = "PopupOpacityFormBtn";
            this.PopupOpacityFormBtn.Size = new System.Drawing.Size(286, 34);
            this.PopupOpacityFormBtn.TabIndex = 11;
            this.PopupOpacityFormBtn.Text = "Popup Opacity속성 Form";
            this.PopupOpacityFormBtn.UseVisualStyleBackColor = true;
            this.PopupOpacityFormBtn.Click += new System.EventHandler(this.PopupOpacityFormBtn_Click);
            // 
            // CreateTransparentFormBtn
            // 
            this.CreateTransparentFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateTransparentFormBtn.Location = new System.Drawing.Point(57, 590);
            this.CreateTransparentFormBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateTransparentFormBtn.Name = "CreateTransparentFormBtn";
            this.CreateTransparentFormBtn.Size = new System.Drawing.Size(286, 34);
            this.CreateTransparentFormBtn.TabIndex = 12;
            this.CreateTransparentFormBtn.Text = "TransparentForm 생성";
            this.CreateTransparentFormBtn.UseVisualStyleBackColor = true;
            this.CreateTransparentFormBtn.Click += new System.EventHandler(this.CreateTransparentFormBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1143, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.버전정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 19);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 버전정보ToolStripMenuItem
            // 
            this.버전정보ToolStripMenuItem.Name = "버전정보ToolStripMenuItem";
            this.버전정보ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.버전정보ToolStripMenuItem.Text = "버전 정보";
            this.버전정보ToolStripMenuItem.Click += new System.EventHandler(this.버전정보ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foreColorToolStripMenuItem,
            this.backColorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 48);
            // 
            // foreColorToolStripMenuItem
            // 
            this.foreColorToolStripMenuItem.Name = "foreColorToolStripMenuItem";
            this.foreColorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.foreColorToolStripMenuItem.Text = "ForeColor";
            this.foreColorToolStripMenuItem.Click += new System.EventHandler(this.foreColorToolStripMenuItem_Click);
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.backColorToolStripMenuItem.Text = "BackColor";
            this.backColorToolStripMenuItem.Click += new System.EventHandler(this.backColorToolStripMenuItem_Click);
            // 
            // SetFlatAppearenceBtn
            // 
            this.SetFlatAppearenceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetFlatAppearenceBtn.Location = new System.Drawing.Point(421, 154);
            this.SetFlatAppearenceBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SetFlatAppearenceBtn.Name = "SetFlatAppearenceBtn";
            this.SetFlatAppearenceBtn.Size = new System.Drawing.Size(286, 34);
            this.SetFlatAppearenceBtn.TabIndex = 14;
            this.SetFlatAppearenceBtn.Text = "SetFlatAppearenceBtn";
            this.SetFlatAppearenceBtn.UseVisualStyleBackColor = true;
            this.SetFlatAppearenceBtn.Click += new System.EventHandler(this.SetFlatAppearenceBtn_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(108, 26);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // IsAnchorLabel
            // 
            this.IsAnchorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IsAnchorLabel.AutoSize = true;
            this.IsAnchorLabel.Location = new System.Drawing.Point(57, 639);
            this.IsAnchorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IsAnchorLabel.Name = "IsAnchorLabel";
            this.IsAnchorLabel.Size = new System.Drawing.Size(111, 18);
            this.IsAnchorLabel.TabIndex = 16;
            this.IsAnchorLabel.Text = "All Anchored";
            // 
            // ProcessLayoutEventBtn
            // 
            this.ProcessLayoutEventBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessLayoutEventBtn.Location = new System.Drawing.Point(421, 198);
            this.ProcessLayoutEventBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessLayoutEventBtn.Name = "ProcessLayoutEventBtn";
            this.ProcessLayoutEventBtn.Size = new System.Drawing.Size(286, 34);
            this.ProcessLayoutEventBtn.TabIndex = 17;
            this.ProcessLayoutEventBtn.Text = "ProcessLayoutEvent";
            this.ProcessLayoutEventBtn.UseVisualStyleBackColor = true;
            this.ProcessLayoutEventBtn.Click += new System.EventHandler(this.ProcessLayoutEventBtn_Click);
            // 
            // MDIBtn
            // 
            this.MDIBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MDIBtn.Location = new System.Drawing.Point(421, 242);
            this.MDIBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MDIBtn.Name = "MDIBtn";
            this.MDIBtn.Size = new System.Drawing.Size(286, 34);
            this.MDIBtn.TabIndex = 18;
            this.MDIBtn.Text = "CreateMDI";
            this.MDIBtn.UseVisualStyleBackColor = true;
            this.MDIBtn.Click += new System.EventHandler(this.MDIBtn_Click);
            // 
            // Properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 675);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.MDIBtn);
            this.Controls.Add(this.ProcessLayoutEventBtn);
            this.Controls.Add(this.IsAnchorLabel);
            this.Controls.Add(this.SetFlatAppearenceBtn);
            this.Controls.Add(this.CreateTransparentFormBtn);
            this.Controls.Add(this.PopupOpacityFormBtn);
            this.Controls.Add(this.SetShowInTaskbarBtn);
            this.Controls.Add(this.SetSizeGripStyleBtn);
            this.Controls.Add(this.SetHelpIconBtn);
            this.Controls.Add(this.instructionTextBox);
            this.Controls.Add(this.SetMaxiMiniBtn);
            this.Controls.Add(this.SetControlBoxBtn);
            this.Controls.Add(this.ChangeFormBorderStyleBtn);
            this.Controls.Add(this.LoadBitmapBtn);
            this.Controls.Add(this.ReadFromAppConfigBtn);
            this.Controls.Add(this.TopMostBtn);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Properties";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Properties_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Properties_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TopMostBtn;
        private System.Windows.Forms.Button ReadFromAppConfigBtn;
        private System.Windows.Forms.Button LoadBitmapBtn;
        private System.Windows.Forms.Button ChangeFormBorderStyleBtn;
        private System.Windows.Forms.Button SetControlBoxBtn;
        private System.Windows.Forms.Button SetMaxiMiniBtn;
        private System.Windows.Forms.TextBox instructionTextBox;
        private System.Windows.Forms.Button SetHelpIconBtn;
        private System.Windows.Forms.Button SetSizeGripStyleBtn;
        private System.Windows.Forms.Button SetShowInTaskbarBtn;
        private System.Windows.Forms.Button PopupOpacityFormBtn;
        private System.Windows.Forms.Button CreateTransparentFormBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 버전정보ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem foreColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
        private System.Windows.Forms.Button SetFlatAppearenceBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label IsAnchorLabel;
        private System.Windows.Forms.Button ProcessLayoutEventBtn;
        private System.Windows.Forms.Button MDIBtn;
    }
}
