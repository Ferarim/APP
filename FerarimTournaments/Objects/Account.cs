using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace FerarimTournaments.Objects
{
    public class Account
    {
        private int id;
        private string userRole;
        private string userName;
        private string firstName;
        private string lastName;

        public Account()
        {

        }

        public Account(int id, string userRole, string userName, string firstName, string lastName)
        {
            this.Id = id;
            this.UserRole = userRole;
            this.UserName = userName;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id { get => id; set => id = value; }
        public string UserRole { get => userRole; set => userRole = value; }
        public string UserName { get => userName; set => userName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }



    }
}
