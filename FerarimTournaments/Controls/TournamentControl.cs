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
    public partial class TournamentControl : UserControl
    {
        private Tournament tournamentInstance;
        private HomeForm homeForm;
        public TournamentControl(Tournament tournament, HomeForm homeForm)
        {
            InitializeComponent();
            this.tournamentInstance = tournament;
            this.homeForm = homeForm;
        }

        public Tournament TournamentInstance { get => tournamentInstance; set => tournamentInstance = value; }

        private void TournamentControl_Click(object sender, EventArgs e)
        {
            TournamentsInfoForm form = new TournamentsInfoForm(tournamentInstance);
            homeForm.OpenChildForm(form);
        }
    }
}