using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface Calinterface
    {
        int Sum(int num1, int num2);
        int Minus(int num1 , int num2);
        float Divide(float num1, float num2);
        int Myltiple(int num1, int num2);
    }
}
