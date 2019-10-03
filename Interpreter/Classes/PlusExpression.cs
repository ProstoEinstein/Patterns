using Interpreter.Interfaces;

namespace Interpreter.Classes
{
    sealed class PlusExpression : IExpression
    {
        IExpression left;
        IExpression right;

        public PlusExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public int Interpret()
        {
            return left.Interpret() + right.Interpret();;
        }
    }
}