namespace BasicProperties_dll
{
    partial class StandardWindow
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
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInGroupBox2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupbox1Label = new System.Windows.Forms.Label();
            this.BtnInGroupBox1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.프로그램정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 프로그램정보ToolStripMenuItem
            // 
            this.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem";
            this.프로그램정보ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.프로그램정보ToolStripMenuItem.Text = "프로그램 정보";
            this.프로그램정보ToolStripMenuItem.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel1.Text = "정상";
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.groupBox2);
            this.MainSplitContainer.Panel2.Controls.Add(this.groupBox1);
            this.MainSplitContainer.Size = new System.Drawing.Size(800, 404);
            this.MainSplitContainer.SplitterDistance = 401;
            this.MainSplitContainer.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BtnInGroupBox2);
            this.groupBox2.Location = new System.Drawing.Point(44, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 119);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sizable";
            // 
            // BtnInGroupBox2
            // 
            this.BtnInGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInGroupBox2.Location = new System.Drawing.Point(20, 50);
            this.BtnInGroupBox2.Name = "BtnInGroupBox2";
            this.BtnInGroupBox2.Size = new System.Drawing.Size(147, 23);
            this.BtnInGroupBox2.TabIndex = 0;
            this.BtnInGroupBox2.Text = "BtnInGroupBox2";
            this.BtnInGroupBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupbox1Label);
            this.groupBox1.Controls.Add(this.BtnInGroupBox1);
            this.groupBox1.Location = new System.Drawing.Point(44, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupbox1Label
            // 
            this.groupbox1Label.AutoSize = true;
            this.groupbox1Label.Location = new System.Drawing.Point(23, 46);
            this.groupbox1Label.Name = "groupbox1Label";
            this.groupbox1Label.Size = new System.Drawing.Size(191, 18);
            this.groupbox1Label.TabIndex = 1;
            this.groupbox1Label.Text = "버튼만 AutoSize = true";
            // 
            // BtnInGroupBox1
            // 
            this.BtnInGroupBox1.AutoSize = true;
            this.BtnInGroupBox1.Location = new System.Drawing.Point(20, 70);
            this.BtnInGroupBox1.Name = "BtnInGroupBox1";
            this.BtnInGroupBox1.Size = new System.Drawing.Size(156, 28);
            this.BtnInGroupBox1.TabIndex = 0;
            this.BtnInGroupBox1.Text = "BtnInGroupBox1";
            this.BtnInGroupBox1.UseVisualStyleBackColor = true;
            // 
            // StandardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StandardWindow";
            this.Text = "StandardWindow";
            this.Load += new System.EventHandler(this.StandardWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 프로그램정보ToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.SplitContainer MainSplitContainer;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BtnInGroupBox2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button BtnInGroupBox1;
        public System.Windows.Forms.Label groupbox1Label;
    }
}