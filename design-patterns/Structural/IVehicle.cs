using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Structural
{
    internal interface IVehicle
    {
        void Accelerate();
        void PushBreak();
        void SoundHorn();
        public void Play()
        {
            Accelerate();
            PushBreak();
            SoundHorn();
        }
    }
}
