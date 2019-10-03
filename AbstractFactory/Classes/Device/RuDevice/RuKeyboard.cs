using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes.Device.RuDevice
{
    sealed class RuKeyboard : IKeyboard
    {
        public void Print()
        {
            System.Console.Write("Печатаем строку");
        }

        public void Println()
        {
            System.Console.WriteLine("Печатаем строку с переводом строки");
        }
    }
}