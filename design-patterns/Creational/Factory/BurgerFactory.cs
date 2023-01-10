using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Factory.Burgers;

namespace ConsoleApp1.Factory
{
    /*
     * We No longer use this class, because this class violates open-close principle
     */
    public class BurgerFactory
    {
        public IBurger CreateBurger(string type)
        {
            IBurger? burger = null;

            if ("BEEF".Equals(type))
                burger = new BeefBurger();

            if ("CHICKEN".Equals(type))
                burger = new ChickenBurger();

            return burger ?? throw new NullReferenceException();

        }
    }
}
