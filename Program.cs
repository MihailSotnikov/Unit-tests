using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTests
{
    class Program
    {
        static void Main(string[] args) 
        {
                    
                Console.WriteLine("Enter First Number: ");
                double fNum;
                double.TryParse(Console.ReadLine(), out fNum);

                Console.WriteLine("Enter Operation (+,-,*,/,%): ");
                char oper;
                char.TryParse(Console.ReadLine(), out oper);

                Console.WriteLine("Enter Second Number: ");
                double sNum;
                double.TryParse(Console.ReadLine(), out sNum);

                Calculate calc = new Calculate();
                double result = 0;
                switch (oper)
                {
                    case '+':
                        calc.Add(fNum, sNum);
                        break;
                    case '-':
                        calc.Substract(fNum, sNum);
                        break;
                    case '*':
                        calc.Multiply(fNum, sNum);
                        break;
                    case '/':
                        calc.Divide(fNum, sNum);
                        break;
                case '%':
                    calc.Percent(fNum, sNum);
                    break;
            }
                Console.WriteLine("Your result is: " + result);

            }
        }

    }

