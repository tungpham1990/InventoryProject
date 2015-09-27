using Inventory.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryCode;

namespace Inventory
{
    public partial class frmItem : Form
    {
        private System.Drawing.Printing.PrintDocument printDocument;

        public frmItem()
        {
            InitializeComponent();


            createTreeview();
            kietnm();

            this.btnPrint.Click -= new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            this.printDocument.PrintPage -= new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);



        }   
  
        public void createTreeview()
        {
            InventoryEntities invEntities = new InventoryEntities();
            var grped =
            from it in invEntities.items
            join ct in invEntities.category_item on it.category_item_id equals ct.category_item_id
            group it by new { it.category_item_id, ct.category_item_code } into grp
            select grp;            
            treeViewItem.Nodes.Clear();         
            foreach (var grouping in grped)
            {
                var nodeFor = treeViewItem.Nodes.Add(grouping.Key.category_item_code.ToString());
                foreach (var item in grouping)
                {
                    var subitem = nodeFor.Nodes.Add(item.item_code.ToString());
                }
            }
        }

        private void kietnm()
        {
            try
            {
                Image myimg = Code128Rendering.MakeBarcodeImage("kietm",2, true);
                pictBarcode.Image = myimg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, this.Text);
            }
        }

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                using (Font fnt = new Font("Arial", 16))
                {
                    string caption = string.Format("Code128 barcode weight={0}", "2");
                    g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 50, 50);
                    caption = string.Format("message='{0}'","kietnm");
                    g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 50, 75);
                    g.DrawImage(pictBarcode.Image, 50, 110);
                }
            }
        }

    }
}
