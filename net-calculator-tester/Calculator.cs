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

        public float Divide(float num1, float num2)
        {
            if(num2 <= 0)
            {
                throw new Exception("Il divisore non puo essere uguale o minore di zero");
            }
            return num1 / num2;
        }

        public float Multiply(float num1, float num2)
        {
            if(num1 == 0 ||  num2 == 0)
            {
                throw new Exception("Uno dei due valori è uguale a zero");
            }
            return num1 * num2;
        }
    }
}
