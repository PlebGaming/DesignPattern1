using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment
{
    internal class Email : IEmail
    {
        public List<IObserver> Observers { get; set; }

        public Email()
        {
            Observers = new();
        }

        public void notifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update("this is the email");
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void UnRegisterObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Check()
        {
            notifyObservers();
        }
    }
}