using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Parser
{
    public class Calculator_E
    {




        string[] openBrackets = { "(", "[", "{" };
        string[] closeBrackets = {")", "]", "}"};
        string[] operators = { "+", "-", "/", "*" };


        bool IsCorrectBrackets(string[] equation)
        {
            Stack<string> brackets = new Stack<string>();
            string[] copy = equation;

            for (int i = 0; i < copy.Length; i++)
            {
                if (openBrackets.Contains(copy[i]))
                {
                    copy[i] = openBrackets[0];
                }
                if (closeBrackets.Contains(copy[i]))
                {
                    copy[i] = closeBrackets[0];
                }
            }

            foreach (var token in copy)
            {
                if (token == "(")
                {
                    brackets.Push(token);
                }
                else if (token == ")")
                {
                    if (brackets.Count == 0) { return false; }
                    brackets.Pop();
                }
            }
            return brackets.Count == 0;
        }

        public double Evaluate(string[] equation)
        {
            double a;
            double b;
            Stack<double> values = new Stack<double>();
            foreach (var token in equation)
            {
                if (!operators.Contains(token))
                {
                    values.Push(double.Parse(token));
                }
                else
                {
                    switch (token)
                    {
                        case "+":
                            a = values.Pop();
                            b = values.Pop();
                            values.Push(a + b);
                            break;

                        case "-":
                            a = values.Pop();
                            b = values.Pop();
                            values.Push(a - b);
                            break;

                        case "*":
                            a = values.Pop();
                            b = values.Pop();
                            values.Push(a * b);
                            break;

                        case "/":
                            a = values.Pop();
                            b = values.Pop();
                            values.Push(a / b);
                            break;
                    }
                }
            }
            return values.Peek();
        }
    }
}
