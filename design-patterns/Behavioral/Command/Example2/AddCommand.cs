using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Command.Example2
{
    internal class AddCommand : ICalculatorCommand
    {
        private double _valueToAdd;

        public AddCommand(double valueToAdd)
        {
            _valueToAdd = valueToAdd;
        }

        public double Excute(double currentValue)
        {
            return currentValue + _valueToAdd;
        }

        public double Undo(double currentValue)
        {
            return currentValue - _valueToAdd;
        }
    }
}
