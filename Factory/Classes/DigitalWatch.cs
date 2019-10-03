using System;
using Factory.Intefaces;

namespace Factory.Classes
{
    sealed class DigitalWatch : IWatch
    {
        public void ShowTime()
        {
            System.Console.WriteLine(DateTime.Now);
        }
    }
}