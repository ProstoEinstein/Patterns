using System;
using Factory.Intefaces;

namespace Factory.Classes
{
    sealed class DigitalWatchMaker : IWatchMaker
    {
        public IWatch CreateWatch()
        {
            return new DigitalWatch();
        }
    }
}