using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Factory.Burgers;

namespace ConsoleApp1.Factory.Resturents
{
    public class ChickenBurgerResturent : Resturant
    {
        public override IBurger CreateBurger()
        {
            return new ChickenBurger();
        }
    }
}
