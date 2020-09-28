namespace Clinic.Winform
{
    partial class MenuDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDashboard));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patitents = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatitent = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPatitent = new System.Windows.Forms.ToolStripMenuItem();
            this.patitentDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.newTreatment = new System.Windows.Forms.ToolStripMenuItem();
            this.thisIsSoftDeleteOperationWhereOrderWillBeMovingToNewProvidedEmailAddressToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patitents,
            this.patitentDetails});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patitents
            // 
            this.patitents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPatitent,
            this.searchPatitent});
            this.patitents.Name = "patitents";
            this.patitents.Size = new System.Drawing.Size(65, 20);
            this.patitents.Text = "Patitents";
            // 
            // newPatitent
            // 
            this.newPatitent.Name = "newPatitent";
            this.newPatitent.Size = new System.Drawing.Size(109, 22);
            this.newPatitent.Text = "New";
            this.newPatitent.Click += new System.EventHandler(this.AddNewPatitentStripMenuItem_Click);
            // 
            // searchPatitent
            // 
            this.searchPatitent.Name = "searchPatitent";
            this.searchPatitent.Size = new System.Drawing.Size(109, 22);
            this.searchPatitent.Text = "Search";
            this.searchPatitent.Click += new System.EventHandler(this.SearchPatitentStripMenuItem_Click);
            // 
            // patitentDetails
            // 
            this.patitentDetails.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTreatment});
            this.patitentDetails.Name = "patitentDetails";
            this.patitentDetails.Size = new System.Drawing.Size(98, 20);
            this.patitentDetails.Text = "Patitent Details";
            // 
            // newTreatment
            // 
            this.newTreatment.Name = "newTreatment";
            this.newTreatment.Size = new System.Drawing.Size(179, 22);
            this.newTreatment.Text = "Add New Treatment";
            // 
            // thisIsSoftDeleteOperationWhereOrderWillBeMovingToNewProvidedEmailAddressToolStripMenuItem1
            // 
            this.thisIsSoftDeleteOperationWhereOrderWillBeMovingToNewProvidedEmailAddressToolStripMenuItem1.Name = "thisIsSoftDeleteOperationWhereOrderWillBeMovingToNewProvidedEmailAddressToolStrip" +
    "MenuItem1";
            this.thisIsSoftDeleteOperationWhereOrderWillBeMovingToNewProvidedEmailAddressToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContainer.BackgroundImage")));
            this.pnlContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 24);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1028, 575);
            this.pnlContainer.TabIndex = 3;
            // 
            // MenuDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 599);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "MenuDashboard";
            this.baseHelpProvider.SetShowHelp(this, true);
            this.ShowIcon = false;
            this.Text = "Clinic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuDashboard_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newPatitent;
        private System.Windows.Forms.ToolStripMenuItem thisIsSoftDeleteOperationWhereOrderWillBeMovingToNewProvidedEmailAddressToolStripMenuItem1;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.ToolStripMenuItem patitents;
        private System.Windows.Forms.ToolStripMenuItem patitentDetails;
        private System.Windows.Forms.ToolStripMenuItem newTreatment;
        private System.Windows.Forms.ToolStripMenuItem searchPatitent;
    }
}