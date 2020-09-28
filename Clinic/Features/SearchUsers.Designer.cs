using System.Windows.Forms;

namespace Clinic.Winform.Features
{
    partial class SearchUsers
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblInputSeparator = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.colbtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Clinic.Contracts.Winform.SearchUsers);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(22, 16);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(96, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Details";
            // 
            // lblInputSeparator
            // 
            this.lblInputSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInputSeparator.Location = new System.Drawing.Point(22, 90);
            this.lblInputSeparator.Name = "lblInputSeparator";
            this.lblInputSeparator.Size = new System.Drawing.Size(965, 2);
            this.lblInputSeparator.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.baseHelpProvider.SetHelpString(this.txtUserName, "Please enter order number");
            this.txtUserName.Location = new System.Drawing.Point(126, 14);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.MaxLength = 10;
            this.txtUserName.Name = "txtUserName";
            this.baseHelpProvider.SetShowHelp(this.txtUserName, true);
            this.txtUserName.Size = new System.Drawing.Size(861, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(126, 53);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(176, 28);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchUsers_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvUsers);
            this.panel1.Location = new System.Drawing.Point(22, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 352);
            this.panel1.TabIndex = 3;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbtnEdit});
            this.dgvUsers.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.bindingSource, "IsUsersPopulated", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgvUsers.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.bindingSource, "Users", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(964, 349);
            this.dgvUsers.TabIndex = 2;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // colbtnEdit
            // 
            this.colbtnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colbtnEdit.HeaderText = "Update User Details";
            this.colbtnEdit.Name = "colbtnEdit";
            this.colbtnEdit.ReadOnly = true;
            this.colbtnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colbtnEdit.Text = "Edit";
            this.colbtnEdit.UseColumnTextForButtonValue = true;
            this.colbtnEdit.Width = 143;
            // 
            // SearchUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblInputSeparator);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchUsers";
            this.baseHelpProvider.SetShowHelp(this, true);
            this.Text = "SearchUsers";
            this.Load += new System.EventHandler(this.SearchUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblInputSeparator;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panel1;
        private DataGridViewButtonColumn colbtnEdit;
    }
}