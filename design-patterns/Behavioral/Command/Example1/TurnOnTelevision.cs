using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Command.Example1
{
    internal class TurnOnTelevision : ICommand
    {
        private Television _tv;

        public TurnOnTelevision(Television tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.TurnOn();
        }
    }
}
