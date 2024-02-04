using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Design_Patterns._3._Observer
{
    // Subject interface
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    // Concrete subject
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string state;

        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Notify();
            }
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }

    // Observer interface
    public interface IObserver
    {
        void Update();
    }

    // Concrete observer
    public class ConcreteObserver : IObserver
    {
        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public void Update()
        {
            Console.WriteLine($"Observer: Subject's state has changed to {subject.State}");
        }
    }
}
