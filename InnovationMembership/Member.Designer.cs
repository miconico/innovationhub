namespace InnovationMembership
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.memberId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.add3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.add2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.add1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.forename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.back = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.memberId);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.age);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.add3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.add2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.add1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mobile);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.surname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.forename);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Member Details";
            // 
            // memberId
            // 
            this.memberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberId.Location = new System.Drawing.Point(70, 193);
            this.memberId.MaxLength = 50;
            this.memberId.Name = "memberId";
            this.memberId.ReadOnly = true;
            this.memberId.Size = new System.Drawing.Size(100, 22);
            this.memberId.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "MemberId";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Adult +18",
            "Junior +16",
            "Child < 16"});
            this.type.Location = new System.Drawing.Point(70, 151);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(110, 21);
            this.type.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Age:";
            // 
            // age
            // 
            this.age.CustomFormat = "MMM-yyyy";
            this.age.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.age.Location = new System.Drawing.Point(70, 125);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(110, 20);
            this.age.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Interest:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "MakePort Membership",
            "MakePort Visit Only",
            "HotDesk Rental OnceOff",
            "HotDesk Rental Recurring",
            "Training Room Rental OnceOff",
            "Training Room Rental Recurring",
            "Innovation Hub Visit Only"});
            this.checkedListBox1.Location = new System.Drawing.Point(258, 100);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(184, 109);
            this.checkedListBox1.TabIndex = 14;
            // 
            // add3
            // 
            this.add3.Location = new System.Drawing.Point(258, 71);
            this.add3.Name = "add3";
            this.add3.Size = new System.Drawing.Size(124, 20);
            this.add3.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address 3:";
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(258, 45);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(124, 20);
            this.add2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address 2:";
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(258, 19);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(124, 20);
            this.add1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address 1:";
            // 
            // mobile
            // 
            this.mobile.Location = new System.Drawing.Point(70, 97);
            this.mobile.MaxLength = 50;
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(110, 20);
            this.mobile.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mobile:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(70, 71);
            this.email.MaxLength = 150;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(110, 20);
            this.email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(70, 45);
            this.surname.MaxLength = 100;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(110, 20);
            this.surname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            // 
            // forename
            // 
            this.forename.Location = new System.Drawing.Point(70, 19);
            this.forename.MaxLength = 100;
            this.forename.Name = "forename";
            this.forename.Size = new System.Drawing.Size(110, 20);
            this.forename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forename:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.back);
            this.groupBox2.Controls.Add(this.create);
            this.groupBox2.Location = new System.Drawing.Point(244, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 56);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(148, 13);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(45, 35);
            this.back.TabIndex = 23;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(9, 13);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(133, 35);
            this.create.TabIndex = 22;
            this.create.Text = "Create Member";
            this.create.UseVisualStyleBackColor = true;
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(477, 289);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakePortMember";
            this.Load += new System.EventHandler(this.MakePortMember_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox forename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox add3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox add2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox add1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DateTimePicker age;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox memberId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button create;
    }
}