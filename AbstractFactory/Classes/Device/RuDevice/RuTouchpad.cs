using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes.Device.RuDevice
{
    sealed class RuTouchpad : ITouchpad
    {
        public void Track(int deltaX, int deltaY)
        {
            int result = (int) Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            System.Console.WriteLine("Передвинулись на {0} пикселей", result);
        }
    }
}