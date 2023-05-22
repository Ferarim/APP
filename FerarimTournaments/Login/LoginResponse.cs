using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerarimTournaments.Login
{
    public class LoginResponse
    {

        public bool Success { get; private set; }
        public string UserRole { get; private set; }
        public string Message { get; private set; }
        public int Id { get; private set; }

        public LoginResponse(bool success, string role, string message, int userId)
        {
            this.Success = success;
            this.UserRole = role;
            this.Message = message;
            this.Id = userId;
        }
    }
}
