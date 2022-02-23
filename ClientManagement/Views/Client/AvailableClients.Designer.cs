
namespace ClientManagement.Views.Client
{
    partial class frmAvailableClients
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
            this.bDownload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cExtractTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientDetails = new System.Windows.Forms.DataGridView();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // bDownload
            // 
            this.bDownload.Location = new System.Drawing.Point(588, 14);
            this.bDownload.Name = "bDownload";
            this.bDownload.Size = new System.Drawing.Size(66, 23);
            this.bDownload.TabIndex = 3;
            this.bDownload.Text = "Download";
            this.bDownload.UseVisualStyleBackColor = true;
            this.bDownload.Click += new System.EventHandler(this.bDownload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cExtractTypes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvClientDetails);
            this.groupBox1.Controls.Add(this.bDownload);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 416);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Clients";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cExtractTypes
            // 
            this.cExtractTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cExtractTypes.FormattingEnabled = true;
            this.cExtractTypes.Items.AddRange(new object[] {
            "Client + Address",
            "Addresses",
            "Contacts",
            "Emails"});
            this.cExtractTypes.Location = new System.Drawing.Point(459, 16);
            this.cExtractTypes.Name = "cExtractTypes";
            this.cExtractTypes.Size = new System.Drawing.Size(123, 21);
            this.cExtractTypes.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Extract:";
            // 
            // dgvClientDetails
            // 
            this.dgvClientDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClientDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.ClientFullName,
            this.Address,
            this.Edit});
            this.dgvClientDetails.EnableHeadersVisualStyles = false;
            this.dgvClientDetails.Location = new System.Drawing.Point(15, 48);
            this.dgvClientDetails.Name = "dgvClientDetails";
            this.dgvClientDetails.ReadOnly = true;
            this.dgvClientDetails.RowHeadersVisible = false;
            this.dgvClientDetails.ShowEditingIcon = false;
            this.dgvClientDetails.Size = new System.Drawing.Size(639, 362);
            this.dgvClientDetails.TabIndex = 23;
            this.dgvClientDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientDetails_CellClick);
            // 
            // ClientId
            // 
            this.ClientId.HeaderText = "ClientId";
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            this.ClientId.Visible = false;
            // 
            // ClientFullName
            // 
            this.ClientFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClientFullName.FillWeight = 60F;
            this.ClientFullName.HeaderText = "Client Full Name";
            this.ClientFullName.Name = "ClientFullName";
            this.ClientFullName.ReadOnly = true;
            this.ClientFullName.Width = 170;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Address.DefaultCellStyle = dataGridViewCellStyle1;
            this.Address.FillWeight = 135F;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 381;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.NullValue = "Edit";
            this.Edit.DefaultCellStyle = dataGridViewCellStyle2;
            this.Edit.FillWeight = 30F;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            // 
            // frmAvailableClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 437);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAvailableClients";
            this.Text = "View";
            this.Load += new System.EventHandler(this.frmAvailableClients_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bDownload;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvClientDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cExtractTypes;
    }
}