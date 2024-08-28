using Math_Expression_Evaluator.Math_Expression_Evaluator;
using System.Linq;

namespace Math_Expression_Evaluator.Math_Expression_Evaluator
{
    public static class ExpressionParser
    {
        private const string MathSymbols = "+*/%^";
        public static MathExpression Parse(string input)
        {
            input = input.Trim();
            var expr = new MathExpression();
            string token = "";
            bool LeftSideInitialized = false;
            for (var i = 0; i < input.Length; i++)
            {
                var CurrentChar = input[i];
                if (char.IsDigit(CurrentChar))
                {
                    token += CurrentChar;
                    if (i == input.Length - 1 && LeftSideInitialized)
                    {
                        expr.RightSideOperand = double.Parse(token);
                        break;
                    }
                }
                else if (MathSymbols.Contains(CurrentChar))
                {
                    if (!LeftSideInitialized)
                    {
                        expr.LeftSideOperand = double.Parse(token);
                        LeftSideInitialized = true;
                    }
                    expr.Operation = ParseMathOperation(CurrentChar.ToString());
                    token = "";
                }
                else if (CurrentChar == '-' && i > 0)
                {
                    if (expr.Operation == MathOperation.None)
                    {
                        expr.Operation = MathOperation.Subtraction;
                        expr.LeftSideOperand = double.Parse(token);
                        LeftSideInitialized = true;
                        token = "";
                    }
                    else
                        token += CurrentChar;
                }
                else if (char.IsLetter(CurrentChar))
                {
                    token += CurrentChar;
                    LeftSideInitialized = true;
                }
                else if (CurrentChar == ' ')
                {
                    if (!LeftSideInitialized)
                    {
                        expr.LeftSideOperand = double.Parse(token);
                        LeftSideInitialized = true;
                        token = " ";
                    }
                    else if (expr.Operation == MathOperation.None)
                    {
                        expr.Operation = ParseMathOperation(token);
                        token = "";
                    }
                }
                else
                    token += CurrentChar;
            }
            return expr;
        }

        private static MathOperation ParseMathOperation(string token)
        {
            switch (token.ToLower())
            {
                case "+":
                    return MathOperation.Addition;
                case "*":
                    return MathOperation.Multiplication;
                case "/":
                    return MathOperation.Dividion;
                case "%":
                case "mod":
                    return MathOperation.Modulus;
                case "^":
                case "pow":
                    return MathOperation.Power;
                case "sin":
                    return MathOperation.Sin;
                case "cos":
                    return MathOperation.Cos;
                case "tan":
                    return MathOperation.Tan;
                default:
                    return MathOperation.None;
            }
        }
    }
}