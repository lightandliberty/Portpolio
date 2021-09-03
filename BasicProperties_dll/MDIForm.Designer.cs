namespace BasicProperties_dll
{
    partial class MDIForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mDI정렬ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileChildrenVerticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileChildrenHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 48);
            this.MainSplitContainer.Size = new System.Drawing.Size(800, 380);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(211, 116);
            // 
            // BtnInGroupBox2
            // 
            this.BtnInGroupBox2.Size = new System.Drawing.Size(147, 20);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDI정렬ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mDI정렬ToolStripMenuItem
            // 
            this.mDI정렬ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrangeIconsToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileChildrenVerticallyToolStripMenuItem,
            this.tileChildrenHorizontallyToolStripMenuItem});
            this.mDI정렬ToolStripMenuItem.Name = "mDI정렬ToolStripMenuItem";
            this.mDI정렬ToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.mDI정렬ToolStripMenuItem.Text = "MDI 정렬";
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.arrangeIconsToolStripMenuItem.Text = "ArrangeIcons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.arrangeIconsToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileChildrenVerticallyToolStripMenuItem
            // 
            this.tileChildrenVerticallyToolStripMenuItem.Name = "tileChildrenVerticallyToolStripMenuItem";
            this.tileChildrenVerticallyToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.tileChildrenVerticallyToolStripMenuItem.Text = "Tile Children Vertically";
            this.tileChildrenVerticallyToolStripMenuItem.Click += new System.EventHandler(this.tileChildrenVerticallyToolStripMenuItem_Click);
            // 
            // tileChildrenHorizontallyToolStripMenuItem
            // 
            this.tileChildrenHorizontallyToolStripMenuItem.Name = "tileChildrenHorizontallyToolStripMenuItem";
            this.tileChildrenHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.tileChildrenHorizontallyToolStripMenuItem.Text = "Tile Children Horizontally";
            this.tileChildrenHorizontallyToolStripMenuItem.Click += new System.EventHandler(this.tileChildrenHorizontallyToolStripMenuItem_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MDIForm";
            this.Load += new System.EventHandler(this.MDIForm_Load);
            this.Controls.SetChildIndex(this.menuStrip2, 0);
            this.Controls.SetChildIndex(this.MainSplitContainer, 0);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MenuStrip menuStrip2;
        public System.Windows.Forms.ToolStripMenuItem mDI정렬ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem tileChildrenVerticallyToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem tileChildrenHorizontallyToolStripMenuItem;
    }
}
