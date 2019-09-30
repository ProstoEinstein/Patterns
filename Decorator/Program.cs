using System;
using Decorator.Interfaces;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new QuotesDecorator(new LeftBracketDecorator(new RightBracketDecorator(new Printer("Hello world!"))));
            printer.Print();
        }
    }
}
