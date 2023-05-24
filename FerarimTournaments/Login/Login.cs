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
            APIController.credentials = (form.Username.Text, form.Password.Text);
            Account currentUser = APIController.GetAccount(id);
            if (currentUser == null) throw new Exception("account fetch failed");

            currentUser.Password = form.Password.Text;

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
    }
}
