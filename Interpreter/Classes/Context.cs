using System;
using Interpreter.Interfaces;
namespace Interpreter.Classes
{
    sealed class Context
    {
        public IExpression Evaluate(string s)
        {
            int pos = s.Length - 1;
            while (pos > 0)
            {
                if (char.IsDigit(s[pos]))
                {
                    pos--;
                }
                else
                {
                    IExpression left = Evaluate(s.Substring(0, pos));
                    IExpression right = new NumberExpression(int.Parse(s.Substring(pos + 1)));
                    var operation = s[pos];
                    switch (operation)
                    {
                        case '-':
                            return new MinusExpression(left, right);

                        case '+':
                            return new PlusExpression(left, right);
                    }
                }
            }
            int result = int.Parse(s);
            return new NumberExpression(result);
        }
    }
}