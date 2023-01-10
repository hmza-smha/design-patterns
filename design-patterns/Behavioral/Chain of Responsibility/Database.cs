using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Chain_of_Responsibility
{
    internal class Database
    {
        private readonly Dictionary<string, string> _users;

        public Database()
        {
            _users = new Dictionary<string, string>();
            _users.Add("admin", "admin");
            _users.Add("user", "user");
        }

        public bool IsValidUser(string username)
        {
            return _users.ContainsKey(username);
        }

        public bool IsValidPassword(string username, string password)
        {
            string? pass = _users.GetValueOrDefault(username);

            return pass != null 
                ? pass.Equals(password) 
                : false;
        }

        public bool CheckRole(string username)
        {
            return username == "admin";
        }
    }
}
