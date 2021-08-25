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
            this.ReadFromAppConfigBtn = new System.Windows.Forms.Button();
            this.LoadBitmapBtn = new System.Windows.Forms.Button();
            this.ChangeFormBorderStyleBtn = new System.Windows.Forms.Button();
            this.SetControlBoxBtn = new System.Windows.Forms.Button();
            this.SetMaxiMiniBtn = new System.Windows.Forms.Button();
            this.instructionTextBox = new System.Windows.Forms.TextBox();
            this.SetHelpIconBtn = new System.Windows.Forms.Button();
            this.SetSizeGripStyleBtn = new System.Windows.Forms.Button();
            this.SetShowInTaskbarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopMostBtn
            // 
            this.TopMostBtn.Location = new System.Drawing.Point(40, 105);
            this.TopMostBtn.Name = "TopMostBtn";
            this.TopMostBtn.Size = new System.Drawing.Size(200, 23);
            this.TopMostBtn.TabIndex = 0;
            this.TopMostBtn.Text = "최상위창";
            this.TopMostBtn.UseVisualStyleBackColor = true;
            this.TopMostBtn.Click += new System.EventHandler(this.TopMostBtn_Click);
            // 
            // ReadFromAppConfigBtn
            // 
            this.ReadFromAppConfigBtn.Location = new System.Drawing.Point(40, 76);
            this.ReadFromAppConfigBtn.Name = "ReadFromAppConfigBtn";
            this.ReadFromAppConfigBtn.Size = new System.Drawing.Size(200, 23);
            this.ReadFromAppConfigBtn.TabIndex = 2;
            this.ReadFromAppConfigBtn.Text = "App.config에서 값 읽어오기";
            this.ReadFromAppConfigBtn.UseVisualStyleBackColor = true;
            this.ReadFromAppConfigBtn.Click += new System.EventHandler(this.ReadFromAppConfigBtn_Click);
            // 
            // LoadBitmapBtn
            // 
            this.LoadBitmapBtn.Location = new System.Drawing.Point(40, 134);
            this.LoadBitmapBtn.Name = "LoadBitmapBtn";
            this.LoadBitmapBtn.Size = new System.Drawing.Size(200, 23);
            this.LoadBitmapBtn.TabIndex = 3;
            this.LoadBitmapBtn.Text = "c:\\cocoa.png 파일 나타내기";
            this.LoadBitmapBtn.UseVisualStyleBackColor = true;
            this.LoadBitmapBtn.Click += new System.EventHandler(this.LoadBitmapBtn_Click);
            // 
            // ChangeFormBorderStyleBtn
            // 
            this.ChangeFormBorderStyleBtn.Location = new System.Drawing.Point(40, 163);
            this.ChangeFormBorderStyleBtn.Name = "ChangeFormBorderStyleBtn";
            this.ChangeFormBorderStyleBtn.Size = new System.Drawing.Size(200, 23);
            this.ChangeFormBorderStyleBtn.TabIndex = 4;
            this.ChangeFormBorderStyleBtn.Text = "FormBorderStyle속성 설정";
            this.ChangeFormBorderStyleBtn.UseVisualStyleBackColor = true;
            this.ChangeFormBorderStyleBtn.Click += new System.EventHandler(this.ChangeFormBorderStyleBtn_Click);
            // 
            // SetControlBoxBtn
            // 
            this.SetControlBoxBtn.Location = new System.Drawing.Point(40, 192);
            this.SetControlBoxBtn.Name = "SetControlBoxBtn";
            this.SetControlBoxBtn.Size = new System.Drawing.Size(200, 23);
            this.SetControlBoxBtn.TabIndex = 5;
            this.SetControlBoxBtn.Text = "ControlBox 속성 변경";
            this.SetControlBoxBtn.UseVisualStyleBackColor = true;
            this.SetControlBoxBtn.Click += new System.EventHandler(this.SetControlBoxBtn_Click);
            // 
            // SetMaxiMiniBtn
            // 
            this.SetMaxiMiniBtn.Location = new System.Drawing.Point(40, 221);
            this.SetMaxiMiniBtn.Name = "SetMaxiMiniBtn";
            this.SetMaxiMiniBtn.Size = new System.Drawing.Size(200, 23);
            this.SetMaxiMiniBtn.TabIndex = 6;
            this.SetMaxiMiniBtn.Text = "MaximizeBox MinimizeBox 속성";
            this.SetMaxiMiniBtn.UseVisualStyleBackColor = true;
            this.SetMaxiMiniBtn.Click += new System.EventHandler(this.SetMaxiMiniBtn_Click);
            // 
            // instructionTextBox
            // 
            this.instructionTextBox.Location = new System.Drawing.Point(40, 13);
            this.instructionTextBox.Multiline = true;
            this.instructionTextBox.Name = "instructionTextBox";
            this.instructionTextBox.Size = new System.Drawing.Size(660, 54);
            this.instructionTextBox.TabIndex = 7;
            // 
            // SetHelpIconBtn
            // 
            this.SetHelpIconBtn.Location = new System.Drawing.Point(40, 250);
            this.SetHelpIconBtn.Name = "SetHelpIconBtn";
            this.SetHelpIconBtn.Size = new System.Drawing.Size(200, 23);
            this.SetHelpIconBtn.TabIndex = 8;
            this.SetHelpIconBtn.Text = "HelpButton 속성";
            this.SetHelpIconBtn.UseVisualStyleBackColor = true;
            this.SetHelpIconBtn.Click += new System.EventHandler(this.SetHelpIconBtn_Click);
            // 
            // SetSizeGripStyleBtn
            // 
            this.SetSizeGripStyleBtn.Location = new System.Drawing.Point(40, 279);
            this.SetSizeGripStyleBtn.Name = "SetSizeGripStyleBtn";
            this.SetSizeGripStyleBtn.Size = new System.Drawing.Size(200, 23);
            this.SetSizeGripStyleBtn.TabIndex = 9;
            this.SetSizeGripStyleBtn.Text = "SetSizeGripStyle 속성";
            this.SetSizeGripStyleBtn.UseVisualStyleBackColor = true;
            this.SetSizeGripStyleBtn.Click += new System.EventHandler(this.SetSizeGripStyleBtn_Click);
            // 
            // SetShowInTaskbarBtn
            // 
            this.SetShowInTaskbarBtn.Location = new System.Drawing.Point(40, 308);
            this.SetShowInTaskbarBtn.Name = "SetShowInTaskbarBtn";
            this.SetShowInTaskbarBtn.Size = new System.Drawing.Size(200, 23);
            this.SetShowInTaskbarBtn.TabIndex = 10;
            this.SetShowInTaskbarBtn.Text = "ShowInTaskbar 속성";
            this.SetShowInTaskbarBtn.UseVisualStyleBackColor = true;
            this.SetShowInTaskbarBtn.Click += new System.EventHandler(this.SetShowInTaskbarBtn_Click);
            // 
            // Properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.KeyPreview = true;
            this.Name = "Properties";
            this.ShowInTaskbar = false;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Properties_KeyDown);
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
    }
}
