using System;
using Factory.Intefaces;

namespace Factory.Classes
{
    sealed class RomeWatch : IWatch
    {
        public void ShowTime()
        {
            System.Console.WriteLine("VII-XI");
        }
    }
}