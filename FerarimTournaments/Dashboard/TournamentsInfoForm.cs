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

namespace FerarimTournaments.Dashboard
{
    public partial class TournamentsInfoForm : Form
    {
        private Tournament tournamentInstance;
        public TournamentsInfoForm(Tournament tournament)
        {
            InitializeComponent();
            this.tournamentInstance = tournament;
        }
    }
}
