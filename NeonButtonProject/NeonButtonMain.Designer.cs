namespace NeonButtonProject_Dll
{
    partial class NeonButtonMain
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
            this.neonButtonBtn = new CustomControls_dll.NeonButton();
            this.SuspendLayout();
            // 
            // neonButtonBtn
            // 
            this.neonButtonBtn.ButtonColor = CustomControls_dll.NeonButton.KeyColor.Pink;
            this.neonButtonBtn.Location = new System.Drawing.Point(328, 180);
            this.neonButtonBtn.Name = "neonButtonBtn";
            this.neonButtonBtn.Size = new System.Drawing.Size(131, 52);
            this.neonButtonBtn.TabIndex = 0;
            this.neonButtonBtn.Text = "NeonButton";
            this.neonButtonBtn.UseVisualStyleBackColor = true;
            this.neonButtonBtn.Click += new System.EventHandler(this.NeonButtonBtn_Click);
            // 
            // NeonButtonMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.neonButtonBtn);
            this.KeyPreview = true;
            this.Name = "NeonButtonMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NeonButtonMain_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls_dll.NeonButton neonButtonBtn;
    }
}
