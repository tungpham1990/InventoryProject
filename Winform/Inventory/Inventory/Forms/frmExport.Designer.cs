namespace Inventory
{
    partial class frmExport
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCreate_user = new System.Windows.Forms.TextBox();
            this.lblCreate_user = new System.Windows.Forms.Label();
            this.cboDelivered_warehouse = new System.Windows.Forms.ComboBox();
            this.lbldelivered_warehosuse = new System.Windows.Forms.Label();
            this.txtDeliver = new System.Windows.Forms.TextBox();
            this.lblDeliver = new System.Windows.Forms.Label();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.lblReceiver = new System.Windows.Forms.Label();
            this.cboReceived_warehouse = new System.Windows.Forms.ComboBox();
            this.lblReceived_warehouse = new System.Windows.Forms.Label();
            this.lblTransaction_type = new System.Windows.Forms.Label();
            this.dtpTransaction_date = new System.Windows.Forms.DateTimePicker();
            this.lblTransaction_date = new System.Windows.Forms.Label();
            this.txtTransaction_code = new System.Windows.Forms.TextBox();
            this.lblTransaction_code = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.grdView = new System.Windows.Forms.DataGridView();
            this.coltransaction_detail_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltransaction_master_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colitem_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dtSet = new System.Data.DataSet();
            this.dtTransaction_detail = new System.Data.DataTable();
            this.colTransactionDetailId = new System.Data.DataColumn();
            this.colTransactionMasterId = new System.Data.DataColumn();
            this.colCategoryItemId = new System.Data.DataColumn();
            this.colItemId = new System.Data.DataColumn();
            this.colPrice = new System.Data.DataColumn();
            this.colUnitId = new System.Data.DataColumn();
            this.colQuantity = new System.Data.DataColumn();
            this.colTotalPrice = new System.Data.DataColumn();
            this.colPercentCharges = new System.Data.DataColumn();
            this.colTotalCharges = new System.Data.DataColumn();
            this.colTotalAmount = new System.Data.DataColumn();
            this.colDescription = new System.Data.DataColumn();
            this.colCreatedDate = new System.Data.DataColumn();
            this.colCreateUser = new System.Data.DataColumn();
            this.colUpdateDate = new System.Data.DataColumn();
            this.colUpdateUser = new System.Data.DataColumn();
            this.colFeatures = new System.Data.DataColumn();
            this.colSpecifications = new System.Data.DataColumn();
            this.colItemCode = new System.Data.DataColumn();
            this.colItemName = new System.Data.DataColumn();
            this.dtUnit = new System.Data.DataTable();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dtCategory_item = new System.Data.DataTable();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dtItem = new System.Data.DataTable();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.colitem_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colitem_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcategory_item_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colunit_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbcquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcfeatures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcspecifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbctotal_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcpercent_charges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbctotal_charges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbctotal_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbccreated_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbccreate_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcupdate_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcupdate_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelMaster.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTransaction_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCategory_item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtItem)).BeginInit();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMaster
            // 
            this.panelMaster.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMaster.Controls.Add(this.btnCancel);
            this.panelMaster.Controls.Add(this.btnEdit);
            this.panelMaster.Controls.Add(this.lblDescription);
            this.panelMaster.Controls.Add(this.txtDescription);
            this.panelMaster.Controls.Add(this.btnDelete);
            this.panelMaster.Controls.Add(this.btnAdd);
            this.panelMaster.Controls.Add(this.btnSearch);
            this.panelMaster.Controls.Add(this.btnSave);
            this.panelMaster.Controls.Add(this.txtCreate_user);
            this.panelMaster.Controls.Add(this.lblCreate_user);
            this.panelMaster.Controls.Add(this.cboDelivered_warehouse);
            this.panelMaster.Controls.Add(this.lbldelivered_warehosuse);
            this.panelMaster.Controls.Add(this.txtDeliver);
            this.panelMaster.Controls.Add(this.lblDeliver);
            this.panelMaster.Controls.Add(this.txtReceiver);
            this.panelMaster.Controls.Add(this.lblReceiver);
            this.panelMaster.Controls.Add(this.cboReceived_warehouse);
            this.panelMaster.Controls.Add(this.lblReceived_warehouse);
            this.panelMaster.Controls.Add(this.lblTransaction_type);
            this.panelMaster.Controls.Add(this.dtpTransaction_date);
            this.panelMaster.Controls.Add(this.lblTransaction_date);
            this.panelMaster.Controls.Add(this.txtTransaction_code);
            this.panelMaster.Controls.Add(this.lblTransaction_code);
            this.panelMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaster.Location = new System.Drawing.Point(0, 24);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(1046, 106);
            this.panelMaster.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(653, 35);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(721, 32);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(313, 64);
            this.txtDescription.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(878, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(640, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(305, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(797, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtCreate_user
            // 
            this.txtCreate_user.Location = new System.Drawing.Point(438, 31);
            this.txtCreate_user.Name = "txtCreate_user";
            this.txtCreate_user.Size = new System.Drawing.Size(200, 20);
            this.txtCreate_user.TabIndex = 14;
            // 
            // lblCreate_user
            // 
            this.lblCreate_user.AutoSize = true;
            this.lblCreate_user.Location = new System.Drawing.Point(352, 36);
            this.lblCreate_user.Name = "lblCreate_user";
            this.lblCreate_user.Size = new System.Drawing.Size(60, 13);
            this.lblCreate_user.TabIndex = 13;
            this.lblCreate_user.Text = "CreateUser";
            // 
            // cboDelivered_warehouse
            // 
            this.cboDelivered_warehouse.FormattingEnabled = true;
            this.cboDelivered_warehouse.Location = new System.Drawing.Point(132, 80);
            this.cboDelivered_warehouse.Name = "cboDelivered_warehouse";
            this.cboDelivered_warehouse.Size = new System.Drawing.Size(200, 21);
            this.cboDelivered_warehouse.TabIndex = 12;
            // 
            // lbldelivered_warehosuse
            // 
            this.lbldelivered_warehosuse.AutoSize = true;
            this.lbldelivered_warehosuse.Location = new System.Drawing.Point(14, 85);
            this.lbldelivered_warehosuse.Name = "lbldelivered_warehosuse";
            this.lbldelivered_warehosuse.Size = new System.Drawing.Size(110, 13);
            this.lbldelivered_warehosuse.TabIndex = 11;
            this.lbldelivered_warehosuse.Text = "Delivered Warehouse";
            // 
            // txtDeliver
            // 
            this.txtDeliver.Location = new System.Drawing.Point(438, 76);
            this.txtDeliver.Name = "txtDeliver";
            this.txtDeliver.Size = new System.Drawing.Size(200, 20);
            this.txtDeliver.TabIndex = 10;
            // 
            // lblDeliver
            // 
            this.lblDeliver.AutoSize = true;
            this.lblDeliver.Location = new System.Drawing.Point(352, 81);
            this.lblDeliver.Name = "lblDeliver";
            this.lblDeliver.Size = new System.Drawing.Size(40, 13);
            this.lblDeliver.TabIndex = 9;
            this.lblDeliver.Text = "Deliver";
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(438, 53);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(200, 20);
            this.txtReceiver.TabIndex = 8;
            // 
            // lblReceiver
            // 
            this.lblReceiver.AutoSize = true;
            this.lblReceiver.Location = new System.Drawing.Point(352, 58);
            this.lblReceiver.Name = "lblReceiver";
            this.lblReceiver.Size = new System.Drawing.Size(50, 13);
            this.lblReceiver.TabIndex = 7;
            this.lblReceiver.Text = "Receiver";
            // 
            // cboReceived_warehouse
            // 
            this.cboReceived_warehouse.FormattingEnabled = true;
            this.cboReceived_warehouse.Location = new System.Drawing.Point(132, 56);
            this.cboReceived_warehouse.Name = "cboReceived_warehouse";
            this.cboReceived_warehouse.Size = new System.Drawing.Size(200, 21);
            this.cboReceived_warehouse.TabIndex = 6;
            // 
            // lblReceived_warehouse
            // 
            this.lblReceived_warehouse.AutoSize = true;
            this.lblReceived_warehouse.Location = new System.Drawing.Point(14, 60);
            this.lblReceived_warehouse.Name = "lblReceived_warehouse";
            this.lblReceived_warehouse.Size = new System.Drawing.Size(111, 13);
            this.lblReceived_warehouse.TabIndex = 5;
            this.lblReceived_warehouse.Text = "Received Warehouse";
            // 
            // lblTransaction_type
            // 
            this.lblTransaction_type.AutoSize = true;
            this.lblTransaction_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaction_type.Location = new System.Drawing.Point(352, 11);
            this.lblTransaction_type.Name = "lblTransaction_type";
            this.lblTransaction_type.Size = new System.Drawing.Size(150, 13);
            this.lblTransaction_type.TabIndex = 4;
            this.lblTransaction_type.Text = "Transaction Type: Export";
            // 
            // dtpTransaction_date
            // 
            this.dtpTransaction_date.Location = new System.Drawing.Point(132, 33);
            this.dtpTransaction_date.Name = "dtpTransaction_date";
            this.dtpTransaction_date.Size = new System.Drawing.Size(200, 20);
            this.dtpTransaction_date.TabIndex = 3;
            // 
            // lblTransaction_date
            // 
            this.lblTransaction_date.AutoSize = true;
            this.lblTransaction_date.Location = new System.Drawing.Point(14, 36);
            this.lblTransaction_date.Name = "lblTransaction_date";
            this.lblTransaction_date.Size = new System.Drawing.Size(89, 13);
            this.lblTransaction_date.TabIndex = 2;
            this.lblTransaction_date.Text = "Transaction Date";
            // 
            // txtTransaction_code
            // 
            this.txtTransaction_code.Location = new System.Drawing.Point(132, 9);
            this.txtTransaction_code.Name = "txtTransaction_code";
            this.txtTransaction_code.Size = new System.Drawing.Size(172, 20);
            this.txtTransaction_code.TabIndex = 1;
            // 
            // lblTransaction_code
            // 
            this.lblTransaction_code.AutoSize = true;
            this.lblTransaction_code.Location = new System.Drawing.Point(14, 12);
            this.lblTransaction_code.Name = "lblTransaction_code";
            this.lblTransaction_code.Size = new System.Drawing.Size(91, 13);
            this.lblTransaction_code.TabIndex = 0;
            this.lblTransaction_code.Text = "Transaction Code";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMain.Controls.Add(this.panelDetail);
            this.panelMain.Controls.Add(this.panelMaster);
            this.panelMain.Controls.Add(this.menuMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1046, 582);
            this.panelMain.TabIndex = 3;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.grdView);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 130);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(1046, 452);
            this.panelDetail.TabIndex = 3;
            // 
            // grdView
            // 
            this.grdView.AutoGenerateColumns = false;
            this.grdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coltransaction_detail_id,
            this.coltransaction_master_id,
            this.colitem_id,
            this.colitem_code,
            this.colitem_name,
            this.tbcprice,
            this.colcategory_item_id,
            this.colunit_id,
            this.tbcquantity,
            this.tbcfeatures,
            this.tbcspecifications,
            this.tbctotal_price,
            this.tbcpercent_charges,
            this.tbctotal_charges,
            this.tbctotal_amount,
            this.tbcdescription,
            this.tbccreated_date,
            this.tbccreate_user,
            this.tbcupdate_date,
            this.tbcupdate_user});
            this.grdView.DataMember = "Transaction_detail";
            this.grdView.DataSource = this.dtSet;
            this.grdView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdView.Location = new System.Drawing.Point(0, 0);
            this.grdView.Name = "grdView";
            this.grdView.Size = new System.Drawing.Size(1046, 452);
            this.grdView.TabIndex = 0;
            // 
            // coltransaction_detail_id
            // 
            this.coltransaction_detail_id.DataPropertyName = "transaction_detail_id";
            this.coltransaction_detail_id.HeaderText = "transaction_detail_id";
            this.coltransaction_detail_id.Name = "coltransaction_detail_id";
            this.coltransaction_detail_id.Visible = false;
            // 
            // coltransaction_master_id
            // 
            this.coltransaction_master_id.DataPropertyName = "transaction_master_id";
            this.coltransaction_master_id.HeaderText = "transaction_master_id";
            this.coltransaction_master_id.Name = "coltransaction_master_id";
            this.coltransaction_master_id.Visible = false;
            // 
            // colitem_id
            // 
            this.colitem_id.DataPropertyName = "item_id";
            this.colitem_id.DataSource = this.dtSet;
            this.colitem_id.DisplayMember = "Item.item_code";
            this.colitem_id.HeaderText = "item_id";
            this.colitem_id.Name = "colitem_id";
            this.colitem_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colitem_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colitem_id.ValueMember = "Item.item_id";
            this.colitem_id.Width = 150;
            // 
            // dtSet
            // 
            this.dtSet.DataSetName = "NewDataSet";
            this.dtSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dtTransaction_detail,
            this.dtUnit,
            this.dtCategory_item,
            this.dtItem});
            // 
            // dtTransaction_detail
            // 
            this.dtTransaction_detail.Columns.AddRange(new System.Data.DataColumn[] {
            this.colTransactionDetailId,
            this.colTransactionMasterId,
            this.colCategoryItemId,
            this.colItemId,
            this.colPrice,
            this.colUnitId,
            this.colQuantity,
            this.colTotalPrice,
            this.colPercentCharges,
            this.colTotalCharges,
            this.colTotalAmount,
            this.colDescription,
            this.colCreatedDate,
            this.colCreateUser,
            this.colUpdateDate,
            this.colUpdateUser,
            this.colFeatures,
            this.colSpecifications,
            this.colItemCode,
            this.colItemName});
            this.dtTransaction_detail.TableName = "Transaction_detail";
            // 
            // colTransactionDetailId
            // 
            this.colTransactionDetailId.Caption = "transaction_detail_id";
            this.colTransactionDetailId.ColumnName = "transaction_detail_id";
            this.colTransactionDetailId.DataType = typeof(long);
            // 
            // colTransactionMasterId
            // 
            this.colTransactionMasterId.Caption = "transaction_master_id";
            this.colTransactionMasterId.ColumnName = "transaction_master_id";
            this.colTransactionMasterId.DataType = typeof(long);
            // 
            // colCategoryItemId
            // 
            this.colCategoryItemId.ColumnName = "category_item_id";
            this.colCategoryItemId.DataType = typeof(long);
            // 
            // colItemId
            // 
            this.colItemId.ColumnName = "item_id";
            this.colItemId.DataType = typeof(long);
            // 
            // colPrice
            // 
            this.colPrice.Caption = "price";
            this.colPrice.ColumnName = "price";
            this.colPrice.DataType = typeof(decimal);
            // 
            // colUnitId
            // 
            this.colUnitId.ColumnName = "unit_id";
            this.colUnitId.DataType = typeof(long);
            // 
            // colQuantity
            // 
            this.colQuantity.ColumnName = "quantity";
            this.colQuantity.DataType = typeof(decimal);
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.ColumnName = "total_price";
            this.colTotalPrice.DataType = typeof(decimal);
            // 
            // colPercentCharges
            // 
            this.colPercentCharges.ColumnName = "percent_charges";
            this.colPercentCharges.DataType = typeof(decimal);
            // 
            // colTotalCharges
            // 
            this.colTotalCharges.ColumnName = "total_charges";
            this.colTotalCharges.DataType = typeof(decimal);
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.ColumnName = "total_amount";
            this.colTotalAmount.DataType = typeof(decimal);
            // 
            // colDescription
            // 
            this.colDescription.ColumnName = "description";
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.ColumnName = "created_date";
            this.colCreatedDate.DataType = typeof(System.DateTime);
            // 
            // colCreateUser
            // 
            this.colCreateUser.ColumnName = "create_user";
            // 
            // colUpdateDate
            // 
            this.colUpdateDate.Caption = "update_date";
            this.colUpdateDate.ColumnName = "update_date";
            this.colUpdateDate.DataType = typeof(System.DateTime);
            // 
            // colUpdateUser
            // 
            this.colUpdateUser.ColumnName = "update_user";
            // 
            // colFeatures
            // 
            this.colFeatures.ColumnName = "features";
            // 
            // colSpecifications
            // 
            this.colSpecifications.ColumnName = "specifications";
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "item_code";
            this.colItemCode.ColumnName = "item_code";
            // 
            // colItemName
            // 
            this.colItemName.ColumnName = "item_name";
            // 
            // dtUnit
            // 
            this.dtUnit.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
            this.dtUnit.TableName = "Unit";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "unit_id";
            this.dataColumn3.DataType = typeof(long);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "unit_code";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "unit_name";
            // 
            // dtCategory_item
            // 
            this.dtCategory_item.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.dtCategory_item.TableName = "Category_item";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "category_item_id";
            this.dataColumn6.ColumnName = "category_item_id";
            this.dataColumn6.DataType = typeof(long);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "category_item_code";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "category_item_name";
            // 
            // dtItem
            // 
            this.dtItem.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11});
            this.dtItem.TableName = "Item";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "item_id";
            this.dataColumn9.DataType = typeof(long);
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "item_code";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "item_name";
            // 
            // colitem_code
            // 
            this.colitem_code.DataPropertyName = "item_code";
            this.colitem_code.HeaderText = "item_code";
            this.colitem_code.Name = "colitem_code";
            this.colitem_code.ReadOnly = true;
            this.colitem_code.Width = 200;
            // 
            // colitem_name
            // 
            this.colitem_name.DataPropertyName = "item_name";
            this.colitem_name.HeaderText = "item_name";
            this.colitem_name.Name = "colitem_name";
            this.colitem_name.ReadOnly = true;
            this.colitem_name.Width = 250;
            // 
            // tbcprice
            // 
            this.tbcprice.DataPropertyName = "price";
            this.tbcprice.HeaderText = "price";
            this.tbcprice.Name = "tbcprice";
            this.tbcprice.Visible = false;
            // 
            // colcategory_item_id
            // 
            this.colcategory_item_id.DataPropertyName = "category_item_id";
            this.colcategory_item_id.DataSource = this.dtSet;
            this.colcategory_item_id.DisplayMember = "Category_item.category_item_name";
            this.colcategory_item_id.HeaderText = "category_item_id";
            this.colcategory_item_id.Name = "colcategory_item_id";
            this.colcategory_item_id.ReadOnly = true;
            this.colcategory_item_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colcategory_item_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colcategory_item_id.ValueMember = "Category_item.category_item_id";
            this.colcategory_item_id.Width = 150;
            // 
            // colunit_id
            // 
            this.colunit_id.DataPropertyName = "unit_id";
            this.colunit_id.DataSource = this.dtSet;
            this.colunit_id.DisplayMember = "Unit.unit_name";
            this.colunit_id.HeaderText = "unit_id";
            this.colunit_id.Name = "colunit_id";
            this.colunit_id.ReadOnly = true;
            this.colunit_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colunit_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colunit_id.ValueMember = "Unit.unit_id";
            this.colunit_id.Width = 90;
            // 
            // tbcquantity
            // 
            this.tbcquantity.DataPropertyName = "quantity";
            this.tbcquantity.HeaderText = "quantity";
            this.tbcquantity.Name = "tbcquantity";
            // 
            // tbcfeatures
            // 
            this.tbcfeatures.DataPropertyName = "features";
            this.tbcfeatures.HeaderText = "features";
            this.tbcfeatures.Name = "tbcfeatures";
            this.tbcfeatures.ReadOnly = true;
            this.tbcfeatures.Width = 250;
            // 
            // tbcspecifications
            // 
            this.tbcspecifications.DataPropertyName = "specifications";
            this.tbcspecifications.HeaderText = "specifications";
            this.tbcspecifications.Name = "tbcspecifications";
            this.tbcspecifications.ReadOnly = true;
            this.tbcspecifications.Width = 250;
            // 
            // tbctotal_price
            // 
            this.tbctotal_price.DataPropertyName = "total_price";
            this.tbctotal_price.HeaderText = "total_price";
            this.tbctotal_price.Name = "tbctotal_price";
            this.tbctotal_price.Visible = false;
            // 
            // tbcpercent_charges
            // 
            this.tbcpercent_charges.DataPropertyName = "percent_charges";
            this.tbcpercent_charges.HeaderText = "percent_charges";
            this.tbcpercent_charges.Name = "tbcpercent_charges";
            this.tbcpercent_charges.Visible = false;
            // 
            // tbctotal_charges
            // 
            this.tbctotal_charges.DataPropertyName = "total_charges";
            this.tbctotal_charges.HeaderText = "total_charges";
            this.tbctotal_charges.Name = "tbctotal_charges";
            this.tbctotal_charges.Visible = false;
            // 
            // tbctotal_amount
            // 
            this.tbctotal_amount.DataPropertyName = "total_amount";
            this.tbctotal_amount.HeaderText = "total_amount";
            this.tbctotal_amount.Name = "tbctotal_amount";
            this.tbctotal_amount.Visible = false;
            // 
            // tbcdescription
            // 
            this.tbcdescription.DataPropertyName = "description";
            this.tbcdescription.HeaderText = "description";
            this.tbcdescription.Name = "tbcdescription";
            this.tbcdescription.Width = 200;
            // 
            // tbccreated_date
            // 
            this.tbccreated_date.DataPropertyName = "created_date";
            this.tbccreated_date.HeaderText = "created_date";
            this.tbccreated_date.Name = "tbccreated_date";
            this.tbccreated_date.Visible = false;
            // 
            // tbccreate_user
            // 
            this.tbccreate_user.DataPropertyName = "create_user";
            this.tbccreate_user.HeaderText = "create_user";
            this.tbccreate_user.Name = "tbccreate_user";
            this.tbccreate_user.Visible = false;
            // 
            // tbcupdate_date
            // 
            this.tbcupdate_date.DataPropertyName = "update_date";
            this.tbcupdate_date.HeaderText = "update_date";
            this.tbcupdate_date.Name = "tbcupdate_date";
            this.tbcupdate_date.Visible = false;
            // 
            // tbcupdate_user
            // 
            this.tbcupdate_user.DataPropertyName = "update_user";
            this.tbcupdate_user.HeaderText = "update_user";
            this.tbcupdate_user.Name = "tbcupdate_user";
            this.tbcupdate_user.Visible = false;
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1046, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuMain";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.managerToolStripMenuItem.Text = "Administrator";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(716, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(959, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 582);
            this.Controls.Add(this.panelMain);
            this.Name = "frmExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExport";
            this.panelMaster.ResumeLayout(false);
            this.panelMaster.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTransaction_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCategory_item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtItem)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMaster;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTransaction_type;
        private System.Windows.Forms.DateTimePicker dtpTransaction_date;
        private System.Windows.Forms.Label lblTransaction_date;
        private System.Windows.Forms.TextBox txtTransaction_code;
        private System.Windows.Forms.Label lblTransaction_code;
        private System.Windows.Forms.ComboBox cboDelivered_warehouse;
        private System.Windows.Forms.Label lbldelivered_warehosuse;
        private System.Windows.Forms.TextBox txtDeliver;
        private System.Windows.Forms.Label lblDeliver;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.Label lblReceiver;
        private System.Windows.Forms.ComboBox cboReceived_warehouse;
        private System.Windows.Forms.Label lblReceived_warehouse;
        private System.Windows.Forms.TextBox txtCreate_user;
        private System.Windows.Forms.Label lblCreate_user;
        private System.Windows.Forms.DataGridView grdView;
        private System.Windows.Forms.Button btnSave;
        private System.Data.DataSet dtSet;
        private System.Data.DataTable dtTransaction_detail;
        private System.Data.DataColumn colTransactionDetailId;
        private System.Data.DataColumn colTransactionMasterId;
        private System.Data.DataColumn colCategoryItemId;
        private System.Data.DataColumn colItemId;
        private System.Data.DataColumn colPrice;
        private System.Data.DataColumn colUnitId;
        private System.Data.DataColumn colQuantity;
        private System.Data.DataColumn colTotalPrice;
        private System.Data.DataColumn colPercentCharges;
        private System.Data.DataColumn colTotalCharges;
        private System.Data.DataColumn colTotalAmount;
        private System.Data.DataColumn colDescription;
        private System.Data.DataColumn colCreatedDate;
        private System.Data.DataColumn colCreateUser;
        private System.Data.DataColumn colUpdateDate;
        private System.Data.DataColumn colUpdateUser;
        private System.Windows.Forms.Button btnSearch;
        private System.Data.DataColumn colFeatures;
        private System.Data.DataColumn colSpecifications;
        private System.Data.DataColumn colItemCode;
        private System.Data.DataColumn colItemName;
        private System.Data.DataTable dtUnit;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataTable dtCategory_item;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataTable dtItem;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltransaction_detail_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltransaction_master_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn colitem_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colitem_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn colitem_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcprice;
        private System.Windows.Forms.DataGridViewComboBoxColumn colcategory_item_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn colunit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcfeatures;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcspecifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbctotal_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcpercent_charges;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbctotal_charges;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbctotal_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcdescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbccreated_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbccreate_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcupdate_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcupdate_user;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
    }
}