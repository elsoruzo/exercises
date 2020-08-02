using System.Collections.Generic;

namespace ObserverPattern.Models
{
    public abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public abstract void SetState(string state);
        public abstract string GetState();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach(Observer observer in _observers)
            {
                observer.Update();
            }
        }
	}
}
