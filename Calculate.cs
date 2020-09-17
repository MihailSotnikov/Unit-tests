using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTests
{
    public class Calculate
    {
        public double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
        public double Substract(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
        public double Multiply(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        public double Divide(double firstNum, double secondNum)
        {
            if (secondNum==0)
            {
                Console.WriteLine("Divide by zero is impossible!");
            }
            return firstNum / secondNum;
        }
        
        public double Percent(double firstNum, double secondNum)
        {
            return (firstNum / secondNum)*100;
        }
    }
}

