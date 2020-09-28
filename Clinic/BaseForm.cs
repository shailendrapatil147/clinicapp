using Clinic.Contracts.Winform;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace Clinic.Winform
{
    public partial class BaseForm : Form
    {
        public Base Model { get; set; }

        protected string _connectionString { get; set; }
        protected string _devConnectionString { get; set; }
        protected string _logConnectionString { get; set; }

        //protected UserDetails _userDetails { get; set; }
        public BaseForm()
        {
            _connectionString = ConfigurationManager.AppSettings["ConnectionString"];

            InitializeComponent();
        }

        private void BaseForm_Load(object sender, System.EventArgs e)
        {
            baseHelpProvider.HelpNamespace = Path.GetFullPath(Environment.CurrentDirectory + @"\Resources\HelpMenu.htm");
        }
    }
}
