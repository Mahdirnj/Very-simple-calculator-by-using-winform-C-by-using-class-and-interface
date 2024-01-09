using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalClass : Calinterface
    {
        public float Divide(float num1, float num2)
        {
          float Diveide = num1 / num2;
            return Diveide;
        }

        public int Minus(int num1, int num2)
        {
            int minus = num1 - num2;
            return minus;
        }

        public int Myltiple(int num1, int num2)
        {
            int multi = num1 * num2;
            return multi;
        }

        public int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum; 
        }
    }
}
