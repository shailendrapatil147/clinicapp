using Clinic.Winform.Features;
using System;
using System.Windows.Forms;

namespace Clinic.Winform
{
    public partial class MenuDashboard : BaseForm
    {
        public MenuDashboard() : base()
        {
            InitializeComponent();
            //this.updateRadbBlankToolStripMenuItem.Visible = false;
            //this.orderMissingToolStripMenuItem.Visible = false;
            //this.userOperationsToolStripMenuItem.Visible = false;
            //this.updateInstallmentBillToolStripMenuItem.Visible = false;
            //this.removeDuplicateCompanyToolStripMenuItem.Visible = false;
        }

        private void MenuDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
       
        private void SearchPatitentStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SearchUsers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContainer.Controls.Add(form);
            form.Show();
        }

        private void AddNewPatitentStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddUpdateUser(new Contracts.Models.User()) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContainer.Controls.Add(form);
            form.Show();
        }
    }
}
