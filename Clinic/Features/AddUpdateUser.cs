using Clinic.BusinessLogic.Managers;
using Clinic.Contracts.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace Clinic.Winform.Features
{
    public partial class AddUpdateUser : BaseForm
    {
        private AddUpdateUserManager _addUpdateUserManager { get; set; }

        public AddUpdateUser(User user)
        {
            _addUpdateUserManager = new AddUpdateUserManager(user);
            InitializeComponent();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string errorMessage = string.Empty;

            errorMessage = _addUpdateUserManager.AddOrUpdateUser();
            this.Cursor = Cursors.Default;

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage);
            }
        }
        
        private void AddUpdateUser_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = _addUpdateUserManager.AddUpdateUser.User;
        }
    }
}
