namespace Inventory
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMaster = new System.Windows.Forms.Panel();
            this.cboWarehouse = new System.Windows.Forms.ComboBox();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.dtpTodate = new System.Windows.Forms.DateTimePicker();
            this.lblTodate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpFromdate = new System.Windows.Forms.DateTimePicker();
            this.lblFromdate = new System.Windows.Forms.Label();
            this.txtItem_code = new System.Windows.Forms.TextBox();
            this.lblItem_code = new System.Windows.Forms.Label();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.grdView = new System.Windows.Forms.DataGridView();
            this.dtSet = new System.Data.DataSet();
            this.dtReport = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decrease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMaster.SuspendLayout();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMaster
            // 
            this.panelMaster.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMaster.Controls.Add(this.cboWarehouse);
            this.panelMaster.Controls.Add(this.lblWarehouse);
            this.panelMaster.Controls.Add(this.dtpTodate);
            this.panelMaster.Controls.Add(this.lblTodate);
            this.panelMaster.Controls.Add(this.btnSearch);
            this.panelMaster.Controls.Add(this.dtpFromdate);
            this.panelMaster.Controls.Add(this.lblFromdate);
            this.panelMaster.Controls.Add(this.txtItem_code);
            this.panelMaster.Controls.Add(this.lblItem_code);
            this.panelMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaster.Location = new System.Drawing.Point(0, 0);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(1129, 65);
            this.panelMaster.TabIndex = 2;
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.FormattingEnabled = true;
            this.cboWarehouse.Location = new System.Drawing.Point(81, 8);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Size = new System.Drawing.Size(200, 21);
            this.cboWarehouse.TabIndex = 20;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Location = new System.Drawing.Point(12, 11);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(62, 13);
            this.lblWarehouse.TabIndex = 19;
            this.lblWarehouse.Text = "Warehouse";
            // 
            // dtpTodate
            // 
            this.dtpTodate.Location = new System.Drawing.Point(367, 35);
            this.dtpTodate.Name = "dtpTodate";
            this.dtpTodate.Size = new System.Drawing.Size(200, 20);
            this.dtpTodate.TabIndex = 18;
            // 
            // lblTodate
            // 
            this.lblTodate.AutoSize = true;
            this.lblTodate.Location = new System.Drawing.Point(295, 39);
            this.lblTodate.Name = "lblTodate";
            this.lblTodate.Size = new System.Drawing.Size(43, 13);
            this.lblTodate.TabIndex = 17;
            this.lblTodate.Text = "ToDate";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(573, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpFromdate
            // 
            this.dtpFromdate.Location = new System.Drawing.Point(367, 8);
            this.dtpFromdate.Name = "dtpFromdate";
            this.dtpFromdate.Size = new System.Drawing.Size(200, 20);
            this.dtpFromdate.TabIndex = 3;
            // 
            // lblFromdate
            // 
            this.lblFromdate.AutoSize = true;
            this.lblFromdate.Location = new System.Drawing.Point(295, 11);
            this.lblFromdate.Name = "lblFromdate";
            this.lblFromdate.Size = new System.Drawing.Size(53, 13);
            this.lblFromdate.TabIndex = 2;
            this.lblFromdate.Text = "FromDate";
            // 
            // txtItem_code
            // 
            this.txtItem_code.Location = new System.Drawing.Point(81, 34);
            this.txtItem_code.Name = "txtItem_code";
            this.txtItem_code.Size = new System.Drawing.Size(200, 20);
            this.txtItem_code.TabIndex = 1;
            // 
            // lblItem_code
            // 
            this.lblItem_code.AutoSize = true;
            this.lblItem_code.Location = new System.Drawing.Point(14, 34);
            this.lblItem_code.Name = "lblItem_code";
            this.lblItem_code.Size = new System.Drawing.Size(55, 13);
            this.lblItem_code.TabIndex = 0;
            this.lblItem_code.Text = "Item Code";
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelDetail.Controls.Add(this.grdView);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 65);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(1129, 517);
            this.panelDetail.TabIndex = 3;
            // 
            // grdView
            // 
            this.grdView.AllowUserToAddRows = false;
            this.grdView.AllowUserToDeleteRows = false;
            this.grdView.AutoGenerateColumns = false;
            this.grdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemidDataGridViewTextBoxColumn,
            this.item_code,
            this.item_name,
            this.category_item_id,
            this.category_item_code,
            this.category_item_name,
            this.warehouse_id,
            this.warehouse_code,
            this.warehouse_name,
            this.unit_id,
            this.unit_code,
            this.unit_name,
            this.baseline,
            this.grow,
            this.decrease,
            this.remain,
            this.stock,
            this.balance});
            this.grdView.DataMember = "Report";
            this.grdView.DataSource = this.dtSet;
            this.grdView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdView.Location = new System.Drawing.Point(0, 0);
            this.grdView.Name = "grdView";
            this.grdView.ReadOnly = true;
            this.grdView.Size = new System.Drawing.Size(1129, 517);
            this.grdView.TabIndex = 1;
            // 
            // dtSet
            // 
            this.dtSet.DataSetName = "NewDataSet";
            this.dtSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dtReport});
            // 
            // dtReport
            // 
            this.dtReport.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn17,
            this.dataColumn18});
            this.dtReport.TableName = "Report";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "item_id";
            this.dataColumn1.DataType = typeof(long);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "item_code";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "item_name";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "category_item_id";
            this.dataColumn4.DataType = typeof(long);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "category_item_code";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "category_item_name";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "warehouse_id";
            this.dataColumn7.DataType = typeof(long);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "warehouse_code";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "warehouse_name";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "unit_id";
            this.dataColumn10.DataType = typeof(long);
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "unit_code";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "unit_name";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "baseline";
            this.dataColumn13.DataType = typeof(decimal);
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "grow";
            this.dataColumn14.DataType = typeof(decimal);
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "decrease";
            this.dataColumn15.DataType = typeof(decimal);
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "remain";
            this.dataColumn16.DataType = typeof(decimal);
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "stock";
            this.dataColumn17.DataType = typeof(decimal);
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "balance";
            this.dataColumn18.DataType = typeof(decimal);
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "item_id";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "item_id";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            this.itemidDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemidDataGridViewTextBoxColumn.Visible = false;
            // 
            // item_code
            // 
            this.item_code.DataPropertyName = "item_code";
            this.item_code.HeaderText = "item_code";
            this.item_code.Name = "item_code";
            this.item_code.ReadOnly = true;
            // 
            // item_name
            // 
            this.item_name.DataPropertyName = "item_name";
            this.item_name.HeaderText = "item_name";
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            // 
            // category_item_id
            // 
            this.category_item_id.DataPropertyName = "category_item_id";
            this.category_item_id.HeaderText = "category_item_id";
            this.category_item_id.Name = "category_item_id";
            this.category_item_id.ReadOnly = true;
            this.category_item_id.Visible = false;
            // 
            // category_item_code
            // 
            this.category_item_code.DataPropertyName = "category_item_code";
            this.category_item_code.HeaderText = "category_item_code";
            this.category_item_code.Name = "category_item_code";
            this.category_item_code.ReadOnly = true;
            // 
            // category_item_name
            // 
            this.category_item_name.DataPropertyName = "category_item_name";
            this.category_item_name.HeaderText = "category_item_name";
            this.category_item_name.Name = "category_item_name";
            this.category_item_name.ReadOnly = true;
            // 
            // warehouse_id
            // 
            this.warehouse_id.DataPropertyName = "warehouse_id";
            this.warehouse_id.HeaderText = "warehouse_id";
            this.warehouse_id.Name = "warehouse_id";
            this.warehouse_id.ReadOnly = true;
            this.warehouse_id.Visible = false;
            // 
            // warehouse_code
            // 
            this.warehouse_code.DataPropertyName = "warehouse_code";
            this.warehouse_code.HeaderText = "warehouse_code";
            this.warehouse_code.Name = "warehouse_code";
            this.warehouse_code.ReadOnly = true;
            // 
            // warehouse_name
            // 
            this.warehouse_name.DataPropertyName = "warehouse_name";
            this.warehouse_name.HeaderText = "warehouse_name";
            this.warehouse_name.Name = "warehouse_name";
            this.warehouse_name.ReadOnly = true;
            // 
            // unit_id
            // 
            this.unit_id.DataPropertyName = "unit_id";
            this.unit_id.HeaderText = "unit_id";
            this.unit_id.Name = "unit_id";
            this.unit_id.ReadOnly = true;
            this.unit_id.Visible = false;
            // 
            // unit_code
            // 
            this.unit_code.DataPropertyName = "unit_code";
            this.unit_code.HeaderText = "unit_code";
            this.unit_code.Name = "unit_code";
            this.unit_code.ReadOnly = true;
            this.unit_code.Visible = false;
            // 
            // unit_name
            // 
            this.unit_name.DataPropertyName = "unit_name";
            this.unit_name.HeaderText = "unit_name";
            this.unit_name.Name = "unit_name";
            this.unit_name.ReadOnly = true;
            // 
            // baseline
            // 
            this.baseline.DataPropertyName = "baseline";
            this.baseline.HeaderText = "baseline";
            this.baseline.Name = "baseline";
            this.baseline.ReadOnly = true;
            // 
            // grow
            // 
            this.grow.DataPropertyName = "grow";
            this.grow.HeaderText = "grow";
            this.grow.Name = "grow";
            this.grow.ReadOnly = true;
            // 
            // decrease
            // 
            this.decrease.DataPropertyName = "decrease";
            this.decrease.HeaderText = "decrease";
            this.decrease.Name = "decrease";
            this.decrease.ReadOnly = true;
            // 
            // remain
            // 
            this.remain.DataPropertyName = "remain";
            this.remain.HeaderText = "remain";
            this.remain.Name = "remain";
            this.remain.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // balance
            // 
            this.balance.DataPropertyName = "balance";
            this.balance.HeaderText = "balance";
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 582);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelMaster);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport";
            this.panelMaster.ResumeLayout(false);
            this.panelMaster.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMaster;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.DateTimePicker dtpFromdate;
        private System.Windows.Forms.Label lblFromdate;
        private System.Windows.Forms.Label lblItem_code;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpTodate;
        private System.Windows.Forms.Label lblTodate;
        private System.Windows.Forms.DataGridView grdView;
        private System.Data.DataSet dtSet;
        private System.Data.DataTable dtReport;
        private System.Windows.Forms.ComboBox cboWarehouse;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.TextBox txtItem_code;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseline;
        private System.Windows.Forms.DataGridViewTextBoxColumn grow;
        private System.Windows.Forms.DataGridViewTextBoxColumn decrease;
        private System.Windows.Forms.DataGridViewTextBoxColumn remain;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
    }
}