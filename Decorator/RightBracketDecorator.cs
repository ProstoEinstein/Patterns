using Decorator.Interfaces;

namespace Decorator
{
    sealed class RightBracketDecorator : IPrinter
    {
        IPrinter component;

        public RightBracketDecorator(IPrinter component)
        {
            this.component = component;
        }

        public void Print()
        {
            component.Print();
            System.Console.Write("]");
        }
    }
}