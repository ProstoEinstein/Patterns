using System;
using Factory.Intefaces;

namespace Factory.Classes
{
    sealed class RomeWatchMaker : IWatchMaker
    {
        public IWatch CreateWatch()
        {
            return new RomeWatch();
        }
    }
}