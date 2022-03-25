using System;
using System.Collections.Generic;
using System.Text;

namespace domaci
{
    class DisplayDriver
    {
        public void Ispis(string operand1, string operand2, string znak, double rezultat)
        {
            Console.WriteLine("{0} {1} {2} = {3}", operand1, znak, operand2, rezultat);
        }
    }
}
