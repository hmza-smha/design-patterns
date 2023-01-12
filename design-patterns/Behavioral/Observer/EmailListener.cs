using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Observer
{
    internal class EmailListener
    {
        private string _customerName;

        public EmailListener(string customerName)
        {
            _customerName = customerName;
        }

        public void Update()
        {
            Console.WriteLine("Sending Email To" + _customerName + "....");
            // Sending Email Logic...
        }
    }
}
