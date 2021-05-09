using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExamples.DelegateS
{
    public class FourOperations
    {
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
        public int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }
        public int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
        public int Extraction(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
