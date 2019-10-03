using System;
using AbstractFactory.Classes;
using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeviceFactory factory = GetFactoryByCountry("EN");

            IMouse mouse = factory.GetMouse();
            IKeyboard keyboard = factory.GetKeyboard();
            ITouchpad touchpad = factory.GetTouchpad();

            mouse.Click();
            keyboard.Print();
            keyboard.Println();
            touchpad.Track(10, 35);
        }

        private static IDeviceFactory GetFactoryByCountry(string code)
        {
            switch (code)
            {
                case "RU":
                    return new RuDeviceFactory();

                case "EN":
                    return new EnDeviceFactory();
                    
                default: throw new Exception("Unsupported country code: " + code);
            }
        }
    }
}
