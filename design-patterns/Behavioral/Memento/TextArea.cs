using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Memento
{
    internal class TextArea
    {
        public string Text { get; set; }

        public Memento TakeSnapshot()
        {
            return new Memento(Text);
        }

        public string RestoreFromMemory(Memento memento)
        {
            Text = memento.GetSavedText();
            return Text;
        }



        // you are saving a string
        public class Memento{

            private string _text;
             
            public Memento(string textToSave)
            {
                _text = textToSave;
            }

            public string GetSavedText()
            {
                return _text;
            }
        }
    }
}
