using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Memento
{
    internal class Editor
    {
        public List<TextArea.Memento> stateHestory;
        public TextArea textarea;
        private int state = -1;


        public Editor()
        {
            stateHestory = new List<TextArea.Memento>();
            textarea = new TextArea();
        }

        public void Write(string text)
        {
            state++;
            textarea.Text = text;
            stateHestory.Add(textarea.TakeSnapshot());
        }

        public void Undo()
        {
            state--;
            textarea.RestoreFromMemory(stateHestory[state]);
        }

        public void Redo()
        {
            state++;
            textarea.RestoreFromMemory(stateHestory[state]);
        }

    }
}
