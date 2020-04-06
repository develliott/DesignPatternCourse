using System.Collections.Generic;
using ProjectOne.ObserverPattern.Core;

namespace ProjectOne.ObserverPattern
{
    //Observable
    public class Subject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public void AddObserver(IObserver observer) => _observers.Add(observer);
        public void RemoveObserver(IObserver observer) => _observers.Remove(observer);

        public void NotifyObservers(int value) => _observers.ForEach(observer => observer.Update(value));
    }
}
