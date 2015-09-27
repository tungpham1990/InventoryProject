namespace Inventory
{
    partial class frmImSearch
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
            this.dtpTransaction_todate = new System.Windows.Forms.DateTimePicker();
            this.lblTransaction_todate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpTransaction_fromdate = new System.Windows.Forms.DateTimePicker();
            this.lblTransaction_fromdate = new System.Windows.Forms.Label();
            this.txtTransaction_code = new System.Windows.Forms.TextBox();
            this.lblTransaction_code = new System.Windows.Forms.Label();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.grdView = new System.Windows.Forms.DataGridView();
            this.dtSet = new System.Data.DataSet();
            this.dtTransaction_master = new System.Data.DataTable();
            this.coltransaction_master_id = new System.Data.DataColumn();
            this.coltransaction_code = new System.Data.DataColumn();
            this.coltransaction_type_id = new System.Data.DataColumn();
            this.coltransaction_type_code = new System.Data.DataColumn();
            this.coltransaction_date = new System.Data.DataColumn();
            this.colreceived_warehouse_id = new System.Data.DataColumn();
            this.colreceived_warehouse_code = new System.Data.DataColumn();
            this.colreceived_warehouse_name = new System.Data.DataColumn();
            this.coldelivered_warehouse_id = new System.Data.DataColumn();
            this.coldelivered_warehouse_code = new System.Data.DataColumn();
            this.coldelivered_warehouse_name = new System.Data.DataColumn();
            this.colreceiver = new System.Data.DataColumn();
            this.coldeliver = new System.Data.DataColumn();
            this.colcustomer_id = new System.Data.DataColumn();
            this.colcustomer_code = new System.Data.DataColumn();
            this.colcustomer_name = new System.Data.DataColumn();
            this.coldescription = new System.Data.DataColumn();
            this.colcreated_date = new System.Data.DataColumn();
            this.colcreate_user = new System.Data.DataColumn();
            this.colsupplier_id = new System.Data.DataColumn();
            this.colsupplier_code = new System.Data.DataColumn();
            this.colsupplier_name = new System.Data.DataColumn();
            this.transactionmasteridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactioncodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactiontypecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedwarehousecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedwarehousenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMaster.SuspendLayout();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTransaction_master)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMaster
            // 
            this.panelMaster.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMaster.Controls.Add(this.dtpTransaction_todate);
            this.panelMaster.Controls.Add(this.lblTransaction_todate);
            this.panelMaster.Controls.Add(this.btnSearch);
            this.panelMaster.Controls.Add(this.dtpTransaction_fromdate);
            this.panelMaster.Controls.Add(this.lblTransaction_fromdate);
            this.panelMaster.Controls.Add(this.txtTransaction_code);
            this.panelMaster.Controls.Add(this.lblTransaction_code);
            this.panelMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaster.Location = new System.Drawing.Point(0, 0);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(1129, 38);
            this.panelMaster.TabIndex = 2;
            // 
            // dtpTransaction_todate
            // 
            this.dtpTransaction_todate.Location = new System.Drawing.Point(790, 8);
            this.dtpTransaction_todate.Name = "dtpTransaction_todate";
            this.dtpTransaction_todate.Size = new System.Drawing.Size(200, 20);
            this.dtpTransaction_todate.TabIndex = 18;
            // 
            // lblTransaction_todate
            // 
            this.lblTransaction_todate.AutoSize = true;
            this.lblTransaction_todate.Location = new System.Drawing.Point(673, 13);
            this.lblTransaction_todate.Name = "lblTransaction_todate";
            this.lblTransaction_todate.Size = new System.Drawing.Size(102, 13);
            this.lblTransaction_todate.TabIndex = 17;
            this.lblTransaction_todate.Text = "Transaction ToDate";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1006, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpTransaction_fromdate
            // 
            this.dtpTransaction_fromdate.Location = new System.Drawing.Point(458, 8);
            this.dtpTransaction_fromdate.Name = "dtpTransaction_fromdate";
            this.dtpTransaction_fromdate.Size = new System.Drawing.Size(200, 20);
            this.dtpTransaction_fromdate.TabIndex = 3;
            // 
            // lblTransaction_fromdate
            // 
            this.lblTransaction_fromdate.AutoSize = true;
            this.lblTransaction_fromdate.Location = new System.Drawing.Point(341, 11);
            this.lblTransaction_fromdate.Name = "lblTransaction_fromdate";
            this.lblTransaction_fromdate.Size = new System.Drawing.Size(112, 13);
            this.lblTransaction_fromdate.TabIndex = 2;
            this.lblTransaction_fromdate.Text = "Transaction FromDate";
            // 
            // txtTransaction_code
            // 
            this.txtTransaction_code.Location = new System.Drawing.Point(131, 5);
            this.txtTransaction_code.Name = "txtTransaction_code";
            this.txtTransaction_code.Size = new System.Drawing.Size(200, 20);
            this.txtTransaction_code.TabIndex = 1;
            // 
            // lblTransaction_code
            // 
            this.lblTransaction_code.AutoSize = true;
            this.lblTransaction_code.Location = new System.Drawing.Point(12, 8);
            this.lblTransaction_code.Name = "lblTransaction_code";
            this.lblTransaction_code.Size = new System.Drawing.Size(91, 13);
            this.lblTransaction_code.TabIndex = 0;
            this.lblTransaction_code.Text = "Transaction Code";
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelDetail.Controls.Add(this.grdView);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 38);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(1129, 544);
            this.panelDetail.TabIndex = 3;
            // 
            // grdView
            // 
            this.grdView.AllowUserToAddRows = false;
            this.grdView.AllowUserToDeleteRows = false;
            this.grdView.AutoGenerateColumns = false;
            this.grdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionmasteridDataGridViewTextBoxColumn,
            this.transactioncodeDataGridViewTextBoxColumn,
            this.transactiondateDataGridViewTextBoxColumn,
            this.transactiontypecodeDataGridViewTextBoxColumn,
            this.supplier_code,
            this.supplier_name,
            this.receivedwarehousecodeDataGridViewTextBoxColumn,
            this.receivedwarehousenameDataGridViewTextBoxColumn,
            this.receiverDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.createddateDataGridViewTextBoxColumn,
            this.createuserDataGridViewTextBoxColumn});
            this.grdView.DataMember = "transaction_master";
            this.grdView.DataSource = this.dtSet;
            this.grdView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdView.Location = new System.Drawing.Point(0, 0);
            this.grdView.Name = "grdView";
            this.grdView.ReadOnly = true;
            this.grdView.Size = new System.Drawing.Size(1129, 544);
            this.grdView.TabIndex = 1;
            // 
            // dtSet
            // 
            this.dtSet.DataSetName = "NewDataSet";
            this.dtSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dtTransaction_master});
            // 
            // dtTransaction_master
            // 
            this.dtTransaction_master.Columns.AddRange(new System.Data.DataColumn[] {
            this.coltransaction_master_id,
            this.coltransaction_code,
            this.coltransaction_type_id,
            this.coltransaction_type_code,
            this.coltransaction_date,
            this.colreceived_warehouse_id,
            this.colreceived_warehouse_code,
            this.colreceived_warehouse_name,
            this.coldelivered_warehouse_id,
            this.coldelivered_warehouse_code,
            this.coldelivered_warehouse_name,
            this.colreceiver,
            this.coldeliver,
            this.colcustomer_id,
            this.colcustomer_code,
            this.colcustomer_name,
            this.coldescription,
            this.colcreated_date,
            this.colcreate_user,
            this.colsupplier_id,
            this.colsupplier_code,
            this.colsupplier_name});
            this.dtTransaction_master.TableName = "Transaction_master";
            // 
            // coltransaction_master_id
            // 
            this.coltransaction_master_id.ColumnName = "transaction_master_id";
            this.coltransaction_master_id.DataType = typeof(long);
            // 
            // coltransaction_code
            // 
            this.coltransaction_code.ColumnName = "transaction_code";
            // 
            // coltransaction_type_id
            // 
            this.coltransaction_type_id.ColumnName = "transaction_type_id";
            this.coltransaction_type_id.DataType = typeof(long);
            // 
            // coltransaction_type_code
            // 
            this.coltransaction_type_code.ColumnName = "transaction_type_code";
            // 
            // coltransaction_date
            // 
            this.coltransaction_date.ColumnName = "transaction_date";
            this.coltransaction_date.DataType = typeof(System.DateTime);
            // 
            // colreceived_warehouse_id
            // 
            this.colreceived_warehouse_id.ColumnName = "received_warehouse_id";
            this.colreceived_warehouse_id.DataType = typeof(long);
            // 
            // colreceived_warehouse_code
            // 
            this.colreceived_warehouse_code.ColumnName = "received_warehouse_code";
            // 
            // colreceived_warehouse_name
            // 
            this.colreceived_warehouse_name.ColumnName = "received_warehouse_name";
            // 
            // coldelivered_warehouse_id
            // 
            this.coldelivered_warehouse_id.ColumnName = "delivered_warehouse_id";
            this.coldelivered_warehouse_id.DataType = typeof(long);
            // 
            // coldelivered_warehouse_code
            // 
            this.coldelivered_warehouse_code.ColumnName = "delivered_warehouse_code";
            // 
            // coldelivered_warehouse_name
            // 
            this.coldelivered_warehouse_name.ColumnName = "delivered_warehouse_name";
            // 
            // colreceiver
            // 
            this.colreceiver.ColumnName = "receiver";
            // 
            // coldeliver
            // 
            this.coldeliver.ColumnName = "deliver";
            // 
            // colcustomer_id
            // 
            this.colcustomer_id.ColumnName = "customer_id";
            this.colcustomer_id.DataType = typeof(long);
            // 
            // colcustomer_code
            // 
            this.colcustomer_code.ColumnName = "customer_code";
            // 
            // colcustomer_name
            // 
            this.colcustomer_name.ColumnName = "customer_name";
            // 
            // coldescription
            // 
            this.coldescription.ColumnName = "description";
            // 
            // colcreated_date
            // 
            this.colcreated_date.ColumnName = "created_date";
            this.colcreated_date.DataType = typeof(System.DateTime);
            // 
            // colcreate_user
            // 
            this.colcreate_user.ColumnName = "create_user";
            // 
            // colsupplier_id
            // 
            this.colsupplier_id.ColumnName = "supplier_id";
            this.colsupplier_id.DataType = typeof(long);
            // 
            // colsupplier_code
            // 
            this.colsupplier_code.ColumnName = "supplier_code";
            // 
            // colsupplier_name
            // 
            this.colsupplier_name.ColumnName = "supplier_name";
            // 
            // transactionmasteridDataGridViewTextBoxColumn
            // 
            this.transactionmasteridDataGridViewTextBoxColumn.DataPropertyName = "transaction_master_id";
            this.transactionmasteridDataGridViewTextBoxColumn.HeaderText = "transaction_master_id";
            this.transactionmasteridDataGridViewTextBoxColumn.Name = "transactionmasteridDataGridViewTextBoxColumn";
            this.transactionmasteridDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionmasteridDataGridViewTextBoxColumn.Visible = false;
            // 
            // transactioncodeDataGridViewTextBoxColumn
            // 
            this.transactioncodeDataGridViewTextBoxColumn.DataPropertyName = "transaction_code";
            this.transactioncodeDataGridViewTextBoxColumn.HeaderText = "transaction_code";
            this.transactioncodeDataGridViewTextBoxColumn.Name = "transactioncodeDataGridViewTextBoxColumn";
            this.transactioncodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactioncodeDataGridViewTextBoxColumn.Width = 120;
            // 
            // transactiondateDataGridViewTextBoxColumn
            // 
            this.transactiondateDataGridViewTextBoxColumn.DataPropertyName = "transaction_date";
            this.transactiondateDataGridViewTextBoxColumn.HeaderText = "transaction_date";
            this.transactiondateDataGridViewTextBoxColumn.Name = "transactiondateDataGridViewTextBoxColumn";
            this.transactiondateDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactiondateDataGridViewTextBoxColumn.Width = 120;
            // 
            // transactiontypecodeDataGridViewTextBoxColumn
            // 
            this.transactiontypecodeDataGridViewTextBoxColumn.DataPropertyName = "transaction_type_code";
            this.transactiontypecodeDataGridViewTextBoxColumn.HeaderText = "transaction_type_code";
            this.transactiontypecodeDataGridViewTextBoxColumn.Name = "transactiontypecodeDataGridViewTextBoxColumn";
            this.transactiontypecodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactiontypecodeDataGridViewTextBoxColumn.Width = 80;
            // 
            // supplier_code
            // 
            this.supplier_code.DataPropertyName = "supplier_code";
            this.supplier_code.HeaderText = "supplier_code";
            this.supplier_code.Name = "supplier_code";
            this.supplier_code.ReadOnly = true;
            // 
            // supplier_name
            // 
            this.supplier_name.DataPropertyName = "supplier_name";
            this.supplier_name.HeaderText = "supplier_name";
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.ReadOnly = true;
            // 
            // receivedwarehousecodeDataGridViewTextBoxColumn
            // 
            this.receivedwarehousecodeDataGridViewTextBoxColumn.DataPropertyName = "received_warehouse_code";
            this.receivedwarehousecodeDataGridViewTextBoxColumn.HeaderText = "received_warehouse_code";
            this.receivedwarehousecodeDataGridViewTextBoxColumn.Name = "receivedwarehousecodeDataGridViewTextBoxColumn";
            this.receivedwarehousecodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.receivedwarehousecodeDataGridViewTextBoxColumn.Width = 140;
            // 
            // receivedwarehousenameDataGridViewTextBoxColumn
            // 
            this.receivedwarehousenameDataGridViewTextBoxColumn.DataPropertyName = "received_warehouse_name";
            this.receivedwarehousenameDataGridViewTextBoxColumn.HeaderText = "received_warehouse_name";
            this.receivedwarehousenameDataGridViewTextBoxColumn.Name = "receivedwarehousenameDataGridViewTextBoxColumn";
            this.receivedwarehousenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.receivedwarehousenameDataGridViewTextBoxColumn.Width = 150;
            // 
            // receiverDataGridViewTextBoxColumn
            // 
            this.receiverDataGridViewTextBoxColumn.DataPropertyName = "receiver";
            this.receiverDataGridViewTextBoxColumn.HeaderText = "receiver";
            this.receiverDataGridViewTextBoxColumn.Name = "receiverDataGridViewTextBoxColumn";
            this.receiverDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiverDataGridViewTextBoxColumn.Width = 80;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // createddateDataGridViewTextBoxColumn
            // 
            this.createddateDataGridViewTextBoxColumn.DataPropertyName = "created_date";
            this.createddateDataGridViewTextBoxColumn.HeaderText = "created_date";
            this.createddateDataGridViewTextBoxColumn.Name = "createddateDataGridViewTextBoxColumn";
            this.createddateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createddateDataGridViewTextBoxColumn.Width = 120;
            // 
            // createuserDataGridViewTextBoxColumn
            // 
            this.createuserDataGridViewTextBoxColumn.DataPropertyName = "create_user";
            this.createuserDataGridViewTextBoxColumn.HeaderText = "create_user";
            this.createuserDataGridViewTextBoxColumn.Name = "createuserDataGridViewTextBoxColumn";
            this.createuserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmImSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 582);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelMaster);
            this.Name = "frmImSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExSearch";
            this.panelMaster.ResumeLayout(false);
            this.panelMaster.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTransaction_master)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMaster;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.DateTimePicker dtpTransaction_fromdate;
        private System.Windows.Forms.Label lblTransaction_fromdate;
        private System.Windows.Forms.TextBox txtTransaction_code;
        private System.Windows.Forms.Label lblTransaction_code;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpTransaction_todate;
        private System.Windows.Forms.Label lblTransaction_todate;
        private System.Windows.Forms.DataGridView grdView;
        private System.Data.DataSet dtSet;
        private System.Data.DataTable dtTransaction_master;
        private System.Data.DataColumn coltransaction_master_id;
        private System.Data.DataColumn coltransaction_code;
        private System.Data.DataColumn coltransaction_type_id;
        private System.Data.DataColumn coltransaction_type_code;
        private System.Data.DataColumn coltransaction_date;
        private System.Data.DataColumn colreceived_warehouse_id;
        private System.Data.DataColumn colreceived_warehouse_code;
        private System.Data.DataColumn colreceived_warehouse_name;
        private System.Data.DataColumn coldelivered_warehouse_id;
        private System.Data.DataColumn coldelivered_warehouse_code;
        private System.Data.DataColumn coldelivered_warehouse_name;
        private System.Data.DataColumn colreceiver;
        private System.Data.DataColumn coldeliver;
        private System.Data.DataColumn colcustomer_id;
        private System.Data.DataColumn colcustomer_code;
        private System.Data.DataColumn colcustomer_name;
        private System.Data.DataColumn coldescription;
        private System.Data.DataColumn colcreated_date;
        private System.Data.DataColumn colcreate_user;
        private System.Data.DataColumn colsupplier_id;
        private System.Data.DataColumn colsupplier_code;
        private System.Data.DataColumn colsupplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionmasteridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactioncodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactiontypecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedwarehousecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedwarehousenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createuserDataGridViewTextBoxColumn;
    }
}