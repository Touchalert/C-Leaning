using System;

namespace Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do { 
            Console.WriteLine("Enter your base : ");
            string Input = Console.ReadLine();
            int baseNum;
            bool canConvert = int.TryParse(Input, out baseNum);
            while(canConvert==false)
            {
                Console.WriteLine("Enter your base : ");
                Input = Console.ReadLine();
                canConvert = int.TryParse(Input, out baseNum);
            }

            Console.WriteLine("Enter your power : ");
            Input = Console.ReadLine();
            int power;
            canConvert = int.TryParse(Input, out power);
            while (canConvert == false)
            {
                Console.WriteLine("Enter your power : ");
                Input = Console.ReadLine();
                canConvert = int.TryParse(Input, out power);
            }
            int total = baseNum;
            for (int i = 1; i < power; i++)
            {
                total = total*baseNum;
            }
            if (power == 0)
            {
                total = 1;
            }
                Console.WriteLine("Total : " + total);

                Console.WriteLine("\nPress 'Y' to replay, Any other to Exit ");
                choice = Console.ReadLine();
            } while (choice == "Y" || choice == "y");
            
        }
    }
}
