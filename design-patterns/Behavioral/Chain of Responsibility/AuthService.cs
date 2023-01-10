using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Chain_of_Responsibility
{
    internal class AuthService
    {
        private Handler _handler;

        public AuthService(Handler handler)
        {
            _handler = handler;
        }

        public bool Login(string username, string password)
        {
            if (_handler.Handle(username, password))
            {
                Console.WriteLine("Logged in Successfully!");
                return true;
            }

            return false;
        }
    }
}
