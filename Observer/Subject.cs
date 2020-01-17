using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Observer
{
    public class Subject : ISubject
    {
        public int Temperature { get; set; } = 0;
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Attach new observer");
            observers.Add(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Temperature NOTIFY!");
            this.Temperature = new Random().Next(-30, 50);
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
            Thread.Sleep(15);

            Console.WriteLine("Now Temperature is: " + this.Temperature);
            
        }

        public void Remove(IObserver observer)
        {
            Console.WriteLine("Remove observer");
            observers.Remove(observer);
        }
    }
}
