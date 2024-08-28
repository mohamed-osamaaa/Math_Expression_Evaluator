using Math_Expression_Evaluator.Math_Expression_Evaluator;
using System;

namespace Math_Expression_Evaluator.Math_Expression_Evaluator
{
    public class App
    {
        public static void Run(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter math expression: ");
                var input = Console.ReadLine();
                var expr = ExpressionParser.Parse(input);
                Console.WriteLine($"Left Side = {expr.LeftSideOperand}, Operation = {expr.Operation}, Right Side = {expr.RightSideOperand}");
                Console.WriteLine($"{input.Trim()} = {EvaluateExpression(expr)}");
            }
        }

        private static object EvaluateExpression(MathExpression expr)
        {
            if (expr.Operation == MathOperation.Addition)
                return expr.LeftSideOperand + expr.RightSideOperand;
            else if (expr.Operation == MathOperation.Subtraction)
                return expr.LeftSideOperand - expr.RightSideOperand;
            else if (expr.Operation == MathOperation.Multiplication)
                return expr.LeftSideOperand * expr.RightSideOperand;
            else if (expr.Operation == MathOperation.Dividion)
                return expr.LeftSideOperand / expr.RightSideOperand;
            else if (expr.Operation == MathOperation.Modulus)
                return expr.LeftSideOperand % expr.RightSideOperand;
            else if (expr.Operation == MathOperation.Power)
                return Math.Pow(expr.LeftSideOperand, expr.RightSideOperand);
            else if (expr.Operation == MathOperation.Sin)
                return Math.Sin(expr.RightSideOperand);
            else if (expr.Operation == MathOperation.Cos)
                return Math.Cos(expr.RightSideOperand);
            else if (expr.Operation == MathOperation.Tan)
                return Math.Tan(expr.RightSideOperand);
            return 0;
        }
    }
}