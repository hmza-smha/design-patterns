using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Chain_of_Responsibility.Handlers
{
    internal class CheckRoleHandler : Handler
    {
        private Database _database;

        public CheckRoleHandler(Database database)
        {
            _database = database;
        }

        public override bool Handle(string username, string password)
        {
            if (_database.CheckRole(username))
            {
                Console.WriteLine("You are Admin");
                return true;
            }

            return HandleNext(username, password); ;
        }
    }
}
