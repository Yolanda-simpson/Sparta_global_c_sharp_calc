using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;

            int num2 = 0;

            float answer = 0.0f;





            Console.Write("Please enter the first number: ");
            //convert given input to integer 
            num1 = Convert.ToInt32(Console.ReadLine());

            // to add numbers together 
            Console.WriteLine("+");
        
            Console.Write("Please enter the second number: ");

            num2 = Convert.ToInt32(Console.ReadLine());

            {
                answer = num1 + num2;
                Console.WriteLine(num1 + " + " + num2 + " = " + answer);


                Console.ReadLine();
            }
        }
    }
}
