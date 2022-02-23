
namespace ClientManagement.Views.Client
{
    partial class frmCreateUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tFirstName = new System.Windows.Forms.TextBox();
            this.tLastName = new System.Windows.Forms.TextBox();
            this.tIDNumber = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.cGender = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cTitle = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAddress = new System.Windows.Forms.DataGridView();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suburb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAddress = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bContact = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Identity Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Title:";
            // 
            // tFirstName
            // 
            this.tFirstName.Location = new System.Drawing.Point(105, 48);
            this.tFirstName.Name = "tFirstName";
            this.tFirstName.Size = new System.Drawing.Size(145, 20);
            this.tFirstName.TabIndex = 9;
            // 
            // tLastName
            // 
            this.tLastName.Location = new System.Drawing.Point(105, 76);
            this.tLastName.Name = "tLastName";
            this.tLastName.Size = new System.Drawing.Size(145, 20);
            this.tLastName.TabIndex = 10;
            // 
            // tIDNumber
            // 
            this.tIDNumber.Location = new System.Drawing.Point(105, 102);
            this.tIDNumber.Name = "tIDNumber";
            this.tIDNumber.Size = new System.Drawing.Size(145, 20);
            this.tIDNumber.TabIndex = 11;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(105, 155);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(145, 20);
            this.tEmail.TabIndex = 15;
            // 
            // cGender
            // 
            this.cGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cGender.FormattingEnabled = true;
            this.cGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unknown"});
            this.cGender.Location = new System.Drawing.Point(105, 128);
            this.cGender.Name = "cGender";
            this.cGender.Size = new System.Drawing.Size(145, 21);
            this.cGender.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cTitle);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cGender);
            this.groupBox1.Controls.Add(this.tEmail);
            this.groupBox1.Controls.Add(this.tIDNumber);
            this.groupBox1.Controls.Add(this.tLastName);
            this.groupBox1.Controls.Add(this.tFirstName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 379);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Details";
            // 
            // cTitle
            // 
            this.cTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cTitle.FormattingEnabled = true;
            this.cTitle.Items.AddRange(new object[] {
            "Prof",
            "Dr",
            "Mr",
            "Mrs",
            "Miss "});
            this.cTitle.Location = new System.Drawing.Point(105, 19);
            this.cTitle.Name = "cTitle";
            this.cTitle.Size = new System.Drawing.Size(145, 21);
            this.cTitle.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvAddress);
            this.groupBox3.Controls.Add(this.bAddress);
            this.groupBox3.Location = new System.Drawing.Point(18, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(639, 172);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Addres Details";
            // 
            // dgvAddress
            // 
            this.dgvAddress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address,
            this.Suburb,
            this.Province,
            this.Code,
            this.AddressID});
            this.dgvAddress.EnableHeadersVisualStyles = false;
            this.dgvAddress.Location = new System.Drawing.Point(6, 56);
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            this.dgvAddress.RowHeadersVisible = false;
            this.dgvAddress.ShowEditingIcon = false;
            this.dgvAddress.Size = new System.Drawing.Size(621, 96);
            this.dgvAddress.TabIndex = 23;
            this.dgvAddress.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddress_CellClick);
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Suburb
            // 
            this.Suburb.HeaderText = "Suburb";
            this.Suburb.Name = "Suburb";
            this.Suburb.ReadOnly = true;
            // 
            // Province
            // 
            this.Province.HeaderText = "Province";
            this.Province.Name = "Province";
            this.Province.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // AddressID
            // 
            this.AddressID.HeaderText = "AddressID";
            this.AddressID.Name = "AddressID";
            this.AddressID.ReadOnly = true;
            this.AddressID.Visible = false;
            // 
            // bAddress
            // 
            this.bAddress.Location = new System.Drawing.Point(6, 22);
            this.bAddress.Name = "bAddress";
            this.bAddress.Size = new System.Drawing.Size(622, 28);
            this.bAddress.TabIndex = 21;
            this.bAddress.Text = "Add Address";
            this.bAddress.UseVisualStyleBackColor = true;
            this.bAddress.Click += new System.EventHandler(this.bAddress_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvContact);
            this.groupBox2.Controls.Add(this.bContact);
            this.groupBox2.Location = new System.Drawing.Point(273, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 167);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Numbers";
            // 
            // dgvContact
            // 
            this.dgvContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Number,
            this.ContactId});
            this.dgvContact.EnableHeadersVisualStyles = false;
            this.dgvContact.Location = new System.Drawing.Point(8, 59);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.ReadOnly = true;
            this.dgvContact.RowHeadersVisible = false;
            this.dgvContact.ShowEditingIcon = false;
            this.dgvContact.Size = new System.Drawing.Size(364, 96);
            this.dgvContact.TabIndex = 22;
            this.dgvContact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContact_CellClick);
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // ContactId
            // 
            this.ContactId.HeaderText = "ContactId";
            this.ContactId.Name = "ContactId";
            this.ContactId.ReadOnly = true;
            this.ContactId.Visible = false;
            // 
            // bContact
            // 
            this.bContact.Location = new System.Drawing.Point(6, 22);
            this.bContact.Name = "bContact";
            this.bContact.Size = new System.Drawing.Size(143, 28);
            this.bContact.TabIndex = 21;
            this.bContact.Text = "Add Contact Number";
            this.bContact.UseVisualStyleBackColor = true;
            this.bContact.Click += new System.EventHandler(this.bContact_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(293, 397);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 18;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // frmCreateUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 437);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Create";
            this.Load += new System.EventHandler(this.frmCreateUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tFirstName;
        private System.Windows.Forms.TextBox tLastName;
        private System.Windows.Forms.TextBox tIDNumber;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.ComboBox cGender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bContact;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ComboBox cTitle;
        public System.Windows.Forms.DataGridView dgvContact;
        public System.Windows.Forms.DataGridView dgvAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suburb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Province;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactId;
    }
}