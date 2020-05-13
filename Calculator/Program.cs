using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Num1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Operator: ");
                string op = Console.ReadLine();

                Console.Write("Enter Num2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (op == "+")
                {
                    Console.WriteLine(num1 + num2);
                }
                else if (op == "-")
                {
                    Console.WriteLine(num1 - num2);
                }
                else if (op == "*")
                {
                    Console.WriteLine(num1 * num2);
                }
                else if (op == "/")
                {
                    Console.WriteLine(num1 / num2);
                }
                else if (op == "%")
                {
                    Console.WriteLine(num1 % num2);
                }
                else
                {
                    Console.WriteLine("Invalid Operator");
                }


            }
            catch (Exception)
            {
                Console.WriteLine(" Enter a valid whole number");

            }
            finally
            {
                Console.WriteLine("Try again");
            }
           



            Console.ReadLine();

        }
    }
}
