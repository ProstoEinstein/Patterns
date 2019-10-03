using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes.Device.EnDevice
{
    sealed class EnKeyboard : IKeyboard
    {
        public void Print()
        {
            System.Console.Write("Print");
        }

        public void Println()
        {
            System.Console.WriteLine("Print line");
        }
    }
}