using FerarimTournaments.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace FerarimTournaments.Login
{
    public partial class LoginForm : Form
    {
        private Login login = new Login();
       
        RegisterForm currentRegisterForm;

        public LoginForm()
        {
            InitializeComponent();           
        }
     

        //get set
        public TextBox Username
        {
            get { return username; }
            set { username = value; }
        }
        public TextBox Password
        {
            get { return password; }
            set { password = value; }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            login.AttemptLog(this);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm;
            if (currentRegisterForm != null)
                registerForm = currentRegisterForm;
            else registerForm = new RegisterForm(this);

            currentRegisterForm = registerForm;
            registerForm.TopLevel = false;
            registerForm.FormBorderStyle = FormBorderStyle.None;
            registerForm.Dock = DockStyle.Fill;

            Controls.Add(registerForm);
            registerForm.BringToFront();
            registerForm.Show();           
        }
       
    }
}
//dumpster


/*
 *  /*private int boxWidth = 350, boxHeight = 40;

        public TextBox Username { get; private set; }
        public TextBox Password { get; private set; }
        
this.BackColor = Color.FromArgb(1, 172, 189);
            
            InitButtons(550, 300, "Log in");
            InitButtons(100, 300, "Register");
            Password = InitTextbox(100, 200, boxWidth, boxHeight);
            Username = InitTextbox(100, 50, boxWidth, boxHeight);

*  private TextBox InitTextbox(int x, int y, int width, int height)
        {
            Color backColor = Color.FromArgb(26, 26, 26);
            Color foreColor = Color.White;
            int padding = 10;
            TextBox credentialsBox = new TextBox();
            Panel container = new Panel();

            container.SetBounds(x, y, width, height);
            container.BackColor = backColor;
            container.ForeColor = foreColor;
            container.Padding = new Padding(padding);


            credentialsBox.AcceptsReturn = true;
            credentialsBox.AcceptsTab = true;
            credentialsBox.Dock = DockStyle.Fill;
            //credentialsBox.Anchor = AnchorStyles.Bottom;
            credentialsBox.MaxLength = 100;
            credentialsBox.BorderStyle = BorderStyle.None;
            credentialsBox.Multiline = false;
            credentialsBox.BackColor = backColor;
            credentialsBox.ForeColor = foreColor;
            credentialsBox.Location = new Point(x, y + padding);
            credentialsBox.Font = new Font(credentialsBox.Font.FontFamily, 12);

            container.Controls.Add(credentialsBox);
            this.Controls.Add(container);

            return credentialsBox;
        }

        private void InitButtons(int x, int y, string text)
        {
            LoginButton logB = new LoginButton();
            logB.SetBounds(x, y, boxWidth, boxHeight);
            logB.Font = new Font(logB.Font.FontFamily, 14);
            logB.Width = 100;
            logB.Text = text;
            logB.Click += new EventHandler(login.AttemptLog);
            this.Controls.Add(logB);
        }*/

