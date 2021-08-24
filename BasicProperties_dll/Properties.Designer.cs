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
            this.TopMostBtn = new System.Windows.Forms.Button();
            this.SetNotTopMostBtn = new System.Windows.Forms.Button();
            this.ReadFromAppConfigBtn = new System.Windows.Forms.Button();
            this.LoadBitmapBtn = new System.Windows.Forms.Button();
            this.ChangeFormBorderStyleBtn = new System.Windows.Forms.Button();
            this.SetControlBoxBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopMostBtn
            // 
            this.TopMostBtn.Location = new System.Drawing.Point(40, 38);
            this.TopMostBtn.Name = "TopMostBtn";
            this.TopMostBtn.Size = new System.Drawing.Size(75, 23);
            this.TopMostBtn.TabIndex = 0;
            this.TopMostBtn.Text = "최상위창";
            this.TopMostBtn.UseVisualStyleBackColor = true;
            this.TopMostBtn.Click += new System.EventHandler(this.TopMostBtn_Click);
            // 
            // SetNotTopMostBtn
            // 
            this.SetNotTopMostBtn.Location = new System.Drawing.Point(121, 38);
            this.SetNotTopMostBtn.Name = "SetNotTopMostBtn";
            this.SetNotTopMostBtn.Size = new System.Drawing.Size(91, 23);
            this.SetNotTopMostBtn.TabIndex = 1;
            this.SetNotTopMostBtn.Text = "최상위 아님";
            this.SetNotTopMostBtn.UseVisualStyleBackColor = true;
            this.SetNotTopMostBtn.Click += new System.EventHandler(this.SetNotTopMostBtn_Click);
            // 
            // ReadFromAppConfigBtn
            // 
            this.ReadFromAppConfigBtn.Location = new System.Drawing.Point(40, 9);
            this.ReadFromAppConfigBtn.Name = "ReadFromAppConfigBtn";
            this.ReadFromAppConfigBtn.Size = new System.Drawing.Size(172, 23);
            this.ReadFromAppConfigBtn.TabIndex = 2;
            this.ReadFromAppConfigBtn.Text = "App.config에서 값 읽어오기";
            this.ReadFromAppConfigBtn.UseVisualStyleBackColor = true;
            this.ReadFromAppConfigBtn.Click += new System.EventHandler(this.ReadFromAppConfigBtn_Click);
            // 
            // LoadBitmapBtn
            // 
            this.LoadBitmapBtn.Location = new System.Drawing.Point(40, 67);
            this.LoadBitmapBtn.Name = "LoadBitmapBtn";
            this.LoadBitmapBtn.Size = new System.Drawing.Size(178, 23);
            this.LoadBitmapBtn.TabIndex = 3;
            this.LoadBitmapBtn.Text = "c:\\cocoa.png 파일 나타내기";
            this.LoadBitmapBtn.UseVisualStyleBackColor = true;
            this.LoadBitmapBtn.Click += new System.EventHandler(this.LoadBitmapBtn_Click);
            // 
            // ChangeFormBorderStyleBtn
            // 
            this.ChangeFormBorderStyleBtn.Location = new System.Drawing.Point(40, 96);
            this.ChangeFormBorderStyleBtn.Name = "ChangeFormBorderStyleBtn";
            this.ChangeFormBorderStyleBtn.Size = new System.Drawing.Size(172, 23);
            this.ChangeFormBorderStyleBtn.TabIndex = 4;
            this.ChangeFormBorderStyleBtn.Text = "FormBorderStyle속성 설정";
            this.ChangeFormBorderStyleBtn.UseVisualStyleBackColor = true;
            this.ChangeFormBorderStyleBtn.Click += new System.EventHandler(this.ChangeFormBorderStyleBtn_Click);
            // 
            // SetControlBoxBtn
            // 
            this.SetControlBoxBtn.Location = new System.Drawing.Point(40, 125);
            this.SetControlBoxBtn.Name = "SetControlBoxBtn";
            this.SetControlBoxBtn.Size = new System.Drawing.Size(172, 23);
            this.SetControlBoxBtn.TabIndex = 5;
            this.SetControlBoxBtn.Text = "ControlBox 속성 변경";
            this.SetControlBoxBtn.UseVisualStyleBackColor = true;
            this.SetControlBoxBtn.Click += new System.EventHandler(this.SetControlBoxBtn_Click);
            // 
            // Properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetControlBoxBtn);
            this.Controls.Add(this.ChangeFormBorderStyleBtn);
            this.Controls.Add(this.LoadBitmapBtn);
            this.Controls.Add(this.ReadFromAppConfigBtn);
            this.Controls.Add(this.SetNotTopMostBtn);
            this.Controls.Add(this.TopMostBtn);
            this.Name = "Properties";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TopMostBtn;
        private System.Windows.Forms.Button SetNotTopMostBtn;
        private System.Windows.Forms.Button ReadFromAppConfigBtn;
        private System.Windows.Forms.Button LoadBitmapBtn;
        private System.Windows.Forms.Button ChangeFormBorderStyleBtn;
        private System.Windows.Forms.Button SetControlBoxBtn;
    }
}
