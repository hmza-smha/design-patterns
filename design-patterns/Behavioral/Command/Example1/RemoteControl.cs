using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Command.Example1
{
    internal class RemoteControl
    {
        private List<ICommand> _commands;

        public RemoteControl()
        {
            _commands = new List<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void OnButtonPressed(int index)
        {
            _commands[index].Execute();
        }
    }
}
