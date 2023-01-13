using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Structural
{
    // So we need the Bicycle to work like the car
    internal class Bicycle
    {
        public void Pedal()
        {
            Console.WriteLine("Bicycle Pedaling.....");
        }
        public void Stop()
        {
            Console.WriteLine("Bicycle Stoping.....");
        }
        public void RingBell()
        {
            Console.WriteLine("Bicycle Ring Ring.....");
        }
    }
}
