namespace InnovationMembership
{
    partial class InventoryAdd
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryAdd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quantity = new System.Windows.Forms.MaskedTextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboLocationSearch = new System.Windows.Forms.ComboBox();
            this.cboSearchTypes = new System.Windows.Forms.ComboBox();
            this.innovationHubDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.innovationHubDataSet = new InnovationMembership.InnovationHubDataSet();
            this.update = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.cboConsumable = new System.Windows.Forms.ComboBox();
            this.create = new System.Windows.Forms.Button();
            this.purchaseCost = new System.Windows.Forms.MaskedTextBox();
            this.saleValue = new System.Windows.Forms.MaskedTextBox();
            this.cboInStock = new System.Windows.Forms.ComboBox();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.cboTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.received = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileDlg = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgInventory = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.innovationHubDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.innovationHubDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quantity);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cboConsumable);
            this.groupBox1.Controls.Add(this.create);
            this.groupBox1.Controls.Add(this.purchaseCost);
            this.groupBox1.Controls.Add(this.saleValue);
            this.groupBox1.Controls.Add(this.cboInStock);
            this.groupBox1.Controls.Add(this.cboLocation);
            this.groupBox1.Controls.Add(this.cboTypes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.received);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 451);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Details";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(97, 145);
            this.quantity.Mask = "99999";
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(121, 20);
            this.quantity.TabIndex = 41;
            this.quantity.Text = "00001";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(97, 119);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 20);
            this.name.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Item Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cboLocationSearch);
            this.groupBox3.Controls.Add(this.cboSearchTypes);
            this.groupBox3.Controls.Add(this.update);
            this.groupBox3.Controls.Add(this.search);
            this.groupBox3.Location = new System.Drawing.Point(9, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 91);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // cboLocationSearch
            // 
            this.cboLocationSearch.FormattingEnabled = true;
            this.cboLocationSearch.Items.AddRange(new object[] {
            "Maker Zone",
            "HotDesk Zone",
            "Training Zone"});
            this.cboLocationSearch.Location = new System.Drawing.Point(98, 46);
            this.cboLocationSearch.Name = "cboLocationSearch";
            this.cboLocationSearch.Size = new System.Drawing.Size(121, 21);
            this.cboLocationSearch.TabIndex = 39;
            this.cboLocationSearch.Text = "All";
            // 
            // cboSearchTypes
            // 
            this.cboSearchTypes.DataSource = this.innovationHubDataSetBindingSource;
            this.cboSearchTypes.FormattingEnabled = true;
            this.cboSearchTypes.Location = new System.Drawing.Point(99, 17);
            this.cboSearchTypes.Name = "cboSearchTypes";
            this.cboSearchTypes.Size = new System.Drawing.Size(119, 21);
            this.cboSearchTypes.TabIndex = 33;
            // 
            // innovationHubDataSetBindingSource
            // 
            this.innovationHubDataSetBindingSource.DataSource = this.innovationHubDataSet;
            this.innovationHubDataSetBindingSource.Position = 0;
            // 
            // innovationHubDataSet
            // 
            this.innovationHubDataSet.DataSetName = "InnovationHubDataSet";
            this.innovationHubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(6, 46);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(86, 25);
            this.update.TabIndex = 27;
            this.update.Text = "&Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(7, 17);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(86, 23);
            this.search.TabIndex = 28;
            this.search.Text = "&Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click_1);
            // 
            // cboConsumable
            // 
            this.cboConsumable.FormattingEnabled = true;
            this.cboConsumable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboConsumable.Location = new System.Drawing.Point(97, 276);
            this.cboConsumable.Name = "cboConsumable";
            this.cboConsumable.Size = new System.Drawing.Size(121, 21);
            this.cboConsumable.TabIndex = 37;
            this.cboConsumable.Text = "No";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(97, 303);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(121, 20);
            this.create.TabIndex = 22;
            this.create.Text = "Add Item";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // purchaseCost
            // 
            this.purchaseCost.Location = new System.Drawing.Point(97, 250);
            this.purchaseCost.Mask = "99990.00";
            this.purchaseCost.Name = "purchaseCost";
            this.purchaseCost.Size = new System.Drawing.Size(121, 20);
            this.purchaseCost.TabIndex = 36;
            this.purchaseCost.Text = "0000000";
            this.purchaseCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saleValue
            // 
            this.saleValue.Location = new System.Drawing.Point(97, 224);
            this.saleValue.Mask = "99990.00";
            this.saleValue.Name = "saleValue";
            this.saleValue.Size = new System.Drawing.Size(121, 20);
            this.saleValue.TabIndex = 35;
            this.saleValue.Text = "0000000";
            this.saleValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboInStock
            // 
            this.cboInStock.FormattingEnabled = true;
            this.cboInStock.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboInStock.Location = new System.Drawing.Point(97, 170);
            this.cboInStock.Name = "cboInStock";
            this.cboInStock.Size = new System.Drawing.Size(121, 21);
            this.cboInStock.TabIndex = 34;
            this.cboInStock.Text = "Yes";
            // 
            // cboLocation
            // 
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Items.AddRange(new object[] {
            "Maker Zone",
            "HotDesk Zone",
            "Training Zone"});
            this.cboLocation.Location = new System.Drawing.Point(97, 47);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(121, 21);
            this.cboLocation.TabIndex = 33;
            this.cboLocation.Text = "Maker Zone";
            // 
            // cboTypes
            // 
            this.cboTypes.DataSource = this.innovationHubDataSetBindingSource;
            this.cboTypes.FormattingEnabled = true;
            this.cboTypes.Location = new System.Drawing.Point(97, 19);
            this.cboTypes.Name = "cboTypes";
            this.cboTypes.Size = new System.Drawing.Size(121, 21);
            this.cboTypes.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Consumable:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Sale Value:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Purchase Cost:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Received";
            // 
            // received
            // 
            this.received.CustomFormat = "yyyy-MM-dd hh:mm";
            this.received.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.received.Location = new System.Drawing.Point(97, 198);
            this.received.Name = "received";
            this.received.Size = new System.Drawing.Size(121, 20);
            this.received.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "In Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Item Quantity:";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(97, 74);
            this.description.MaxLength = 150;
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(121, 39);
            this.description.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Type:";
            // 
            // fileDlg
            // 
            this.fileDlg.DefaultExt = "csv";
            this.fileDlg.Filter = "csv files|*.csv";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgInventory);
            this.groupBox2.Location = new System.Drawing.Point(257, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 451);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgInventory
            // 
            this.dgInventory.AllowUserToDeleteRows = false;
            this.dgInventory.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgInventory.Location = new System.Drawing.Point(9, 19);
            this.dgInventory.Name = "dgInventory";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgInventory.Size = new System.Drawing.Size(724, 422);
            this.dgInventory.TabIndex = 25;
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddInventory";
            this.Text = "Add Inventory";
            this.Load += new System.EventHandler(this.AddInventory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.innovationHubDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.innovationHubDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker received;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog fileDlg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTypes;
        private System.Windows.Forms.BindingSource innovationHubDataSetBindingSource;
        private InnovationHubDataSet innovationHubDataSet;
        private System.Windows.Forms.ComboBox cboLocation;
        private System.Windows.Forms.ComboBox cboInStock;
        private System.Windows.Forms.MaskedTextBox purchaseCost;
        private System.Windows.Forms.MaskedTextBox saleValue;
        private System.Windows.Forms.ComboBox cboConsumable;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgInventory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox cboLocationSearch;
        private System.Windows.Forms.ComboBox cboSearchTypes;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox quantity;
    }
}