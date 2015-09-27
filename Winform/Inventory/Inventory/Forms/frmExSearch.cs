using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Data;
using Inventory.Data.Models;
using Inventory.Data.Models.ViewModel;
using Inventory.Utilities;
using Inventory.Utilities.Data;

namespace Inventory
{
    public partial class frmExSearch : Form
    {
        public static frmExport refForm;

        public frmExSearch(ref frmExport frmHandel)
        {
            InitializeComponent();

            dtpTransaction_fromdate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTransaction_todate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            refForm = frmHandel;

            this.btnSearch.Click -= new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.grdView.MouseDoubleClick -= new System.Windows.Forms.MouseEventHandler(this.grdView_MouseDoubleClick);
            this.grdView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdView_MouseDoubleClick);

        }

        public void ShowDialog(ref TextBox txtTransactionCodeImport)
        {
            //Assign received parameter(s) to local context
            txtTransaction_code.Text = txtTransactionCodeImport.Text;
            this.ShowDialog(); //Display and activate this form (Form2)
            //Return parameter(s)
            // txtTransactionCodeImport.Text = txtTransactionCode.Text;          
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (InventoryEntities invEntities = new InventoryEntities())
            {
                var query = default(IEnumerable<TransactionMasterViewModel>);
                ///get data TransactionMasters
                query = (from t in invEntities.transaction_master
                         where t.transaction_code.Contains(txtTransaction_code.Text)
                                         && DateTime.Compare(t.transaction_date, dtpTransaction_fromdate.Value) >= 0
                                         && DateTime.Compare(t.transaction_date, dtpTransaction_todate.Value) <= 0
                                         && t.transaction_type_id == 2
                         select new TransactionMasterViewModel
                                   {
                                       transaction_master_id = t.transaction_master_id,
                                       transaction_code = t.transaction_code,
                                       transaction_date = t.transaction_date,
                                       transaction_type_id = t.transaction_type_id,
                                       transaction_type_code = t.transaction_type.transaction_type_code,
                                       received_warehouse_id = t.received_warehouse_id,
                                       received_warehouse_code = t.received_warehouse.warehouse_code,
                                       received_warehouse_name = t.received_warehouse.warehouse_name,
                                       delivered_warehouse_id = t.delivered_warehouse.warehouse_id,
                                       delivered_warehouse_code = t.delivered_warehouse.warehouse_code,
                                       delivered_warehouse_name = t.delivered_warehouse.warehouse_name,
                                       receiver = t.receiver,
                                       deliver = t.deliver,
                                       customer_id = t.customer_id,
                                       customer_code = t.customer.customer_code,
                                       customer_name = t.customer.customer_name,
                                       supplier_id = t.supplier_id,
                                       supplier_code = t.supplier.supplier_code,
                                       supplier_name = t.supplier.supplier_name,
                                       description = t.description,
                                       create_user = t.create_user,
                                       created_date = t.created_date,
                                       update_user = t.update_user,
                                       update_date = t.update_date
                                   });
                dtTransaction_master = Utils.ToDataTable(query);
                dtTransaction_master.AcceptChanges();
                this.grdView.DataSource = dtTransaction_master;
            }
        }
        private void grdView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.grdView.CurrentRow != null)
            {
                refForm.TransactionMasterId = Int64.Parse(this.grdView.CurrentRow.Cells[0].Value.ToString());
                refForm.Show();
                this.Close();
            }
        }
    }
}
