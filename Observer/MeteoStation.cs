using System.Collections.Generic;
using System;
using Observer.Interfaces;

namespace Observer
{
    class MeteoStation : IObsevable
    {
        double temperature = 0;
        double pressure = 0;
        List<IObserver> observers = new List<IObserver>();
        public void AddObserver(IObserver obj)
        {
            observers.Add(obj);
        }

        public void NotifyObserver()
        {
            foreach (var item in observers)
            {
                item.HandleEvent(temperature, pressure);
            }
        }

        public void RemoveObserver(IObserver obj)
        {
               observers.Remove(obj);
        }

        public void SetMeasurements(double temperature, double pressure)
        {
            this.temperature = temperature;
            this.pressure = pressure;
            NotifyObserver();
        }
    }
}