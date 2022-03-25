using System;
using System.Globalization;

namespace domaci
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Calculator calc = new Calculator();
            string unos = calc.Unesi();
            string[] operandi = calc.Parsiraj1(unos);
            string operand1 = operandi[0];
            string operand2 = operandi[1];
            string operacija = calc.Operacija(unos);
            double rezultat = 0;
            double op1, op2;
            bool greska = false;
            if (Double.TryParse(operand1, out op1))
            {
                op1 = Double.Parse(operand1);
            }
            else
            {
                Console.WriteLine("Pogresno unet prvi operand");
                greska = true;
            }
            if (Double.TryParse(operand2, out op2))
            {
                op2 = Double.Parse(operand2);
            }
            else
            {
                Console.WriteLine("Pogresno unet drugi operand");
                greska = true;
            }

            switch (operacija)
            {
                case "+":
                    rezultat = calc.Plus(op1, op2);
                    break;
                case "-":
                    rezultat = calc.Minus(op1, op2);
                    break;
                case "*":
                    rezultat = calc.Puta(op1, op2);
                    break;
                case "/":
                    rezultat = calc.Podeljeno(op1, op2);
                    break;
                case "greska":
                    greska = true;
                    break;
                default:
                    Console.WriteLine("Greska");
                    greska = true;
                    break;
            }
            if(!greska) { 
                Console.WriteLine("Rezultat je: {0}", rezultat);
                calc.prikaz.Ispis(operand1, operand2, operacija, rezultat);
            }
            else
            {
                Console.WriteLine("---Rezultat: Doslo je do greske.");
            }
            
            /*/
            //////////////////////////////////////
            ///
            /// 
            ScientificCalculator sciCalc = new ScientificCalculator();
            string unos1 = sciCalc.Unesi();
           
        //    string[] operandi1 = sciCalc.Parsiraj1(unos1);
        //    string operand11 = operandi1[0];
         //   string operand12 = operandi1[1];
            string operacija1 = sciCalc.Operacija(unos1);
            double rezultat1 = 0;
            double op11, op12;
            bool greska1 = false;
            //    if (Double.TryParse(operand11, out op11))
            //   {
            //       op11 = Double.Parse(operand11);
            //  }
            //   else
            //{
            //    Console.WriteLine("Pogresno unet prvi operand");
            //    greska1 = true;
            //}
            //if (Double.TryParse(operand12, out op12))
            //{
            //    op12 = Double.Parse(operand12);
            //}
            //else
            //{
            //    Console.WriteLine("Pogresno unet drugi operand");
            //    greska1 = true;
            //}
            string operand11;
            string operand12; 
            switch (operacija1)
            {
                case "+":
                    string[] operandi1 = sciCalc.Parsiraj1(unos1);
                    operand11 = operandi1[0];
                    operand12 = operandi1[1];
                    if (Double.TryParse(operand11, NumberStyles.Any, CultureInfo.InvariantCulture, out op11))           //nece da parsira -2, baca gresku
                    {
                        op11 = double.Parse(operand11);
                    }
                    else
                    {
                        Console.WriteLine("Pogresno unet prvi operand");
                        greska1 = true;
                    }
                    if (double.TryParse(operand12, out op12))
                    {
                        op12 = double.Parse(operand12);
                    }
                    else
                    {
                        Console.WriteLine("Pogresno unet drugi operand");
                        greska1 = true;
                    }
                    rezultat1 = sciCalc.Plus(op11, op12);

                    if (!greska1)
                        sciCalc.sciDisp.Ispis(operand11, operacija1, rezultat1, operand12);
                    else
                        Console.WriteLine("Doslo je do greske");


                    break;

                case "-":
                    operandi1 = sciCalc.Parsiraj1(unos1);
                    operand11 = operandi1[0];
                    operand12 = operandi1[1];
                    if (Double.TryParse(operand11, out op11))
                    {
                        op11 = double.Parse(operand11);
                    }
                    else
                    {
                        Console.WriteLine("Pogresno unet prvi operand");
                        greska1 = true;
                    }
                    if (double.TryParse(operand12, out op12))
                    {
                        op12 = double.Parse(operand12);
                    }
                    else
                    {
                        Console.WriteLine("Pogresno unet drugi operand");
                        greska1 = true;
                    }
                    rezultat1 = sciCalc.Minus(op11, op12);
                    if (!greska1)
                        sciCalc.sciDisp.Ispis(operand11, operacija1, rezultat1, operand12);
                    else
                        Console.WriteLine("Doslo je do greske");
                    break;
                case "*":
                    operandi1 = sciCalc.Parsiraj1(unos1);
                    operand11 = operandi1[0];
                    operand12 = operandi1[1];
                    if (Double.TryParse(operand11, out op11))
                    {
                        op11 = double.Parse(operand11);
                    }
                    else
                    {
                        Console.WriteLine("Pogresno unet prvi operand");
                        greska1 = true;
                    }
                    if (double.TryParse(operand12, out op12))
                    {
                        op12 = double.Parse(operand12);
                    }
                    else
                    {
                        Console.WriteLine("Pogresno unet drugi operand");
                        greska1 = true;
                    }
                    rezultat1 = sciCalc.Puta(op11, op12);
                    if (!greska1)
                        sciCalc.sciDisp.Ispis(operand11, operacija1, rezultat1, operand12);
                    else
                        Console.WriteLine("Doslo je do greske");
                    break;

                case "/":
                    operandi1 = sciCalc.Parsiraj1(unos1);
                    operand11 = operandi1[0];
                    operand12 = operandi1[1];
                    if (Double.TryParse(operand11, out op11))
                    {
                        op11 = double.Parse(operand11);
                    }
                    else
                    {
                        Console.WriteLine("Pogresno unet prvi operand");
                        greska1 = true;
                    }
                    if (double.TryParse(operand12, out op12))
                    {
                        op12 = double.Parse(operand12);
                    }
                    else
                    {
                        Console.WriteLine("Pogresno unet drugi operand");
                        greska1 = true;
                    }
                    rezultat1 = sciCalc.Podeljeno(op11, op12);
                    if (!greska1)
                        sciCalc.sciDisp.Ispis(operand11, operacija1, rezultat1, operand12);
                    else
                        Console.WriteLine("Doslo je do greske");
                    break;


                case "sqrt":
                    operandi1 = sciCalc.Parsiraj1(unos1);
                    operand11 = operandi1[0];
                    //operand12 = operandi1[1];
                    if (Double.TryParse(operand11, out op11))
                    {
                        op11 = double.Parse(operand11);
                    }
                    else
                    {
                        Console.WriteLine("Pogresno unet prvi operand");
                        greska1 = true;
                    }
                    rezultat1 = sciCalc.Square(op11);
                    if (!greska1)
                        sciCalc.sciDisp.Ispis(operand11, operacija1, rezultat1);
                    else
                        Console.WriteLine("Doslo je do greske");
                    break;
                
                case "root":
                    operandi1 = sciCalc.Parsiraj1(unos1);
                    operand11 = operandi1[0];
                    if (Double.TryParse(operand11, out op11))
                    {
                        op11 = double.Parse(operand11);
                    }
                    else
                    {
                        Console.WriteLine("Pogresno unet prvi operand");
                        greska1 = true;
                    }
                    rezultat1 = sciCalc.SquareRoot(op11);
                    if (!greska1)
                        sciCalc.sciDisp.Ispis(operand11, operacija1, rezultat1);
                    else
                        Console.WriteLine("Doslo je do greske");
                    break;
               
                case "abs":
                    operandi1 = sciCalc.Parsiraj1(unos1);
                    operand11 = operandi1[0];
                    if (Double.TryParse(operand11, out op11))
                    {
                        op11 = double.Parse(operand11);
                    }
                    else
                    {
                        Console.WriteLine("Pogresno unet prvi operand");
                        greska1 = true;
                    }
                   
                    rezultat1 = sciCalc.AbsoluteValue(op11);
                    if (!greska1)
                        sciCalc.sciDisp.Ispis(operand11, operacija1, rezultat1);
                    else
                        Console.WriteLine("Doslo je do greske");
                    break;
                
                case "^":
                    operandi1 = sciCalc.Parsiraj1(unos1);
                    operand11 = operandi1[0];
                    operand12 = operandi1[1];
                    if (Double.TryParse(operand11, out op11))
                    {
                        op11 = double.Parse(operand11);
                    }
                    else
                    {
                        Console.WriteLine("Pogresno unet prvi operand");
                        greska1 = true;
                    }
                    if (double.TryParse(operand12, out op12))
                    {
                        op12 = double.Parse(operand12);
                    }
                    else
                    {
                        Console.WriteLine("Pogresno unet drugi operand");
                        greska1 = true;
                    }

                    rezultat1 = sciCalc.Power(op11, op12);
                    if (!greska1)
                        sciCalc.sciDisp.Ispis(operand11, operacija1, rezultat1, operand12);
                    else
                        Console.WriteLine("Doslo je do greske");
                    break;

                case "greska":
                    greska1 = true;
                    Console.WriteLine("Greska u operandu");
                    break;

                default:
                    Console.WriteLine("Greska");
                    greska1 = true;
                    break;
            } 

            

        }
    }

    
}
