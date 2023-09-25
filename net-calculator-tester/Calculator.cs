using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public class Calculator
    {
        
        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public float Substract(float num1, float num2)
        {
            if(num1 < num2)
            {
                return num2 - num1;
            }

            return num1 - num2;
        }
    }
}
