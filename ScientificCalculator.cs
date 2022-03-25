using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace domaci
{
    class ScientificCalculator : Calculator, IScientificCalculator
    {

        public ScientificDisplayDriver sciDisp = new ScientificDisplayDriver();

        public double Square(double x)
        {
            return x * x;
        }
        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }
        public double AbsoluteValue(double x)
        {
            if (x >= 0)
            {
                return x;
            }
            else
            {
                return -x;
            }
        }
        public double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public string[] Parsiraj1(string unos)
        {
            unos = unos.Trim();
            string[] operandi = {"",""};

            if (unos.Contains("abs"))
            {
                //operandi = Regex.Split(unos, "abs");              ovako ne moze, ne procita operand
                //operandi = Regex.Split(unos, "root");
                //operandi = Regex.Split(unos, "sqrt");
                operandi = unos.Split(new[] { "abs" }, StringSplitOptions.RemoveEmptyEntries);              //stackoverflow
                                                                                                            //.RemoveEmptyEntries znaci da ce ukloniti prazne substringove
                                                                                                            //.None znaci da ce ostaviti prazne substringove
                                                                                                            //ovo je overload metode Split
                return operandi;
            }
            else if (unos.Contains("ABS"))
            {
                operandi = unos.Split(new[] { "ABS" }, StringSplitOptions.RemoveEmptyEntries);
                return operandi;
            }
            else if (unos.Contains("root"))
            {
                operandi = unos.Split(new[] { "root" }, StringSplitOptions.RemoveEmptyEntries);
                return operandi;
            }
            else if (unos.Contains("ROOT"))
            {
                operandi = unos.Split(new[] { "ROOT" }, StringSplitOptions.RemoveEmptyEntries);
                return operandi;
            }
            else if (unos.Contains("sqrt"))
            {
                operandi = unos.Split(new[] { "sqrt" }, StringSplitOptions.RemoveEmptyEntries);
                return operandi;
            }
            else if (unos.Contains("SQRT"))
            {
                operandi = unos.Split(new[] { "SQRT" }, StringSplitOptions.RemoveEmptyEntries);
                return operandi;
            }



            else if (unos.Contains("+") || unos.Contains("-") || unos.Contains("*") || unos.Contains("x") || unos.Contains("/") || unos.Contains(":") || unos.Contains("^") || unos.Contains('X'))
            {
                operandi = unos.Split('+', '-', '*', '/', 'x', ':', '^', 'X');
                return operandi;
            }
            else
            {
                Console.WriteLine("Greska u operandu");
                return operandi;
            }    
        }

        public string Operacija(string unos)
        {
            if (unos.Contains('+'))
            {
                return "+";
            }
            else if (unos.Contains('-'))
            {
                return "-";
            }
            else if (unos.Contains('*') || unos.Contains('x') || unos.Contains('X'))
            {
                return "*";
            }
            else if (unos.Contains('/') || unos.Contains(':'))
            {
                return "/";
            }
            else if (unos.Contains("abs") || unos.Contains("ABS"))
            {
                return "abs";
            }
            else if (unos.Contains("sqrt") || unos.Contains("SQRT"))
            {
                return "sqrt";
            }
            else if (unos.Contains("root") || unos.Contains("ROOT"))
            {
                return "root";
            }
            else if (unos.Contains("^"))
            {
                return "^";
            }
            else
            {
                return "greska";
            }
        }

    }
}
