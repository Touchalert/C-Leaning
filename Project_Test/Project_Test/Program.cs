using System;

namespace Project_Test
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string x ;
            double sum,num=0;

            Console.WriteLine("Input Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Input Number: ");
            x = Console.ReadLine();
            sum = Convert.ToDouble(x);

            do
            {
                Console.WriteLine("Input Operator : ");
                x = Console.ReadLine();
                if (x != "+" && x != "-" && x != "*" && x != "/" && x != "=")
                {
                    num = Convert.ToDouble(x);
                }

                if (x == "+")
                {       
                    Console.WriteLine("Input Number: ");
                    x = Console.ReadLine();
                    if (x != "+" && x != "-" && x != "*" && x != "/" && x != "=")
                    {
                        num = Convert.ToDouble(x);
                    }sum += num;
                }
                else if (x == "-")
                {
                    Console.WriteLine("Input Number: ");
                    x = Console.ReadLine();
                    if (x != "+" && x != "-" && x != "*" && x != "/" && x != "=")
                    {
                        num = Convert.ToDouble(x);
                    }sum -= num;
                }
                else if (x == "*")
                {
                    Console.WriteLine("Input Number: ");
                    x = Console.ReadLine();
                    if (x != "+" && x != "-" && x != "*" && x != "/" && x != "=")
                    {
                        num = Convert.ToDouble(x);
                    }sum *= num;
                }
                else if (x == "/")
                {
                    Console.WriteLine("Input Number: ");
                    x = Console.ReadLine();
                    if (x != "+" && x != "-" && x != "*" && x != "/" && x != "=")
                    {
                        num = Convert.ToDouble(x);
                    }sum /= num;
                }
                

            } while(x != "=");

            Console.WriteLine("Output");
            Console.WriteLine("name : " + name);
            Console.WriteLine("Sum : " + sum);

        }
    }
}
