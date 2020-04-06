using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.MediatorPattern.UI
{
    public abstract class UIControl
    {

        private List<Action> _observers = new List<Action>();

        public void Attach(Action observer)
        {
            _observers.Add(observer);
        }

        protected void NotifyObservers()
        {
            _observers.ForEach(observer => observer.Invoke());
        }
    }
}
