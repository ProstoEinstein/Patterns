using System;
using Factory.Classes;
using Factory.Intefaces;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IWatchMaker maker = new DigitalWatchMaker();
            IWatch watch = maker.CreateWatch();
            watch.ShowTime();
        }
    }
}
