using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Utilities;
using Inventory.Data;
using Inventory.Data.Models;
using Inventory.Data.Models.ViewModel;
using Inventory.Utilities.Data;
using Inventory.Data.Views;

namespace Inventory
{
    public partial class frmExport : Form
    {
        private Int64 _transaction_master_id = Int64.MinValue;
        private Int64 _formEvents = Int64.MinValue;

        public Int64 FormEvents
        {
            get
            {
                return _formEvents;
            }
            set
            {
                if (_formEvents != value)
                {
                    _formEvents = value;
                    switch (_formEvents)
                    {
                        case 1:
                            btnAdd.Enabled = false;
                            btnEdit.Enabled = false;
                            btnSave.Enabled = true;
                            btnDelete.Enabled = false;
                            btnCancel.Enabled = true;
                            btnSearch.Enabled = true;
                            break;
                        case 2:
                            btnAdd.Enabled = false;
                            btnEdit.Enabled = false;
                            btnSave.Enabled = true;
                            btnDelete.Enabled = true;
                            btnCancel.Enabled = true;
                            btnSearch.Enabled = false;
                            break;
                        case 3:
                            btnAdd.Enabled = true;
                            btnEdit.Enabled = true;
                            btnSave.Enabled = false;
                            btnDelete.Enabled = false;
                            btnCancel.Enabled = false;
                            btnSearch.Enabled = true;
                            break;
                        case 4:
                            btnAdd.Enabled = true;
                            btnEdit.Enabled = true;
                            btnSave.Enabled = false;
                            btnDelete.Enabled = false;
                            btnCancel.Enabled = false;
                            btnSearch.Enabled = true;
                            break;
                        case 5:
                            btnAdd.Enabled = true;
                            btnEdit.Enabled = true;
                            btnSave.Enabled = false;
                            btnDelete.Enabled = false;
                            btnCancel.Enabled = false;
                            btnSearch.Enabled = true;
                            break;
                        case 6:
                            btnAdd.Enabled = true;
                            btnEdit.Enabled = true;
                            btnSave.Enabled = false;
                            btnDelete.Enabled = false;
                            btnCancel.Enabled = false;
                            btnSearch.Enabled = true;
                            break;
                        default:
                            break;
                    }
                }
            }
        }


        public Int64 TransactionMasterId
        {
            get
            {
                return _transaction_master_id;
            }
            set
            {
                if (_transaction_master_id != value)
                {
                    _transaction_master_id = value;

                    getDataCombo();
                    getDataComboForGridView();
                    GetDataById();
                }
            }
        }


