using System;
using System.Collections.Generic;
using System.Text;

namespace domaci
{
    class ScientificDisplayDriver: DisplayDriver
    {
        public void Ispis(string operand1, string znak, double rezultat, string operand2 = "")
        {
            if (znak == "abs")
            {
                Console.WriteLine("|{0}| = {1}", operand1, rezultat);
            } else if(znak == "sqrt")
            {
                Console.WriteLine("sqrt {0} = {1}", operand1, rezultat);
            }else if(znak == "root")
            {
                Console.WriteLine("root{0} = {1}", operand1, rezultat);
            }
            else
            {
                Console.WriteLine("{0} {1} {2} = {3}", operand1, znak, operand2, rezultat);
            }
        }
    }
}
