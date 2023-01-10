using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Factory.Burgers
{
    public class BeefBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing Beef Burger....");
        }
    }
}
