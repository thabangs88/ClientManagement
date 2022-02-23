
namespace ClientManagement.Views
{
    partial class frmClientManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bViewAllUsers = new System.Windows.Forms.Button();
            this.bCreateUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bViewAllClients = new System.Windows.Forms.Button();
            this.bSearchClient = new System.Windows.Forms.Button();
            this.bCreateClient = new System.Windows.Forms.Button();
            this.pDisplayView = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 449);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "MANAGER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bViewAllUsers);
            this.groupBox2.Controls.Add(this.bCreateUser);
            this.groupBox2.Location = new System.Drawing.Point(13, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Users";
            // 
            // bViewAllUsers
            // 
            this.bViewAllUsers.Location = new System.Drawing.Point(20, 60);
            this.bViewAllUsers.Name = "bViewAllUsers";
            this.bViewAllUsers.Size = new System.Drawing.Size(133, 35);
            this.bViewAllUsers.TabIndex = 2;
            this.bViewAllUsers.Text = "View All Users";
            this.bViewAllUsers.UseVisualStyleBackColor = true;
            // 
            // bCreateUser
            // 
            this.bCreateUser.Location = new System.Drawing.Point(20, 19);
            this.bCreateUser.Name = "bCreateUser";
            this.bCreateUser.Size = new System.Drawing.Size(133, 35);
            this.bCreateUser.TabIndex = 0;
            this.bCreateUser.Text = "Create";
            this.bCreateUser.UseVisualStyleBackColor = true;
            this.bCreateUser.Click += new System.EventHandler(this.bCreateUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bViewAllClients);
            this.groupBox1.Controls.Add(this.bSearchClient);
            this.groupBox1.Controls.Add(this.bCreateClient);
            this.groupBox1.Location = new System.Drawing.Point(13, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clients";
            // 
            // bViewAllClients
            // 
            this.bViewAllClients.Location = new System.Drawing.Point(20, 101);
            this.bViewAllClients.Name = "bViewAllClients";
            this.bViewAllClients.Size = new System.Drawing.Size(133, 35);
            this.bViewAllClients.TabIndex = 2;
            this.bViewAllClients.Text = "View All Client";
            this.bViewAllClients.UseVisualStyleBackColor = true;
            this.bViewAllClients.Click += new System.EventHandler(this.bViewAllClients_Click);
            // 
            // bSearchClient
            // 
            this.bSearchClient.Location = new System.Drawing.Point(20, 19);
            this.bSearchClient.Name = "bSearchClient";
            this.bSearchClient.Size = new System.Drawing.Size(133, 35);
            this.bSearchClient.TabIndex = 0;
            this.bSearchClient.Text = "Search";
            this.bSearchClient.UseVisualStyleBackColor = true;
            this.bSearchClient.Click += new System.EventHandler(this.bSearchClient_Click);
            // 
            // bCreateClient
            // 
            this.bCreateClient.Location = new System.Drawing.Point(20, 60);
            this.bCreateClient.Name = "bCreateClient";
            this.bCreateClient.Size = new System.Drawing.Size(133, 35);
            this.bCreateClient.TabIndex = 1;
            this.bCreateClient.Text = "Create New Client";
            this.bCreateClient.UseVisualStyleBackColor = true;
            this.bCreateClient.Click += new System.EventHandler(this.bCreateClient_Click);
            // 
            // pDisplayView
            // 
            this.pDisplayView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDisplayView.Location = new System.Drawing.Point(213, 12);
            this.pDisplayView.Name = "pDisplayView";
            this.pDisplayView.Size = new System.Drawing.Size(725, 450);
            this.pDisplayView.TabIndex = 1;
            // 
            // frmClientManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 472);
            this.Controls.Add(this.pDisplayView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientManager";
            this.Text = "ClientManager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pDisplayView;
        private System.Windows.Forms.Button bViewAllClients;
        private System.Windows.Forms.Button bCreateClient;
        private System.Windows.Forms.Button bSearchClient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bViewAllUsers;
        private System.Windows.Forms.Button bCreateUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}