using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerarimTournaments.Objects
{
    public class Team
    {
        public string Name { get;  set; }
        public string Password { get;  set; }
        public string OwnerName { get;  set; }
        public List<Account> Members { get;  set; }
        public Team(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }

        public Team(string name, string password, string owner, List<Account> members)
        {
            this.Name = name;
            this.Password = password;
            this.OwnerName = owner;
            this.Members = members;
        }

        public Team() { }

    }
}
