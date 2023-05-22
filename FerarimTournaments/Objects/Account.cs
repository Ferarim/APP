using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace FerarimTournaments.Objects
{
    public class Account
    {
        private int id;
        private string role;
        private string userName;
        private string firstName;
        private string lastName;

        public Account()
        {
        }

        public Account(int id, string role, string userName, string firstName, string lastName)
        {
            this.Id = id;
            this.Role = role;
            this.UserName = userName;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id { get => id; set => id = value; }
        public string Role { get => role; set => role = value; }
        public string UserName { get => userName; set => userName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }



    }
}
