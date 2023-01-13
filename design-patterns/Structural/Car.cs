using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Structural
{
    internal class Car : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Car Start Moving...");
        }

        public void PushBreak()
        {
            Console.WriteLine("Car Pushing Break...");
        }

        public void SoundHorn()
        {
            Console.WriteLine("Car Beeb Beeeeeb...");
        }

    }
}
