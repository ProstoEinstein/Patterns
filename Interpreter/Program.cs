using System;
using Interpreter.Classes;
using Interpreter.Interfaces;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            IExpression expr = context.Evaluate("1+2+3");
            System.Console.WriteLine(expr.Interpret());
        }
    }
}
