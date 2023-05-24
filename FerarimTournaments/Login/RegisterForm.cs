using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerarimTournaments.Login
{
    public partial class RegisterForm : Form
    {
        LoginForm loginForm;

        Register register = new Register();
        public RegisterForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;          
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            register.AttemptRegister(loginForm, this, username.Text, firstName.Text, lastName.Text, password.Text);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Hide();
            loginForm.Show();
        }
    }
}
