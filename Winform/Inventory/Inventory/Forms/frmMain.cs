using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            this.importToolStripMenuItem.Click -= new System.EventHandler(this.importToolStripMenuItem_Click);
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);

            this.exportToolStripMenuItem.Click -= new System.EventHandler(this.exportToolStripMenuItem_Click);
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);

            this.reportToolStripMenuItem.Click -= new System.EventHandler(this.reportToolStripMenuItem_Click);
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);

            this.itemsToolStripMenuItem.Click -= new System.EventHandler(this.itemsToolStripMenuItem_Click);
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImport frm = new frmImport();
            frm.Show();
            this.Hide();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExport frm = new frmExport();
            frm.Show();
            this.Hide();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.Show();
            this.Hide();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItem frm = new frmItem();
            frm.Show();
            this.Hide();
        }    
    }
}
