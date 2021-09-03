using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicProperties_dll
{
    public partial class FlatAppearanceForm : Form
    {
        public FlatAppearanceForm()
        {
            InitializeComponent();
        }

        private void SetApplicationEnableVisualStylesBtn_Click(object sender, EventArgs e)
        {
            switch(Application.VisualStyleState)
            {
                case System.Windows.Forms.VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled:
                    Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAreaEnabled;
                    this.SetApplicationEnableVisualStylesBtn.Text = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAreaEnabled.ToString();
                    break;
                case System.Windows.Forms.VisualStyles.VisualStyleState.ClientAreaEnabled :
                    Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NonClientAreaEnabled;
                    this.SetApplicationEnableVisualStylesBtn.Text = System.Windows.Forms.VisualStyles.VisualStyleState.NonClientAreaEnabled.ToString();
                    break;
                case System.Windows.Forms.VisualStyles.VisualStyleState.NonClientAreaEnabled :
                    Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
                    this.SetApplicationEnableVisualStylesBtn.Text = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled.ToString();
                    break;
                case System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled:
                    Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled;
                    this.SetApplicationEnableVisualStylesBtn.Text = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled.ToString();
                    break;
                default:
                    break;
            }
        }

        private void FlatAppearanceForm_Load(object sender, EventArgs e)
        {
            SetApplicationEnableVisualStylesBtn.Text = Application.VisualStyleState.ToString();
        }

        private void FlatBtn_Click(object sender, EventArgs e)
        {
            this.FlatBtn.FlatStyle = FlatStyle.Flat;
            this.SetApplicationEnableVisualStylesBtn.FlatStyle = FlatStyle.Flat;
        }

        private void PopupBtn_Click(object sender, EventArgs e)
        {
            this.PopupBtn.FlatStyle = FlatStyle.Popup;
            this.SetApplicationEnableVisualStylesBtn.FlatStyle = FlatStyle.Popup;
        }

        private void StandardBtn_Click(object sender, EventArgs e)
        {
            this.StandardBtn.FlatStyle = FlatStyle.Standard;
            this.SetApplicationEnableVisualStylesBtn.FlatStyle = FlatStyle.Standard;
        }

        private void SystemBtn_Click(object sender, EventArgs e)
        {
            this.SystemBtn.FlatStyle = FlatStyle.System;
            this.SetApplicationEnableVisualStylesBtn.FlatStyle = FlatStyle.System;
        }

        private void BorderSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.SetApplicationEnableVisualStylesBtn.FlatAppearance.BorderSize = (int)this.BorderSizeNumericUpDown.Value;
            this.SetBorderSizeBtn.FlatStyle = FlatStyle.Flat;
            this.SetBorderSizeBtn.FlatAppearance.BorderSize = (int)this.BorderSizeNumericUpDown.Value;
            this.SetBorderSizeBtn.Text = FlatStyle.Flat.ToString() + " BorderSize = " + this.SetApplicationEnableVisualStylesBtn.FlatAppearance.BorderSize.ToString();

            this.SetApplicationEnableVisualStylesBtn.Text = this.SetApplicationEnableVisualStylesBtn.FlatAppearance.BorderSize.ToString();

        }

        private void BorderSizeNumericUpDown_Enter(object sender, EventArgs e)
        {
            this.BorderSizeNumericUpDown.Select(0, (int)(this.BorderSizeNumericUpDown.Value / 10) + 1);
        }

        private void SetBorderColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            if (DialogResult.OK == colorDialog.ShowDialog())
            {
                this.SetBorderColorBtn.FlatAppearance.BorderColor = colorDialog.Color;
                this.SetApplicationEnableVisualStylesBtn.FlatAppearance.BorderColor = colorDialog.Color;
            }
            colorDialog.Dispose();
        }

        private void SetMouseDownBackColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            if(DialogResult.OK == colorDialog.ShowDialog())
            {
                this.SetMouseDownBackColorBtn.FlatAppearance.MouseDownBackColor = colorDialog.Color;
                this.SetApplicationEnableVisualStylesBtn.FlatAppearance.MouseDownBackColor = colorDialog.Color;
            }
            colorDialog.Dispose();
        }

        private void SetMouseOverBackColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            if (DialogResult.OK == colorDialog.ShowDialog())
            {
                this.SetMouseOverBackColorBtn.FlatAppearance.MouseOverBackColor = colorDialog.Color;
                this.SetApplicationEnableVisualStylesBtn.FlatAppearance.MouseOverBackColor = colorDialog.Color;
            }
            colorDialog.Dispose();
        }

        private void SetFlatStyleAllBtn_Click(object sender, EventArgs e)
        {
            if (this.SetFlatStyleAllBtn.FlatStyle == FlatStyle.Flat)
            {
                SetFlatStyleSystem(this);
            }
            else if (this.SetFlatStyleAllBtn.FlatStyle != FlatStyle.Flat)
            { 
                SetFlatStyleFlat(this);
            }
        }

        void SetFlatStyleFlat(Control parent)
        {
            foreach(Control control in parent.Controls)
            {
                // 다음 컨트롤에만 FlatStyle 속성이 있으므로
                Button button = control as Button;
                GroupBox group = control as GroupBox;
                Label label = control as Label;
                if (button != null) button.FlatStyle    = FlatStyle.Flat;
                else if (group != null) group.FlatStyle = FlatStyle.Flat;
                else if (label != null) label.FlatStyle = FlatStyle.Flat;

                // 컨트롤이 또 다른 컨트롤을 포함하고 있을 경우에 대해서도 FlatStyle을 설정
                SetFlatStyleFlat(control);
            }
        }

        void SetFlatStyleSystem(Control parent)
        {
            foreach(Control control in parent.Controls)
            {
                // 다음 컨트롤에만 FlatStyle 속성이 있으므로
                Button button = control as Button;
                GroupBox group = control as GroupBox;
                Label label = control as Label;
                if (button != null) button.FlatStyle    = FlatStyle.System;
                else if (group != null) group.FlatStyle = FlatStyle.System;
                else if (label != null) label.FlatStyle = FlatStyle.System;

                // 컨트롤이 또 다른 컨트롤을 포함하고 있을 경우에 대해서도 FlatStyle을 설정
                SetFlatStyleSystem(control);
            }
        }

    }
}
