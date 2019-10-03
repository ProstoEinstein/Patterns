using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes.Device.EnDevice
{
    sealed class EnTouchpad : ITouchpad
    {
        public void Track(int deltaX, int deltaY)
        {
            int result = (int) Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            System.Console.WriteLine("Moved {0} pixels", result);
        }
    }
}