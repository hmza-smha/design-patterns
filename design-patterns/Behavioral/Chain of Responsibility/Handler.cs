using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Chain_of_Responsibility
{
    internal abstract class Handler
    {
        private Handler _next;

        public Handler SetNextHandler(Handler next)
        {
            _next = next;
            return _next;
        }

        public abstract bool Handle(string username, string password);

        protected bool HandleNext(string username, string passwoard)
        {
            if (_next == null) return true;

            return _next.Handle(username, passwoard);
        }
    }
}
