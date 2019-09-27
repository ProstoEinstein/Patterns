using System;
using Observer.Interfaces;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            MeteoStation station = new MeteoStation();
            station.AddObserver(new ConsoleObserver());
            station.AddObserver(new FileObserver());

            station.SetMeasurements(25, 760);
            station.SetMeasurements(-25, 160);
        }
    }
}
