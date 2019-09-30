using Decorator.Interfaces;

namespace Decorator
{
    sealed class Printer : IPrinter
    {
        string value;

        public Printer(string value)
        {
            this.value = value;
        }

        public void Print()
        {
            System.Console.Write(value);
        }
    }
}