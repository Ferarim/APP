using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FerarimTournaments.Logic;
using FerarimTournaments.Objects;
using FerarimTournaments.Tools;

namespace FerarimTournaments.Dashboard
{
    public partial class TeamForm : Form
    {
        private Account accountInstance;
        private HomeForm homeForm;
        private Team teamInstance;
        public TeamForm(Account account, HomeForm homeForm)
        {
            InitializeComponent();
            this.accountInstance = account;
            this.homeForm = homeForm;
            TeamCheck();
            AdminCheck();
            
        }

        public void AdminCheck()
        {
            if (accountInstance.Role == "ROLE_USER")
            {
                teamSettingsBtn.Visible = false;
            }
        }

        public void TeamCheck()
        {
            if (accountInstance.TeamId == 0)
            {
                teamPanel.Visible = false;
            }
            else
            {
                InitItems();
            }
        }

        public void InitItems()
        {
            teamInstance = APIController.GetTeam(accountInstance.TeamId);
            this.TeamNameLabel.Text = teamInstance.Name;
            this.teamOwnerLabel.Text = teamInstance.OwnerName;
        }

        private void teammates_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new TeammatesForm(teamInstance.Members));
        }

        private void teamSettings_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new TeamSettingsForm());
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(this.teamPassBox.Text) || String.IsNullOrEmpty(this.teamNameBox.Text))
            {
                return;
            }

            APIController.JoinTeam(this.teamNameBox.Text.Trim(), this.teamPassBox.Text.Trim());
        }
    }
}
