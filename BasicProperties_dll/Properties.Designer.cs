namespace BasicProperties_dll
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
            this.CreateMDIBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ControlBoxPropLabel = new System.Windows.Forms.Label();
            this.FormBorderStylePropLabel = new System.Windows.Forms.Label();
            this.HelpButtonPropLabel = new System.Windows.Forms.Label();
            this.MinimizeBoxPropLabel = new System.Windows.Forms.Label();
            this.MaximizePropLabel = new System.Windows.Forms.Label();
            this.ShowInTaskBarPropLabel = new System.Windows.Forms.Label();
            this.SizeGripStylePropLabel = new System.Windows.Forms.Label();
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
            this.TopMostBtn.Location = new System.Drawing.Point(40, 132);
            this.TopMostBtn.Name = "TopMostBtn";
            this.TopMostBtn.Size = new System.Drawing.Size(200, 23);
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
            this.ReadFromAppConfigBtn.Location = new System.Drawing.Point(40, 103);
            this.ReadFromAppConfigBtn.Name = "ReadFromAppConfigBtn";
            this.ReadFromAppConfigBtn.Size = new System.Drawing.Size(200, 23);
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
            this.LoadBitmapBtn.Location = new System.Drawing.Point(40, 161);
            this.LoadBitmapBtn.Name = "LoadBitmapBtn";
            this.LoadBitmapBtn.Size = new System.Drawing.Size(200, 23);
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
            this.ChangeFormBorderStyleBtn.Location = new System.Drawing.Point(42, 219);
            this.ChangeFormBorderStyleBtn.Name = "ChangeFormBorderStyleBtn";
            this.ChangeFormBorderStyleBtn.Size = new System.Drawing.Size(200, 23);
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
            this.SetControlBoxBtn.Location = new System.Drawing.Point(40, 190);
            this.SetControlBoxBtn.Name = "SetControlBoxBtn";
            this.SetControlBoxBtn.Size = new System.Drawing.Size(200, 23);
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
            this.SetMaxiMiniBtn.Location = new System.Drawing.Point(40, 248);
            this.SetMaxiMiniBtn.Name = "SetMaxiMiniBtn";
            this.SetMaxiMiniBtn.Size = new System.Drawing.Size(200, 23);
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
            this.instructionTextBox.Location = new System.Drawing.Point(40, 40);
            this.instructionTextBox.Multiline = true;
            this.instructionTextBox.Name = "instructionTextBox";
            this.instructionTextBox.Size = new System.Drawing.Size(660, 54);
            this.instructionTextBox.TabIndex = 7;
            // 
            // SetHelpIconBtn
            // 
            this.SetHelpIconBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetHelpIconBtn.Location = new System.Drawing.Point(40, 277);
            this.SetHelpIconBtn.Name = "SetHelpIconBtn";
            this.SetHelpIconBtn.Size = new System.Drawing.Size(200, 23);
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
            this.SetSizeGripStyleBtn.Location = new System.Drawing.Point(40, 306);
            this.SetSizeGripStyleBtn.Name = "SetSizeGripStyleBtn";
            this.SetSizeGripStyleBtn.Size = new System.Drawing.Size(200, 23);
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
            this.SetShowInTaskbarBtn.Location = new System.Drawing.Point(40, 335);
            this.SetShowInTaskbarBtn.Name = "SetShowInTaskbarBtn";
            this.SetShowInTaskbarBtn.Size = new System.Drawing.Size(200, 23);
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
            this.PopupOpacityFormBtn.Location = new System.Drawing.Point(40, 364);
            this.PopupOpacityFormBtn.Name = "PopupOpacityFormBtn";
            this.PopupOpacityFormBtn.Size = new System.Drawing.Size(200, 23);
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
            this.CreateTransparentFormBtn.Location = new System.Drawing.Point(40, 393);
            this.CreateTransparentFormBtn.Name = "CreateTransparentFormBtn";
            this.CreateTransparentFormBtn.Size = new System.Drawing.Size(200, 23);
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
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
            this.foreColorToolStripMenuItem.Click += new System.EventHandler(this.ForeColorToolStripMenuItem_Click);
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.backColorToolStripMenuItem.Text = "BackColor";
            this.backColorToolStripMenuItem.Click += new System.EventHandler(this.BackColorToolStripMenuItem_Click);
            // 
            // SetFlatAppearenceBtn
            // 
            this.SetFlatAppearenceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetFlatAppearenceBtn.Location = new System.Drawing.Point(277, 103);
            this.SetFlatAppearenceBtn.Name = "SetFlatAppearenceBtn";
            this.SetFlatAppearenceBtn.Size = new System.Drawing.Size(200, 23);
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // IsAnchorLabel
            // 
            this.IsAnchorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IsAnchorLabel.AutoSize = true;
            this.IsAnchorLabel.Location = new System.Drawing.Point(40, 426);
            this.IsAnchorLabel.Name = "IsAnchorLabel";
            this.IsAnchorLabel.Size = new System.Drawing.Size(77, 12);
            this.IsAnchorLabel.TabIndex = 16;
            this.IsAnchorLabel.Text = "All Anchored";
            // 
            // ProcessLayoutEventBtn
            // 
            this.ProcessLayoutEventBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessLayoutEventBtn.Location = new System.Drawing.Point(277, 132);
            this.ProcessLayoutEventBtn.Name = "ProcessLayoutEventBtn";
            this.ProcessLayoutEventBtn.Size = new System.Drawing.Size(200, 23);
            this.ProcessLayoutEventBtn.TabIndex = 17;
            this.ProcessLayoutEventBtn.Text = "ProcessLayoutEvent";
            this.ProcessLayoutEventBtn.UseVisualStyleBackColor = true;
            this.ProcessLayoutEventBtn.Click += new System.EventHandler(this.ProcessLayoutEventBtn_Click);
            // 
            // CreateMDIBtn
            // 
            this.CreateMDIBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateMDIBtn.Location = new System.Drawing.Point(277, 161);
            this.CreateMDIBtn.Name = "CreateMDIBtn";
            this.CreateMDIBtn.Size = new System.Drawing.Size(200, 23);
            this.CreateMDIBtn.TabIndex = 18;
            this.CreateMDIBtn.Text = "CreateMDI";
            this.CreateMDIBtn.UseVisualStyleBackColor = true;
            this.CreateMDIBtn.Click += new System.EventHandler(this.CreateMDIBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "ControlBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "FormBorderStyle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "HelpButton";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "MinimizeBox";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "MaximizeBox";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "ShowInTaskBar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(511, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "SizeGripStyle";
            // 
            // ControlBoxPropLabel
            // 
            this.ControlBoxPropLabel.AutoSize = true;
            this.ControlBoxPropLabel.Location = new System.Drawing.Point(647, 108);
            this.ControlBoxPropLabel.Name = "ControlBoxPropLabel";
            this.ControlBoxPropLabel.Size = new System.Drawing.Size(93, 12);
            this.ControlBoxPropLabel.TabIndex = 32;
            this.ControlBoxPropLabel.Text = "ControlBoxProp";
            // 
            // FormBorderStylePropLabel
            // 
            this.FormBorderStylePropLabel.AutoSize = true;
            this.FormBorderStylePropLabel.Location = new System.Drawing.Point(647, 137);
            this.FormBorderStylePropLabel.Name = "FormBorderStylePropLabel";
            this.FormBorderStylePropLabel.Size = new System.Drawing.Size(125, 12);
            this.FormBorderStylePropLabel.TabIndex = 31;
            this.FormBorderStylePropLabel.Text = "FormBorderStyleProp";
            // 
            // HelpButtonPropLabel
            // 
            this.HelpButtonPropLabel.AutoSize = true;
            this.HelpButtonPropLabel.Location = new System.Drawing.Point(647, 166);
            this.HelpButtonPropLabel.Name = "HelpButtonPropLabel";
            this.HelpButtonPropLabel.Size = new System.Drawing.Size(91, 12);
            this.HelpButtonPropLabel.TabIndex = 30;
            this.HelpButtonPropLabel.Text = "HelpButtonProp";
            // 
            // MinimizeBoxPropLabel
            // 
            this.MinimizeBoxPropLabel.AutoSize = true;
            this.MinimizeBoxPropLabel.Location = new System.Drawing.Point(647, 195);
            this.MinimizeBoxPropLabel.Name = "MinimizeBoxPropLabel";
            this.MinimizeBoxPropLabel.Size = new System.Drawing.Size(105, 12);
            this.MinimizeBoxPropLabel.TabIndex = 29;
            this.MinimizeBoxPropLabel.Text = "MinimizeBoxProp";
            // 
            // MaximizePropLabel
            // 
            this.MaximizePropLabel.AutoSize = true;
            this.MaximizePropLabel.Location = new System.Drawing.Point(647, 224);
            this.MaximizePropLabel.Name = "MaximizePropLabel";
            this.MaximizePropLabel.Size = new System.Drawing.Size(87, 12);
            this.MaximizePropLabel.TabIndex = 28;
            this.MaximizePropLabel.Text = "MaximizeProp";
            // 
            // ShowInTaskBarPropLabel
            // 
            this.ShowInTaskBarPropLabel.AutoSize = true;
            this.ShowInTaskBarPropLabel.Location = new System.Drawing.Point(647, 253);
            this.ShowInTaskBarPropLabel.Name = "ShowInTaskBarPropLabel";
            this.ShowInTaskBarPropLabel.Size = new System.Drawing.Size(120, 12);
            this.ShowInTaskBarPropLabel.TabIndex = 27;
            this.ShowInTaskBarPropLabel.Text = "ShowInTaskBarProp";
            // 
            // SizeGripStylePropLabel
            // 
            this.SizeGripStylePropLabel.AutoSize = true;
            this.SizeGripStylePropLabel.Location = new System.Drawing.Point(647, 282);
            this.SizeGripStylePropLabel.Name = "SizeGripStylePropLabel";
            this.SizeGripStylePropLabel.Size = new System.Drawing.Size(107, 12);
            this.SizeGripStylePropLabel.TabIndex = 26;
            this.SizeGripStylePropLabel.Text = "SizeGripStyleProp";
            // 
            // Properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.ControlBoxPropLabel);
            this.Controls.Add(this.FormBorderStylePropLabel);
            this.Controls.Add(this.HelpButtonPropLabel);
            this.Controls.Add(this.MinimizeBoxPropLabel);
            this.Controls.Add(this.MaximizePropLabel);
            this.Controls.Add(this.ShowInTaskBarPropLabel);
            this.Controls.Add(this.SizeGripStylePropLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateMDIBtn);
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
            this.Name = "Properties";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Button CreateMDIBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ControlBoxPropLabel;
        private System.Windows.Forms.Label FormBorderStylePropLabel;
        private System.Windows.Forms.Label HelpButtonPropLabel;
        private System.Windows.Forms.Label MinimizeBoxPropLabel;
        private System.Windows.Forms.Label MaximizePropLabel;
        private System.Windows.Forms.Label ShowInTaskBarPropLabel;
        private System.Windows.Forms.Label SizeGripStylePropLabel;
    }
}
