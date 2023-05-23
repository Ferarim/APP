using FerarimTournaments.Dashboard;
using FerarimTournaments.Logic;
using FerarimTournaments.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerarimTournaments.Login
{
    public class Login
    {
        private Thread fetchThread;
        private readonly object _lock = new object();
     
        /// <summary>
        /// Attempts to fetch data from API, if successful, starts ProceedToHome(), 
        /// else prompts user for another try. 
        /// </summary>
        private void StartLogin(LoginForm form)
        {
            lock (_lock)
            {
                string username = form.Username.Text;
                string password = form.Password.Text;
                                                                            //HashString(password)
                LoginResponse response = APIController.RequestLogin(username, password);
                if (response == null) throw new Exception("login fetch failed");

                if (response.Success) ProceedToHome(form, response.Id);
                else
                {
                    //print message to label
                    //delete password field
                    Action resetText = delegate { form.Password.Text = ""; };
                    form.Invoke(resetText);
                }               
            }
        }

        /// <summary>
        /// Requests an account object corresponding to the id passed, then starts HomeForm.
        /// </summary>
        private void ProceedToHome(LoginForm form, int id)
        {
            //pull for account object, start homepage
            Account currentUser = APIController.GetAccount(id);
            if (currentUser == null) throw new Exception("account fetch failed");

            Action closeForm = delegate { form.Close(); };
            form.Invoke(closeForm);
            Application.Run(new HomeForm(currentUser));
        }

        /// <summary>
        /// Starts a new thread that attempts to log user in.
        /// </summary>
        public void AttemptLog(LoginForm form)
        {   
            if(fetchThread != null && fetchThread.ThreadState == ThreadState.Running)
                fetchThread.Abort();

            fetchThread = new Thread(() => StartLogin(form));
            fetchThread.Start();          
        }

        public static string HashString(string text, string salt = "")
        {
            if (String.IsNullOrEmpty(text))
            {
                return String.Empty;
            }

            // Uses SHA256 to create the hash
            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                // Convert the string to a byte array first, to be processed
                byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(text + salt);
                byte[] hashBytes = sha.ComputeHash(textBytes);

                // Convert back to a string, removing the '-' that BitConverter adds
                string hash = BitConverter
                    .ToString(hashBytes)
                    .Replace("-", String.Empty);

                return hash;
            }
        }
    }
}
