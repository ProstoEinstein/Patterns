using Interpreter.Interfaces;

namespace Interpreter.Classes
{
    sealed class MinusExpression : IExpression
    {
        IExpression left;
        IExpression right;

        public MinusExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public int Interpret()
        {
            return left.Interpret() - right.Interpret();;
        }
    }
}