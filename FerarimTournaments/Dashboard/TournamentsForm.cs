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
using FerarimTournaments.Controls;

namespace FerarimTournaments.Dashboard
{
    public partial class TournamentsForm : Form
    {
        private Account currentAccount;
        private HomeForm homeForm;
        public TournamentsForm(Account account, HomeForm homeForm)
        {
            InitializeComponent();

            this.currentAccount = account;
            this.homeForm = homeForm;

            CheckForAdmin(currentAccount);
            InitTournamentControls();
        }
        /// <summary>
        /// Is account if user -> won't be able to create new tournaments
        /// </summary>
        /// <param name="account"></param>
        public void CheckForAdmin(Account account)
        {
            if (account.Role != "ROLE_USER")
            {
                this.newTournamentBtn.Visible = false;
            }
        }

        public void InitTournamentControls()
        {
            this.flowPanel.Controls.Clear();
            //fetch tournaments from API
            //public TournamentControl(Tournament tournament, HomeForm homeForm)
            List<TournamentControl> tournamentList = new List<TournamentControl>();

            var sortedTournamentList = tournamentList.OrderBy(t => t.TournamentInstance.Date);
            TournamentControl[] finalList = sortedTournamentList.ToArray();
            foreach(TournamentControl t in finalList)
            {
                this.flowPanel.Controls.Add(t);
            }
        }

        private void newTournamentBtn_Click(object sender, EventArgs e)
        {
            this.homeForm.OpenChildForm(new CreateTournamentForm());
        }
    }
}
