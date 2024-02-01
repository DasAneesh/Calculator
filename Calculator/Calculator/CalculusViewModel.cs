using Calculator_Parser;
using System;
using System.Collections.Generic;

namespace Calculator
{
    public class CalculusViewModel
    {
        A_Parser parser;
        Calculator_E calculator;
       

        public CalculusViewModel()
        {
            parser = new A_Parser();
            calculator = new Calculator_E();
        }


        public string Evaluate(string equation)
        {
            List<string> parsed = parser.Parse(equation.Split(' '));
            return Convert.ToString(calculator.Evaluate(parsed.ToArray()));

        }
    }
}
