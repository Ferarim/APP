using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FerarimTournaments.Objects;
using FerarimTournaments.Tools;

namespace FerarimTournaments.Dashboard
{
    public partial class AccountInfoForm : Form
    {
        private Account currentAccount;
        //homeform to access its methods
        private HomeForm homeForm;
        public AccountInfoForm(Account account, HomeForm homeForm)
        {
            InitializeComponent();
            this.currentAccount = account;
            this.homeForm = homeForm;
            InitItems();
            //InitTeamInfo();
        }

        public void InitItems()
        {
            this.nameLabel.Text = currentAccount.FirstName;
            this.surnameLabel.Text = currentAccount.LastName;
            this.roleLabel.Text = currentAccount.Role;
        }

        public void InitTeamInfo()
        {
            //this.yourTeamLabel.Text = ;
            //this.teamLogoPicture.Image = ;
        }

        private void yourTeamClick(object sender, EventArgs e)
        {
            homeForm.yourTeamPanelClick(sender, e);
        }

        private void changeAccountInfoBtn_Click(object sender, EventArgs e)
        {
            ChangeAccountInfoForm form = new ChangeAccountInfoForm(currentAccount, homeForm);
            homeForm.OpenChildForm(form);
        }
    }
}
