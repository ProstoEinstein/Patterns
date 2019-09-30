using Decorator.Interfaces;

namespace Decorator
{
    sealed class QuotesDecorator : IPrinter
    {
        IPrinter component;

        public QuotesDecorator(IPrinter component)
        {
            this.component = component;
        }

        public void Print()
        {
            System.Console.WriteLine("\"");
            component.Print();
            System.Console.WriteLine("\"");
        }
    }
}