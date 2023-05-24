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
                teamSettings.Visible = false;
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
            Team team = APIController.GetTeam(accountInstance.TeamId);
            this.TeamNameLabel.Text = team.Name;
            this.teamOwnerLabel.Text = team.Owner;
        }

        private void teammates_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new TeammatesForm());
        }

        private void teamSettings_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new TeamSettingsForm());
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            //do the math
        }
    }
}
