using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculator
{
    public class CalculatorOp
    {
       public int FirstNumber {  get; set; }
       public int SecondNumber { get; set; }

       public int result;

        public int Add()
        {
            result= FirstNumber + SecondNumber;
            return result;
        }

        public int Subtract()
        {
            result = FirstNumber - SecondNumber;
            return result;
        }

        public int Multiply()
        {
            result = FirstNumber * SecondNumber;
            return result;
        }

        public int Divide()
        {
            result = FirstNumber / SecondNumber;
            return result;
        }
    }
}
