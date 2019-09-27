using System;
using Observer.Interfaces;

namespace Observer
{
    class ConsoleObserver : IObserver
    {
        public void HandleEvent(double temperature, double pressure)
        {
            Console.WriteLine("Погода изменилась. Температура {0}, Давление {1}", temperature, pressure);
        }
    }
}