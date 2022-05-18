using System;

namespace Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string grade = "";
            int A=0, B=0, C=0, D=0, F=0,sum=0,average=0;
            Console.WriteLine("Input Total Student : ");
                string totalStudent = Console.ReadLine();
                int total = Convert.ToInt32(totalStudent);
            int[] numberStudent = new int[total];
            
            for (int i = 0; i < numberStudent.Length; i++)
            {
                Console.WriteLine("Input Name : ");
                string userName = Console.ReadLine();
                Console.WriteLine("Input Score : ");
                string input = Console.ReadLine();
                int score = Convert.ToInt32(input);

                if (score >= 80 && score <= 100)
                {
                    grade = "A";
                    A++;
                }
                else if (score >= 70 && score <= 79)
                {
                    grade = "B";
                    B++;
                }
                else if (score >= 60 && score <= 69)
                {
                    grade = "C";
                    C++;
                }
                else if (score >= 50 && score <= 59)
                {
                    grade = "D";
                    D++;
                }
                else if (score < 50 && score > 0)
                {
                    grade = "F";
                    F++;
                }
                Console.WriteLine("User : " + userName);
                Console.WriteLine("Score : " + score);
                Console.WriteLine("Grade : " + grade);
                sum += score;
                Console.WriteLine();
            }
            Console.WriteLine("Summary Grade\n");
            Console.WriteLine("Grade A : " + A);
            Console.WriteLine("Grade B : " + B);
            Console.WriteLine("Grade C : " + C);
            Console.WriteLine("Grade D : " + D);
            Console.WriteLine("Grade F : " + F);

            average = sum / total;
            Console.WriteLine("Total Score : " + sum);
            Console.WriteLine("Average : " + average);

        }
    }
}
