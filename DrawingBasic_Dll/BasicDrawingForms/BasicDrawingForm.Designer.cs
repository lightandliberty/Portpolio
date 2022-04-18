namespace DrawingProject_Dll
{
    partial class BasicDrawingForm
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
            this.cancelMetalBtn = new CustomControls_dll.MetalButton();
            this.okMetalBtn = new CustomControls_dll.MetalButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.종료ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.drawEllipseBtn = new CustomControls_dll.MetalButton();
            this.instructionTextBox = new System.Windows.Forms.TextBox();
            this.drawBrushesBtn = new CustomControls_dll.MetalButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.drawPensBtn = new CustomControls_dll.MetalButton();
            this.drawFigureBtn = new CustomControls_dll.MetalButton();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelMetalBtn
            // 
            this.cancelMetalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelMetalBtn.CausesValidation = false;
            this.cancelMetalBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelMetalBtn.Location = new System.Drawing.Point(705, 410);
            this.cancelMetalBtn.Name = "cancelMetalBtn";
            this.cancelMetalBtn.Size = new System.Drawing.Size(81, 28);
            this.cancelMetalBtn.TabIndex = 11;
            this.cancelMetalBtn.Text = "Cancel";
            this.cancelMetalBtn.UseVisualStyleBackColor = true;
            this.cancelMetalBtn.Click += new System.EventHandler(this.CancelMetalBtn_Click);
            // 
            // okMetalBtn
            // 
            this.okMetalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okMetalBtn.Location = new System.Drawing.Point(602, 410);
            this.okMetalBtn.Name = "okMetalBtn";
            this.okMetalBtn.Size = new System.Drawing.Size(81, 28);
            this.okMetalBtn.TabIndex = 10;
            this.okMetalBtn.Text = "OK";
            this.okMetalBtn.UseVisualStyleBackColor = true;
            this.okMetalBtn.Click += new System.EventHandler(this.OkMetalBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // 종료ToolStripMenuItem1
            // 
            this.종료ToolStripMenuItem1.Name = "종료ToolStripMenuItem1";
            this.종료ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem1.Text = "종료";
            this.종료ToolStripMenuItem1.Click += new System.EventHandler(this.종료ToolStripMenuItem1_Click);
            // 
            // drawEllipseBtn
            // 
            this.drawEllipseBtn.Location = new System.Drawing.Point(24, 158);
            this.drawEllipseBtn.Name = "drawEllipseBtn";
            this.drawEllipseBtn.Size = new System.Drawing.Size(112, 36);
            this.drawEllipseBtn.TabIndex = 13;
            this.drawEllipseBtn.Text = "DrawEllipse";
            this.drawEllipseBtn.UseVisualStyleBackColor = true;
            this.drawEllipseBtn.Click += new System.EventHandler(this.DrawEllipseBtn_Click);
            this.drawEllipseBtn.MouseEnter += new System.EventHandler(this.DrawEllipseBtn_MouseEnter);
            // 
            // instructionTextBox
            // 
            this.instructionTextBox.Location = new System.Drawing.Point(24, 81);
            this.instructionTextBox.Multiline = true;
            this.instructionTextBox.Name = "instructionTextBox";
            this.instructionTextBox.Size = new System.Drawing.Size(747, 64);
            this.instructionTextBox.TabIndex = 14;
            // 
            // drawBrushesBtn
            // 
            this.drawBrushesBtn.Location = new System.Drawing.Point(24, 208);
            this.drawBrushesBtn.Name = "drawBrushesBtn";
            this.drawBrushesBtn.Size = new System.Drawing.Size(112, 36);
            this.drawBrushesBtn.TabIndex = 15;
            this.drawBrushesBtn.Text = "DrawBrushes";
            this.drawBrushesBtn.UseVisualStyleBackColor = true;
            this.drawBrushesBtn.Click += new System.EventHandler(this.DrawBrushesBtn_Click);
            this.drawBrushesBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawBrushesBtn_MouseMove);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleLabel.Location = new System.Drawing.Point(326, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(152, 24);
            this.titleLabel.TabIndex = 16;
            this.titleLabel.Text = "Basic Drawing";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // drawPensBtn
            // 
            this.drawPensBtn.Location = new System.Drawing.Point(24, 258);
            this.drawPensBtn.Name = "drawPensBtn";
            this.drawPensBtn.Size = new System.Drawing.Size(112, 36);
            this.drawPensBtn.TabIndex = 17;
            this.drawPensBtn.Text = "DrawPens";
            this.drawPensBtn.UseVisualStyleBackColor = true;
            this.drawPensBtn.Click += new System.EventHandler(this.DrawPensBtn_Click);
            this.drawPensBtn.MouseEnter += new System.EventHandler(this.DrawPensBtn_MouseEnter);
            // 
            // drawFigureBtn
            // 
            this.drawFigureBtn.Location = new System.Drawing.Point(24, 308);
            this.drawFigureBtn.Name = "drawFigureBtn";
            this.drawFigureBtn.Size = new System.Drawing.Size(112, 36);
            this.drawFigureBtn.TabIndex = 18;
            this.drawFigureBtn.Text = "Draw Figures";
            this.drawFigureBtn.UseVisualStyleBackColor = true;
            this.drawFigureBtn.Click += new System.EventHandler(this.drawFigureBtn_Click);
            // 
            // BasicDrawingForm
            // 
            this.AcceptButton = this.okMetalBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelMetalBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawFigureBtn);
            this.Controls.Add(this.drawPensBtn);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.drawBrushesBtn);
            this.Controls.Add(this.instructionTextBox);
            this.Controls.Add(this.drawEllipseBtn);
            this.Controls.Add(this.cancelMetalBtn);
            this.Controls.Add(this.okMetalBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BasicDrawingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BasicDrawingForm";
            this.Load += new System.EventHandler(this.BasicDrawingForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BasicDrawingForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BasicDrawingForm_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BasicDrawingForm_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls_dll.MetalButton cancelMetalBtn;
        private CustomControls_dll.MetalButton okMetalBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem1;
        private CustomControls_dll.MetalButton drawEllipseBtn;
        private System.Windows.Forms.TextBox instructionTextBox;
        private CustomControls_dll.MetalButton drawBrushesBtn;
        private System.Windows.Forms.Label titleLabel;
        private CustomControls_dll.MetalButton drawPensBtn;
        private CustomControls_dll.MetalButton drawFigureBtn;
    }
}