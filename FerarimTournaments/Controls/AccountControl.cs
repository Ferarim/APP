using FerarimTournaments.Dashboard;
using FerarimTournaments.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerarimTournaments.Controls
{
    public partial class AccountControl : UserControl
    {
        private Account accountInstance;
        private string currentAccountRole;
        public AccountControl(Account account)
        {
            InitializeComponent();
            this.accountInstance = account;
            this.currentAccountRole = HomeForm.CURRENT_ACCOUNT_ROLE;
            InitItems();
            CheckForAdmin();
        }

        public void InitItems()
        {
            this.usernameLabel.Text = accountInstance.UserName;
            this.nameAndSurnameLabel.Text = accountInstance.FirstName + " " + accountInstance.LastName;
            this.roleLabel.Text = accountInstance.Role;
        }

        public void CheckForAdmin()
        {
            if(currentAccountRole == "ROLE_USER")
            {
                this.removeAccountFromTeamBtn.Visible = false;
            }
        }
        private void removeAccountFromTeamBtn_Click(object sender, EventArgs e)
        {
            //do the math bruh
        }
    }
}
