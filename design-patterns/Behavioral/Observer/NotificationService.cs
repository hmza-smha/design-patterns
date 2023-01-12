using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Observer
{
    internal class NotificationService
    {
        private readonly List<EmailListener> listeners = new List<EmailListener>();

        public void Subscribe(EmailListener listener)
        {
            listeners.Add(listener);
        }

        public void Unsubscribe(EmailListener listener) 
        { 
            listeners.Remove(listener);
        }

        internal void notify()
        {
            listeners.ForEach(listener => listener.Update());
        }
    }
}
