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
        private readonly object _lock = new object();

        public string Username { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Password { get; private set; }

        public void AttemptRegister(string username, string firstname, string lastname, string password)
        {
            Username = username;
            FirstName = firstname;
            LastName = lastname;
            Password = Login.HashString(password);

            if (fetchThread != null && fetchThread.ThreadState == ThreadState.Running)
                fetchThread.Abort();

            fetchThread = new Thread(StartRegister);
            fetchThread.Start();
        }

        public void StartRegister()
        {
            lock (_lock)
            {
                //LoginResponse response = APIController.RequestRegister(Username, Password);
                //if (response == null) throw new Exception("register fetch failed");

                //if (response.Success) ProceedToHome(response.Id);
                //else
                {
                    //print message to label
                    //delete password field
                }
            }
        }
    }
}
