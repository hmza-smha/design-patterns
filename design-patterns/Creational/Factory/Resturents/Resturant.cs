using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Factory.Burgers;

namespace ConsoleApp1.Factory.Resturents
{
    public abstract class Resturant
    {
        public IBurger OrderBurger()
        {
            IBurger burger = CreateBurger();
            burger.Prepare();

            return burger;
        }

        public abstract IBurger CreateBurger();
    }
}
