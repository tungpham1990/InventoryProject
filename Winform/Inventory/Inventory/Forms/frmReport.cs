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
using Inventory.Data.Views;

namespace Inventory
{
    public partial class frmReport : Form
    {

        InventoryEntities invEntities = new InventoryEntities();
        public frmReport()
        {
            InitializeComponent();

            getDataCombo();

            dtpFromdate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTodate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            this.btnSearch.Click -= new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Int64 warehouseId = (Int64)cboWarehouse.SelectedValue;

            var before = DateTime.Compare(dtpFromdate.Value, dtpTodate.Value);
            dtReport.Clear();
            if (before == -1)
            {
                dtReport.Rows.Clear();
                dtReport = ReportView.reportFinal(warehouseId, txtItem_code.Text, dtpFromdate.Value, dtpTodate.Value);
                dtReport.AcceptChanges();
                this.grdView.DataSource = dtReport;
            }
            else
            {
                string sMessage = string.Format("Value Fromdate {0}  >   Todate {1} !", dtpFromdate.Value.ToShortDateString(), dtpTodate.Value.ToShortDateString());
                MessageBox.Show(sMessage);
                dtpFromdate.Focus();
            }           
        }
        private void getDataCombo()
        {
            ///get data Warehouses
            List<warehouse> listW = new List<warehouse>();
            var resultW = (from w in invEntities.warehouses orderby w.warehouse_code select w);
            listW.AddRange(new warehouse[] { new warehouse { warehouse_id = Int64.MinValue, warehouse_code = "<Select a subject>", warehouse_name = "<Select a subject>" } });
            foreach (warehouse item in resultW) listW.Add(item);
            cboWarehouse.DataSource = listW;
            cboWarehouse.ValueMember = "warehouse_id";
            cboWarehouse.DisplayMember = "warehouse_code";
        }
    }
}
