using Decorator.Interfaces;

namespace Decorator
{
    sealed class LeftBracketDecorator : IPrinter
    {
        IPrinter component;

        public LeftBracketDecorator(IPrinter component)
        {
            this.component = component;
        }

        public void Print()
        {
            System.Console.WriteLine("[");
            component.Print();
        }
    }
}