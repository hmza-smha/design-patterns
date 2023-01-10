using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Command.Example2
{
    internal class Calculator
    {
        public double value;
        Stack<ICalculatorCommand> history;

        public Calculator()
        {
            history = new Stack<ICalculatorCommand>();
        }

        public void ExcuteCommand(ICalculatorCommand command)
        {
            value = command.Excute(value);
            history.Push(command);
        }

        public void UndoCommand()
        {
            value = history.Pop().Undo(value);
        }
    }
}
