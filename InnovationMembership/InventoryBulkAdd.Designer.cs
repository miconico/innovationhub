namespace InnovationMembership
{
    partial class InventoryBulkAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryBulkAdd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectFile = new System.Windows.Forms.Button();
            this.addData = new System.Windows.Forms.Button();
            this.fileLocation = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.fileDlg = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectFile);
            this.groupBox1.Controls.Add(this.addData);
            this.groupBox1.Controls.Add(this.fileLocation);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.back);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Details";
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(288, 19);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(45, 27);
            this.selectFile.TabIndex = 25;
            this.selectFile.Text = "...";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // addData
            // 
            this.addData.Location = new System.Drawing.Point(339, 19);
            this.addData.Name = "addData";
            this.addData.Size = new System.Drawing.Size(133, 27);
            this.addData.TabIndex = 24;
            this.addData.Text = "Bulk Add Items";
            this.addData.UseVisualStyleBackColor = true;
            this.addData.Click += new System.EventHandler(this.addData_Click);
            // 
            // fileLocation
            // 
            this.fileLocation.Location = new System.Drawing.Point(94, 23);
            this.fileLocation.MaxLength = 150;
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(188, 20);
            this.fileLocation.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "File Location:";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(478, 19);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(45, 28);
            this.back.TabIndex = 21;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // fileDlg
            // 
            this.fileDlg.DefaultExt = "csv";
            this.fileDlg.Filter = "csv files|*.csv";
            // 
            // BulkAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(556, 89);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BulkAddInventory";
            this.Text = "Bulk Add Inventory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.OpenFileDialog fileDlg;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.Button addData;
        private System.Windows.Forms.TextBox fileLocation;
        private System.Windows.Forms.Label label20;
    }
}