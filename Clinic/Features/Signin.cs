using Clinic.Managers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clinic.Winform.Features
{
    public partial class Signin : BaseForm
    {
        private LoginManager _loginManager { get; set; }
        public Signin()
        {
            _loginManager = new LoginManager();
            InitializeComponent();

            textBox1.ForeColor = Color.LightGray;
            //textBox1.Text = "Please Enter Name";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);

           
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                //string message = _loginManager.GetLoginUserDetails();
                //Program.userDetails = _loginManager.GetLoginUserDetails("Login");
                //if (Program.userDetails == null)
                //{
                //    MessageBox.Show("Login Failed!");
                //}
                //else
                //{
                //    //MessageBox.Show("Login Failed!");
                //    this.Hide();
                MenuDashboard ds = new MenuDashboard();
                ds.Show();
                this.Hide();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Signin_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = _loginManager.LoginData;            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
                textBox2.ForeColor = Color.Black;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.PasswordChar = '\0';
                textBox2.ForeColor = Color.Gray;
            }
        }
    }
}
