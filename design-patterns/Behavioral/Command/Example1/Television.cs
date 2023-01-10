using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Command.Example1
{
    internal class Television
    {
        public void TurnOn()
        {
            Console.WriteLine("TV is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("TV is Off");
        }
    }
}
