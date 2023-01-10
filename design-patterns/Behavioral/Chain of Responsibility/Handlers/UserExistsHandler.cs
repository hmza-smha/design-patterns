using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Chain_of_Responsibility
{
    internal class UserExistsHandler : Handler
    {
        private Database _database;

        public UserExistsHandler(Database database)
        {
            _database = database;
        }

        public override bool Handle(string username, string password)
        {
            if (!_database.IsValidUser(username))
            {
                Console.WriteLine("The username is not registered!");
                Console.WriteLine("Sign-up now!");
                return false;
            }

            return HandleNext(username, password);
        }
    }
}
