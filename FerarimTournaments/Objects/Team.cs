using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerarimTournaments.Objects
{
    public class Team
    {
        public string Name { get; private set; }
        public string Password { get; private set; }
        public string Owner { get; private set; }
        public List<Account> Members { get; private set; }
        public Team(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }

        public Team(string name, string password, string owner, List<Account> members)
        {
            this.Name = name;
            this.Password = password;
            this.Owner = owner;
            this.Members = members;
        }

    }
}
