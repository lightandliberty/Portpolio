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
        public Form child1;
        public Form child2;

        public MDIForm()
        {
            InitializeComponent();
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {
            this.Controls.Remove(MainSplitContainer);
            child1 = new Form();
            child2 = new Form();
            this.IsMdiContainer = true;
            child1.MdiParent = this;
            child2.MdiParent = this;
            //this.MainSplitContainer.Panel1.Controls.Add(child1);
            //this.MainSplitContainer.Panel1.Controls.Add(child2);
            child1.Show();
            child2.Show();

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
