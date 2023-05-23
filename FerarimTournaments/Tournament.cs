using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerarimTournaments.Objects
{
    public class Tournament
    {
        private DateTime date;
        private string team1;
        private string team2;
        private string info;

        public Tournament(DateTime date, string team1, string team2, string info)
        {
            this.Date = date;
            this.Team1 = team1;
            this.Team2 = team2;
            this.Info = info;
        }

        public DateTime Date { get => date; set => date = value; }
        public string Team1 { get => team1; set => team1 = value; }
        public string Team2 { get => team2; set => team2 = value; }
        public string Info { get => info; set => info = value; }
    }
}
