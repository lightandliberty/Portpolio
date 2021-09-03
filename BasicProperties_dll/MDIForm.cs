using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BasicProperties_dll
{
    public partial class MDIForm : BasicProperties_dll.StandardWindow
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {
            //menuStrip1 = menuStrip2;
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileChildrenVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileChildrenHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
