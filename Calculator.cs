using System;
using System.Collections.Generic;
using System.Text;

namespace domaci
{
    class Calculator
    {
        public DisplayDriver prikaz = new DisplayDriver();
        public double Plus(double x, double y)
        {
            return x + y;
        }
        public double Minus(double x, double y)
        {
            return x - y;
        }
        public double Puta(double x, double y)
        {
            return x * y;
        }
        public double Podeljeno(double x, double y)
        {
            return x / y;
        }
        public string Unesi()
        {
            Console.WriteLine("Unesite izraz. Podrzane operacije su: +, -, *, x, /, :, abs, sqrt, root, ^");
            string unos = Console.ReadLine();
            return unos;
        }
        public string[] Parsiraj1(string unos)
        {
            unos = unos.Trim();
            string[] operandi = {"", ""};
            if (unos.Contains('+') || unos.Contains('-') || unos.Contains('*') || unos.Contains('/') || unos.Contains('x') || unos.Contains(':') || unos.Contains('X')) {
                operandi = unos.Split('+', '-', '*', '/', 'x', ':', 'X');
                return operandi;
            }
            else
            {
                Console.WriteLine("Nedostaje operand");
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
            else
            {
                return "greska";
            }
        }
    }
}
