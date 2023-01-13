using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Structural
{
    /*
     * We have the car works fine, we need the Bicycle to work just like the car
     * --> The Adapter implements the Target
     */
    internal class BicycleAdapter : IVehicle
    {
        private Bicycle _bicycle;

        public BicycleAdapter(Bicycle bicycle)
        {
            _bicycle = bicycle;
        }

        public void Accelerate()
        {
            _bicycle.Pedal();
        }

        public void PushBreak()
        {
            _bicycle.Stop();
        }

        public void SoundHorn()
        {
            _bicycle.RingBell();
        }
    }
}
