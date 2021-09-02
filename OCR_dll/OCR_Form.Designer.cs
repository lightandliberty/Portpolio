namespace OCR_dll
{
    partial class OCR_Form
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
            this.videoStartBtn = new System.Windows.Forms.Button();
            this.focusConfirmBtn = new System.Windows.Forms.Button();
            this.measureDistanceBtn = new System.Windows.Forms.Button();
            this.OCR_ASpose_Btn = new System.Windows.Forms.Button();
            this.OCR_Tesseract_Btn = new System.Windows.Forms.Button();
            this.OCR_IronBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Top = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Left = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // videoStartBtn
            // 
            this.videoStartBtn.Location = new System.Drawing.Point(693, 13);
            this.videoStartBtn.Name = "videoStartBtn";
            this.videoStartBtn.Size = new System.Drawing.Size(95, 61);
            this.videoStartBtn.TabIndex = 0;
            this.videoStartBtn.Text = "영상시작";
            this.videoStartBtn.UseVisualStyleBackColor = true;
            this.videoStartBtn.Click += new System.EventHandler(this.videoStartBtn_Click);
            // 
            // focusConfirmBtn
            // 
            this.focusConfirmBtn.Location = new System.Drawing.Point(693, 80);
            this.focusConfirmBtn.Name = "focusConfirmBtn";
            this.focusConfirmBtn.Size = new System.Drawing.Size(95, 61);
            this.focusConfirmBtn.TabIndex = 1;
            this.focusConfirmBtn.Text = "초점거리확인";
            this.focusConfirmBtn.UseVisualStyleBackColor = true;
            this.focusConfirmBtn.Click += new System.EventHandler(this.focusConfirmBtn_Click);
            // 
            // measureDistanceBtn
            // 
            this.measureDistanceBtn.Location = new System.Drawing.Point(693, 147);
            this.measureDistanceBtn.Name = "measureDistanceBtn";
            this.measureDistanceBtn.Size = new System.Drawing.Size(95, 61);
            this.measureDistanceBtn.TabIndex = 2;
            this.measureDistanceBtn.Text = "거리측정";
            this.measureDistanceBtn.UseVisualStyleBackColor = true;
            // 
            // OCR_ASpose_Btn
            // 
            this.OCR_ASpose_Btn.Location = new System.Drawing.Point(693, 214);
            this.OCR_ASpose_Btn.Name = "OCR_ASpose_Btn";
            this.OCR_ASpose_Btn.Size = new System.Drawing.Size(95, 61);
            this.OCR_ASpose_Btn.TabIndex = 3;
            this.OCR_ASpose_Btn.Text = "문자인식 (ASpose)";
            this.OCR_ASpose_Btn.UseVisualStyleBackColor = true;
            this.OCR_ASpose_Btn.Click += new System.EventHandler(this.OCR_ASpose_Btn_Click);
            // 
            // OCR_Tesseract_Btn
            // 
            this.OCR_Tesseract_Btn.Location = new System.Drawing.Point(693, 281);
            this.OCR_Tesseract_Btn.Name = "OCR_Tesseract_Btn";
            this.OCR_Tesseract_Btn.Size = new System.Drawing.Size(95, 61);
            this.OCR_Tesseract_Btn.TabIndex = 4;
            this.OCR_Tesseract_Btn.Text = "문자인식 (Tesseract)";
            this.OCR_Tesseract_Btn.UseVisualStyleBackColor = true;
            this.OCR_Tesseract_Btn.Click += new System.EventHandler(this.OCR_Tesseract_Btn_Click);
            // 
            // OCR_IronBtn
            // 
            this.OCR_IronBtn.Location = new System.Drawing.Point(693, 348);
            this.OCR_IronBtn.Name = "OCR_IronBtn";
            this.OCR_IronBtn.Size = new System.Drawing.Size(95, 61);
            this.OCR_IronBtn.TabIndex = 5;
            this.OCR_IronBtn.Text = "문자인식(Iron)";
            this.OCR_IronBtn.UseVisualStyleBackColor = true;
            this.OCR_IronBtn.Click += new System.EventHandler(this.OCR_IronBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(663, 335);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 355);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(663, 54);
            this.textBox1.TabIndex = 7;
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(302, 415);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(95, 31);
            this.drawBtn.TabIndex = 8;
            this.drawBtn.Text = "그리기";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.DrawBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Top,
            this.Left,
            this.Width,
            this.Height,
            this.Label,
            this.Result});
            this.dataGridView1.Location = new System.Drawing.Point(13, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(640, 82);
            this.dataGridView1.TabIndex = 9;
            // 
            // Top
            // 
            this.Top.HeaderText = "Top";
            this.Top.Name = "Top";
            this.Top.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Left
            // 
            this.Left.HeaderText = "Left";
            this.Left.Name = "Left";
            this.Left.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Width
            // 
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            this.Width.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Height
            // 
            this.Height.HeaderText = "Height";
            this.Height.Name = "Height";
            this.Height.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Label
            // 
            this.Label.HeaderText = "Label";
            this.Label.Name = "Label";
            this.Label.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OCR_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OCR_IronBtn);
            this.Controls.Add(this.OCR_Tesseract_Btn);
            this.Controls.Add(this.OCR_ASpose_Btn);
            this.Controls.Add(this.measureDistanceBtn);
            this.Controls.Add(this.focusConfirmBtn);
            this.Controls.Add(this.videoStartBtn);
            this.Name = "OCR_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OCR_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button videoStartBtn;
        private System.Windows.Forms.Button focusConfirmBtn;
        private System.Windows.Forms.Button measureDistanceBtn;
        private System.Windows.Forms.Button OCR_ASpose_Btn;
        private System.Windows.Forms.Button OCR_Tesseract_Btn;
        private System.Windows.Forms.Button OCR_IronBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Top;
        private System.Windows.Forms.DataGridViewTextBoxColumn Left;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}
