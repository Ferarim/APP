using FerarimTournaments.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FerarimTournaments.Login
{
    internal class Register
    {
        private Thread fetchThread;
        private LoginForm loginForm;
        private RegisterForm registerForm;
        private readonly object _lock = new object();

        public string Username { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Password { get; private set; }

        public void AttemptRegister(LoginForm loginForm, RegisterForm registerForm, string username, string firstname, string lastname, string password)
        {
            this.loginForm = loginForm;
            this.registerForm = registerForm;
            Username = username;
            FirstName = firstname;
            LastName = lastname;
            Password = password;

            if (fetchThread != null && fetchThread.ThreadState == ThreadState.Running)
                fetchThread.Abort();

            fetchThread = new Thread(StartRegister);
            fetchThread.Start();
        }

        public void StartRegister()
        {
            lock (_lock)
            {               
                if(!APIController.RequestRegister(Username, FirstName, LastName, Password))
                {
                    Console.WriteLine("error happened");
                    //print error mb
                    return;
                }
                Action returnToLogin = delegate {
                    loginForm.Show();
                    registerForm.Hide();
                };
                loginForm.Invoke(returnToLogin);
            }
        }
    }
}
