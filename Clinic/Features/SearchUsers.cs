using Clinic.BusinessLogic.Managers;
using Clinic.Contracts.Models;
using System;
using System.Windows.Forms;

namespace Clinic.Winform.Features
{
    public partial class SearchUsers : BaseForm
    {
        private SearchUsersManager _searchUsersManager { get; set; }

        public SearchUsers()
        {
            _searchUsersManager = new SearchUsersManager();
            InitializeComponent();
        }

        private void btnSearchUsers_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string errorMessage = string.Empty;
            errorMessage = _searchUsersManager.SearchUsersByName();
            this.Cursor = Cursors.Default;

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage);
            }
        }
        private void txtUpdatePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        private void SearchUsers_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = _searchUsersManager.SearchUsers;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(_searchUsersManager?.SearchUsers?.Users?.Count > 0 &&  e.RowIndex >=0)
            {
                var EditUser = new AddUpdateUser(_searchUsersManager.SearchUsers.Users[e.RowIndex]) { TopLevel = true, TopMost = true };
                //this.Controls.Add(EditUser);
                EditUser.Show();
            }
        }
    }
}
