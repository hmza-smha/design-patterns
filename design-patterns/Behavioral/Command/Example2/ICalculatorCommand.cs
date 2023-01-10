using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Command.Example2
{
    internal interface ICalculatorCommand
    {
        double Excute(double currentValue);

        double Undo(double currentValue);
    }
}