        public frmExport()
        {
            InitializeComponent();
            FormEvents = 1;
            getDataCombo();
            getDataComboForGridView();

            this.btnAdd.Click -= new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnSave.Click -= new System.EventHandler(this.btnSave_Click);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnSearch.Click -= new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnDelete.Click -= new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnEdit.Click -= new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.cboDelivered_warehouse.SelectedValueChanged -= new System.EventHandler(this.cboDelivered_warehouse_SelectedValueChanged);
            this.cboDelivered_warehouse.SelectedValueChanged += new System.EventHandler(this.cboDelivered_warehouse_SelectedValueChanged);

            this.grdView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.grdView_CellValueChanged);
            this.grdView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdView_CellValueChanged);
        }


        #region Event

        private void cboDelivered_warehouse_SelectedValueChanged(object sender, EventArgs e)
        {
            if (FormEvents == 1 || FormEvents == 2)
            {
                Int64 warehouseId = -1;
                if (cboDelivered_warehouse.SelectedValue != null && (Int64)cboDelivered_warehouse.SelectedValue != Int64.MinValue)
                    warehouseId = (Int64)cboDelivered_warehouse.SelectedValue;
                var dtReport = ReportView.reportFinal(warehouseId, string.Empty, DateTime.MinValue, DateTime.MinValue);
                dtItem.Clear();
                dtItem.Merge(dtReport);
                dtItem.AcceptChanges();
            }
            else
            {
                InventoryEntities invEntities = new InventoryEntities();
                List<item> listI = new List<item>();
                var resultI = (from i in invEntities.items orderby i.item_code select i);
                listI.AddRange(new item[] { new item { item_id = Int64.MinValue, item_code = "<Select a subject>", item_name = "<Select a subject>" } });
                foreach (item item in resultI) listI.Add(item);
                DataTable tblResultI = Utils.ConvertToDataTable(listI);
                dtItem.Clear();
                dtItem.Merge(tblResultI);
                dtItem.AcceptChanges();
            }
        }

        private void grdView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (FormEvents == 1 || FormEvents == 2)
            {
                if (this.grdView.Columns[e.ColumnIndex].DataPropertyName == colItemId.ColumnName)
                {
                    using (InventoryEntities invEntities = new InventoryEntities())
                    {
                        Int64 itemId = (Int64)this.grdView.CurrentCell.Value;
                        var result = (from i in invEntities.items where i.item_id == itemId select i).FirstOrDefault();
                        this.grdView.CurrentRow.Cells[3].Value = result.item_code;
                        this.grdView.CurrentRow.Cells[4].Value = result.item_name;
                        this.grdView.CurrentRow.Cells[6].Value = result.category_item_id;
                        this.grdView.CurrentRow.Cells[7].Value = result.unit_id;
                        this.grdView.CurrentRow.Cells[9].Value = result.features;
                        this.grdView.CurrentRow.Cells[10].Value = result.specifications;
                        for (int i = 0; i < dtItem.Rows.Count; i++)
                        {
                            if ((Int64)dtItem.Rows[i][colItemId.ColumnName] == itemId && dtItem.Rows[i]["balance"] != null)
                            {
                                this.grdView.CurrentRow.Cells[8].Value = dtItem.Rows[i]["balance"];
                                break;
                            }
                        }

                    }
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEvents = 1;
            TransactionMasterId = Int64.MinValue;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormEvents = 2;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertDate();
            FormEvents = 3;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmExport frmThis = new frmExport();
            frmThis = this;
            this.Hide();
            frmExSearch frm = new frmExSearch(ref frmThis);
            frm.ShowDialog(ref txtTransaction_code);
            FormEvents = 6;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            using (InventoryEntities invEntities = new InventoryEntities())
            {
                /// 
                ///delete transaction master
                ///
                var master = (transaction_master)invEntities.transaction_master.Where(m => m.transaction_master_id == TransactionMasterId).FirstOrDefault();
                if (master != null)
                {
                    ///
                    /// delete transaction detail
                    /// 
                    var details = from d in invEntities.transaction_detail.Where(m => m.transaction_master_id == TransactionMasterId) select d;
                    invEntities.transaction_detail.RemoveRange(details);
                    invEntities.SaveChanges();
                    invEntities.transaction_master.Remove(master);
                    invEntities.SaveChanges();
                }
                ///
                ///reset form value
                ///
                TransactionMasterId = Int64.MinValue;
                FormEvents = 4;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormEvents = 5;
        }


        #endregion
        private void getDataCombo()
        {
            using (InventoryEntities invEntities = new InventoryEntities())
            {

                ///get data Warehouses
                List<warehouse> listR = new List<warehouse>();
                listR.AddRange(new warehouse[] { new warehouse { warehouse_id = Int64.MinValue, warehouse_code = "<Select a subject>", warehouse_name = "<Select a subject>" } });
                ///get data Warehouses
                List<warehouse> listD = new List<warehouse>();
                listD.AddRange(new warehouse[] { new warehouse { warehouse_id = Int64.MinValue, warehouse_code = "<Select a subject>", warehouse_name = "<Select a subject>" } });

                var resultW = (from w in invEntities.warehouses orderby w.warehouse_code select w);
                foreach (warehouse item in resultW)
                {
                    listR.Add(item);
                    listD.Add(item);
                }
                cboReceived_warehouse.DataSource = listR;
                cboReceived_warehouse.ValueMember = "warehouse_id";
                cboReceived_warehouse.DisplayMember = "warehouse_code";

                cboDelivered_warehouse.DataSource = listD;
                cboDelivered_warehouse.ValueMember = "warehouse_id";
                cboDelivered_warehouse.DisplayMember = "warehouse_code";
            }
        }
        private void getDataComboForGridView()
        {
            using (InventoryEntities invEntities = new InventoryEntities())
            {
                ///get data CategoryItem
                List<category_item> listC = new List<category_item>();
                var resultC = (from c in invEntities.category_item orderby c.category_item_code select c);
                listC.AddRange(new category_item[] { new category_item { category_item_id = Int64.MinValue, category_item_code = "<Select a subject>", category_item_name = "<Select a subject>" } });
                foreach (category_item item in resultC) listC.Add(item);
                DataTable tblResultC = Utils.ConvertToDataTable(listC);
                dtCategory_item.Clear();
                dtCategory_item.Merge(tblResultC);
                dtCategory_item.AcceptChanges();

                ///get data Unit
                List<unit> listU = new List<unit>();
                var resultU = (from u in invEntities.units orderby u.unit_code select u);
                listU.AddRange(new unit[] { new unit { unit_id = Int64.MinValue, unit_code = "<Select a subject>", unit_name = "<Select a subject>" } });
                foreach (unit item in resultU) listU.Add(item);
                DataTable tblResultU = Utils.ConvertToDataTable(listU);
                dtUnit.Clear();
                dtUnit.Merge(tblResultU);
                dtUnit.AcceptChanges();

                ///
                ///get data Item
                ///
                if (FormEvents == 1 || FormEvents == 2)
                {
                    Int64 warehouseId = -1;
                    if (cboDelivered_warehouse.SelectedValue != null && (Int64)cboDelivered_warehouse.SelectedValue != Int64.MinValue)
                        warehouseId = (Int64)cboDelivered_warehouse.SelectedValue;
                    var dtReport = ReportView.reportFinal(warehouseId, string.Empty, DateTime.MinValue, DateTime.MinValue);
                    dtItem.Clear();
                    dtItem.Merge(dtReport);
                    dtItem.AcceptChanges();
                }
                else
                {
                    List<item> listI = new List<item>();
                    var resultI = (from i in invEntities.items orderby i.item_code select i);
                    listI.AddRange(new item[] { new item { item_id = Int64.MinValue, item_code = "<Select a subject>", item_name = "<Select a subject>" } });
                    foreach (item item in resultI) listI.Add(item);
                    DataTable tblResultI = Utils.ConvertToDataTable(listI);
                    dtItem.Clear();
                    dtItem.Merge(tblResultI);
                    dtItem.AcceptChanges();
                }
            }
        }
        private void InsertDate()
        {
            using (InventoryEntities invEntities = new InventoryEntities())
            {
                var new_Master_Id = Int64.MinValue;
                #region insert or update master
                var udm = from m in invEntities.transaction_master
                          where m.transaction_master_id == this.TransactionMasterId
                          select m;
                transaction_master obj = udm.SingleOrDefault();
                if (obj == null)
                    obj = new transaction_master();
                ///set data to object 
                obj.transaction_code = txtTransaction_code.Text.Trim();
                obj.transaction_type_id = 2;
                obj.transaction_date = dtpTransaction_date.Value;
                if ((Int64)cboReceived_warehouse.SelectedValue != Int64.MinValue)
                    obj.received_warehouse_id = (Int64)cboReceived_warehouse.SelectedValue;
                obj.enabled = true;
                obj.receiver = txtReceiver.Text.Trim();
                obj.deliver = txtDeliver.Text.Trim();
                if ((Int64)cboDelivered_warehouse.SelectedValue != Int64.MinValue)
                    obj.delivered_warehouse_id = (Int64)cboDelivered_warehouse.SelectedValue;
                obj.description = txtDescription.Text.Trim();
                obj.created_date = DateTime.Now;
                obj.create_user = txtCreate_user.Text.Trim();
                obj.update_date = DateTime.Now;
                obj.update_user = txtCreate_user.Text.Trim();
                if (obj.transaction_master_id == 0)
                    invEntities.transaction_master.Add(obj);
                invEntities.SaveChanges();
                new_Master_Id = obj.transaction_master_id;

                #endregion end insert master;
                #region insert detail and item
                for (int i = 0; i < dtTransaction_detail.Rows.Count; i++)
                {
                    if (dtTransaction_detail.Rows[i].RowState == DataRowState.Added || dtTransaction_detail.Rows[i].RowState == DataRowState.Modified)
                    {
                        ///
                        /// insert or update transaction_detail
                        /// 
                        var detailId = string.IsNullOrEmpty(dtTransaction_detail.Rows[i][coltransaction_detail_id.DataPropertyName].ToString()) ? Int64.MinValue : (Int64)dtTransaction_detail.Rows[i][coltransaction_detail_id.DataPropertyName];
                        var udd = from d in invEntities.transaction_detail
                                  where d.transaction_detail_id == detailId
                                  select d;
                        transaction_detail objDetail = udd.SingleOrDefault();
                        if (objDetail == null)
                            objDetail = new transaction_detail();
                        objDetail.transaction_master_id = obj.transaction_master_id;
                        objDetail.category_item_id = (Int64)dtTransaction_detail.Rows[i][colCategoryItemId.ColumnName];
                        objDetail.item_id = (Int64)dtTransaction_detail.Rows[i][colItemId.ColumnName];
                        if (!string.IsNullOrEmpty(dtTransaction_detail.Rows[i][colQuantity.ColumnName].ToString()))
                            objDetail.quantity = (decimal)dtTransaction_detail.Rows[i][colQuantity.ColumnName];
                        if (!string.IsNullOrEmpty(dtTransaction_detail.Rows[i][colUnitId.ColumnName].ToString()))
                            objDetail.unit_id = (Int64)dtTransaction_detail.Rows[i][colUnitId.ColumnName];
                        objDetail.description = dtTransaction_detail.Rows[i][colDescription.ColumnName].ToString();
                        objDetail.create_user = obj.create_user;
                        objDetail.update_user = obj.create_user;
                        objDetail.created_date = DateTime.Now;
                        objDetail.update_date = DateTime.Now;
                        if (objDetail.transaction_detail_id == 0)
                        {
                            invEntities.transaction_detail.Add(objDetail);
                        }
                        invEntities.SaveChanges();
                    }
                    else if (dtTransaction_detail.Rows[i].RowState == DataRowState.Deleted)
                    {

                    }
                }

                #endregion end insert detail and item
                #region reload data
                if (new_Master_Id != TransactionMasterId)
                {
                    this.TransactionMasterId = new_Master_Id;
                }
                else
                {
                    getDataCombo();
                    getDataComboForGridView();
                    GetDataById();
                }

                #endregion end reload data
            }
        }

        private void GetDataById()
        {
            using (InventoryEntities invEntities = new InventoryEntities())
            {
                ///get data table TransactionMasters             
                var result = (from m in invEntities.transaction_master where m.transaction_master_id == TransactionMasterId select m).FirstOrDefault();
                if (result != null)
                {
                    txtTransaction_code.Text = result.transaction_code;
                    dtpTransaction_date.Value = result.transaction_date;
                    cboReceived_warehouse.SelectedValue = result.received_warehouse_id == null ? Int64.MinValue : result.received_warehouse_id;
                    cboDelivered_warehouse.SelectedValue = result.delivered_warehouse_id == null ? Int64.MinValue : result.delivered_warehouse_id;
                    txtDescription.Text = result.description;
                    txtDeliver.Text = result.deliver;
                    txtReceiver.Text = result.receiver;
                    txtCreate_user.Text = result.create_user;
                }
                else
                {
                    txtTransaction_code.Text = string.Empty;
                    dtpTransaction_date.Value = DateTime.Now;
                    cboReceived_warehouse.SelectedValue = Int64.MinValue;
                    cboDelivered_warehouse.SelectedValue = Int64.MinValue;
                    txtDescription.Text = string.Empty;
                    txtDeliver.Text = string.Empty;
                    txtReceiver.Text = string.Empty;
                    txtCreate_user.Text = string.Empty;
                }

                ///get data table TransactionDetails
                var query = default(IEnumerable<TransactionDetailViewModel>);

                query = from d in invEntities.transaction_detail
                        where d.transaction_master_id == TransactionMasterId
                        select new TransactionDetailViewModel
                                    {
                                        transaction_master_id = d.transaction_master_id,
                                        transaction_detail_id = d.transaction_detail_id,
                                        category_item_id = d.category_item_id,
                                        category_item_code = d.category_item.category_item_code,
                                        category_item_name = d.category_item.category_item_name,
                                        item_id = d.item_id,
                                        item_code = d.item.item_code,
                                        item_name = d.item.item_name,
                                        price = d.price,
                                        unit_id = d.unit_id,
                                        unit_code = d.unit.unit_code,
                                        unit_name = d.unit.unit_name,
                                        quantity = d.quantity,
                                        total_price = d.total_price,
                                        percent_charges = d.total_price,
                                        total_charges = d.total_charges,
                                        total_amount = d.total_amount,
                                        description = d.description,
                                        create_user = d.create_user,
                                        created_date = d.created_date,
                                        features = d.item.features,
                                        specifications = d.item.specifications
                                    };
                dtTransaction_detail.Rows.Clear();
                dtTransaction_detail = Utils.ToDataTable(query);
                dtTransaction_detail.AcceptChanges();
                if (dtTransaction_detail != null && dtTransaction_detail.Rows.Count>0)
                    this.grdView.DataSource = dtTransaction_detail;
            }
        }
    }
}
