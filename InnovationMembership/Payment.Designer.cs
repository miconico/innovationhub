﻿namespace InnovationMembership
{
    partial class Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.MaskedTextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.memberId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgMembers = new System.Windows.Forms.DataGridView();
            this.memberName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.saleValue = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboLocationSearch = new System.Windows.Forms.ComboBox();
            this.request = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.makerSpace = new System.Windows.Forms.TabPage();
            this.innovationHub = new System.Windows.Forms.TabPage();
            this.onceOffItems = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.quantity);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Purchase Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Item Type:";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(97, 75);
            this.quantity.Mask = "99999";
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(121, 20);
            this.quantity.TabIndex = 41;
            this.quantity.Text = "00001";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(97, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 20);
            this.name.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Item Desc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Item Quantity:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.memberId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.mobile);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgMembers);
            this.groupBox2.Controls.Add(this.memberName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 135);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Member Details";
            // 
            // memberId
            // 
            this.memberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberId.Location = new System.Drawing.Point(76, 99);
            this.memberId.MaxLength = 50;
            this.memberId.Name = "memberId";
            this.memberId.ReadOnly = true;
            this.memberId.Size = new System.Drawing.Size(110, 22);
            this.memberId.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "MemberId";
            // 
            // mobile
            // 
            this.mobile.Location = new System.Drawing.Point(76, 71);
            this.mobile.MaxLength = 50;
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(110, 20);
            this.mobile.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Mobile:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(76, 45);
            this.email.MaxLength = 150;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(110, 20);
            this.email.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Email:";
            // 
            // dgMembers
            // 
            this.dgMembers.AllowUserToAddRows = false;
            this.dgMembers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMembers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgMembers.Location = new System.Drawing.Point(261, 19);
            this.dgMembers.Name = "dgMembers";
            this.dgMembers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgMembers.Size = new System.Drawing.Size(341, 101);
            this.dgMembers.TabIndex = 49;
            this.dgMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMembers_CellContentClick);
            this.dgMembers.SelectionChanged += new System.EventHandler(this.dgMembers_SelectionChanged);
            // 
            // memberName
            // 
            this.memberName.AccessibleDescription = " ";
            this.memberName.Location = new System.Drawing.Point(76, 19);
            this.memberName.MaxLength = 100;
            this.memberName.Name = "memberName";
            this.memberName.Size = new System.Drawing.Size(110, 20);
            this.memberName.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Name:";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(192, 17);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(63, 22);
            this.search.TabIndex = 34;
            this.search.Text = "&Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.saleValue);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cboLocationSearch);
            this.groupBox3.Controls.Add(this.request);
            this.groupBox3.Location = new System.Drawing.Point(12, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 136);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Payment Type:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Pay Online",
            "Sepa Payment"});
            this.comboBox2.Location = new System.Drawing.Point(107, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 48;
            this.comboBox2.Text = "All";
            // 
            // saleValue
            // 
            this.saleValue.Location = new System.Drawing.Point(107, 71);
            this.saleValue.Mask = "99990.00";
            this.saleValue.Name = "saleValue";
            this.saleValue.Size = new System.Drawing.Size(100, 20);
            this.saleValue.TabIndex = 47;
            this.saleValue.Text = "0000000";
            this.saleValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Payment To:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Invoice Amount:";
            // 
            // cboLocationSearch
            // 
            this.cboLocationSearch.FormattingEnabled = true;
            this.cboLocationSearch.Items.AddRange(new object[] {
            "Maker Zone",
            "HotDesk Zone",
            "Training Zone",
            "Enterprise Center"});
            this.cboLocationSearch.Location = new System.Drawing.Point(107, 17);
            this.cboLocationSearch.Name = "cboLocationSearch";
            this.cboLocationSearch.Size = new System.Drawing.Size(100, 21);
            this.cboLocationSearch.TabIndex = 39;
            this.cboLocationSearch.Text = "All";
            // 
            // request
            // 
            this.request.Location = new System.Drawing.Point(107, 97);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(100, 26);
            this.request.TabIndex = 27;
            this.request.Text = "&Request";
            this.request.UseVisualStyleBackColor = true;
            this.request.Click += new System.EventHandler(this.request_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.makerSpace);
            this.tabControl1.Controls.Add(this.innovationHub);
            this.tabControl1.Controls.Add(this.onceOffItems);
            this.tabControl1.Location = new System.Drawing.Point(234, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(368, 101);
            this.tabControl1.TabIndex = 46;
            // 
            // makerSpace
            // 
            this.makerSpace.Location = new System.Drawing.Point(4, 22);
            this.makerSpace.Name = "makerSpace";
            this.makerSpace.Padding = new System.Windows.Forms.Padding(3);
            this.makerSpace.Size = new System.Drawing.Size(360, 75);
            this.makerSpace.TabIndex = 0;
            this.makerSpace.Text = "MakerSpace";
            this.makerSpace.UseVisualStyleBackColor = true;
            // 
            // innovationHub
            // 
            this.innovationHub.Location = new System.Drawing.Point(4, 22);
            this.innovationHub.Name = "innovationHub";
            this.innovationHub.Padding = new System.Windows.Forms.Padding(3);
            this.innovationHub.Size = new System.Drawing.Size(360, 75);
            this.innovationHub.TabIndex = 1;
            this.innovationHub.Text = "Innovation Hub";
            this.innovationHub.UseVisualStyleBackColor = true;
            // 
            // onceOffItems
            // 
            this.onceOffItems.Location = new System.Drawing.Point(4, 22);
            this.onceOffItems.Name = "onceOffItems";
            this.onceOffItems.Size = new System.Drawing.Size(360, 75);
            this.onceOffItems.TabIndex = 2;
            this.onceOffItems.Text = "Once Off Items";
            this.onceOffItems.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 434);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Payment";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox quantity;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboLocationSearch;
        private System.Windows.Forms.Button request;
        private System.Windows.Forms.TextBox memberName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgMembers;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memberId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MaskedTextBox saleValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage makerSpace;
        private System.Windows.Forms.TabPage innovationHub;
        private System.Windows.Forms.TabPage onceOffItems;
    }
}