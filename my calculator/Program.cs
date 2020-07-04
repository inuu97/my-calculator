using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_calculator
{
    class myCal
    {
        static void Main(string[] args)
        {
            double firstnum;
            double secondnum;
            double answer;
            string operand;

            Console.WriteLine("Welcome to my calculator");

            Console.WriteLine("Enter number 1:");
            firstnum=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2:");
            secondnum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select an operator ( + , - , / , * )  ");
            Console.WriteLine("Enter the operator:");
            operand=Console.ReadLine();

            if (operand == "+")
            {
                answer = firstnum+ secondnum;
                Console.WriteLine(answer);
            }
            if (operand == "-")
            {
                answer = firstnum - secondnum;
                Console.WriteLine(answer);
            }
            if (operand == "/")
            {
                answer = firstnum / secondnum;
                Console.WriteLine(answer);
            }
            if (operand == "*")
            {
                answer = firstnum * secondnum;
                Console.WriteLine(answer);
            }
            Console.ReadLine();
        }
    }
}
