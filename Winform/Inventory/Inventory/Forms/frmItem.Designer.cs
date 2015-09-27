namespace Inventory
{
    partial class frmItem
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewItem = new System.Windows.Forms.TreeView();
            this.panRight = new System.Windows.Forms.Panel();
            this.txtItem_code = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.txtFeatures = new System.Windows.Forms.TextBox();
            this.txtItem_name = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtSpecifications = new System.Windows.Forms.TextBox();
            this.lblSpecifications = new System.Windows.Forms.Label();
            this.pictBarcode = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewItem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panRight);
            this.splitContainer1.Size = new System.Drawing.Size(1046, 582);
            this.splitContainer1.SplitterDistance = 348;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewItem
            // 
            this.treeViewItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewItem.Location = new System.Drawing.Point(0, 0);
            this.treeViewItem.Name = "treeViewItem";
            this.treeViewItem.Size = new System.Drawing.Size(348, 582);
            this.treeViewItem.TabIndex = 0;
            // 
            // panRight
            // 
            this.panRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panRight.Controls.Add(this.btnPrint);
            this.panRight.Controls.Add(this.pictBarcode);
            this.panRight.Controls.Add(this.txtItem_name);
            this.panRight.Controls.Add(this.lblItemName);
            this.panRight.Controls.Add(this.lblSpecifications);
            this.panRight.Controls.Add(this.lblFeatures);
            this.panRight.Controls.Add(this.txtSpecifications);
            this.panRight.Controls.Add(this.txtFeatures);
            this.panRight.Controls.Add(this.txtItem_code);
            this.panRight.Controls.Add(this.lblItemCode);
            this.panRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panRight.Location = new System.Drawing.Point(0, 0);
            this.panRight.Name = "panRight";
            this.panRight.Size = new System.Drawing.Size(694, 582);
            this.panRight.TabIndex = 0;
            // 
            // txtItem_code
            // 
            this.txtItem_code.Location = new System.Drawing.Point(94, 12);
            this.txtItem_code.Name = "txtItem_code";
            this.txtItem_code.Size = new System.Drawing.Size(528, 20);
            this.txtItem_code.TabIndex = 3;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(17, 15);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(55, 13);
            this.lblItemCode.TabIndex = 2;
            this.lblItemCode.Text = "Item Code";
            // 
            // lblFeatures
            // 
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.Location = new System.Drawing.Point(17, 61);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(48, 13);
            this.lblFeatures.TabIndex = 22;
            this.lblFeatures.Text = "Features";
            // 
            // txtFeatures
            // 
            this.txtFeatures.Location = new System.Drawing.Point(94, 58);
            this.txtFeatures.Multiline = true;
            this.txtFeatures.Name = "txtFeatures";
            this.txtFeatures.Size = new System.Drawing.Size(528, 64);
            this.txtFeatures.TabIndex = 21;
            // 
            // txtItem_name
            // 
            this.txtItem_name.Location = new System.Drawing.Point(94, 35);
            this.txtItem_name.Name = "txtItem_name";
            this.txtItem_name.Size = new System.Drawing.Size(528, 20);
            this.txtItem_name.TabIndex = 24;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(17, 38);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 23;
            this.lblItemName.Text = "Item Name";
            // 
            // txtSpecifications
            // 
            this.txtSpecifications.Location = new System.Drawing.Point(94, 126);
            this.txtSpecifications.Multiline = true;
            this.txtSpecifications.Name = "txtSpecifications";
            this.txtSpecifications.Size = new System.Drawing.Size(528, 64);
            this.txtSpecifications.TabIndex = 21;
            // 
            // lblSpecifications
            // 
            this.lblSpecifications.AutoSize = true;
            this.lblSpecifications.Location = new System.Drawing.Point(17, 126);
            this.lblSpecifications.Name = "lblSpecifications";
            this.lblSpecifications.Size = new System.Drawing.Size(73, 13);
            this.lblSpecifications.TabIndex = 22;
            this.lblSpecifications.Text = "Specifications";
            // 
            // pictBarcode
            // 
            this.pictBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBarcode.Location = new System.Drawing.Point(94, 196);
            this.pictBarcode.Name = "pictBarcode";
            this.pictBarcode.Size = new System.Drawing.Size(528, 84);
            this.pictBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBarcode.TabIndex = 25;
            this.pictBarcode.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(94, 286);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 26;
            this.btnPrint.Text = "Print";
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1046, 582);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmItem";
            this.Text = "frmItem";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panRight.ResumeLayout(false);
            this.panRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBarcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewItem;
        private System.Windows.Forms.Panel panRight;
        private System.Windows.Forms.TextBox txtItem_code;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.TextBox txtItem_name;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblFeatures;
        private System.Windows.Forms.TextBox txtFeatures;
        private System.Windows.Forms.Label lblSpecifications;
        private System.Windows.Forms.TextBox txtSpecifications;
        private System.Windows.Forms.PictureBox pictBarcode;
        private System.Windows.Forms.Button btnPrint;
    }
}