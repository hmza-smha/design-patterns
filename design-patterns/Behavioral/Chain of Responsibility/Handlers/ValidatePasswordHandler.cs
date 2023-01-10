using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Chain_of_Responsibility
{
    internal class ValidatePasswordHandler : Handler
    {
        private Database _database;

        public ValidatePasswordHandler(Database database)
        {
            _database = database;
        }

        public override bool Handle(string username, string password)
        {
            if (!_database.IsValidPassword(username, password))
            {
                Console.WriteLine("Wrong Password!");
                return false;
            }

            return HandleNext(username, password);
        }
    }
}
