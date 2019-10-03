using Interpreter.Interfaces;

namespace Interpreter.Classes
{
    sealed class NumberExpression : IExpression
    {
         int number;

        public NumberExpression(int number)
        {
            this.number = number;
        }

        public int Interpret()
        {
            return number;
        }
    }
}