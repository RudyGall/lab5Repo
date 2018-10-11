using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fActorials
{
    class Program
    {
        static void Main(string[] args)
        {
            char doAgain;
            bool runP = true;

            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();

            while (runP == true)
            {
                int i, number;
                long factorial;
                Console.WriteLine("{0}, Please enter an integer between 1 and 10", firstName);
                number = int.Parse(Console.ReadLine());
                factorial = number;
                for (i = number - 1; i >= 1; i--)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine("\nThe factorial of {0} is: " + factorial, number);
                Console.WriteLine("{0}, Would you like to run the application again? (Y or N)", firstName);

                doAgain = Convert.ToChar(Console.ReadLine());

                if (doAgain == 'n' || doAgain == 'N')
                {
                    runP = false;
                }
                else if (doAgain == 'y' || doAgain == 'Y')
                {
                    runP = true;
                }
                else
                    Console.WriteLine("Invalid entry, try again");
            }
        }
    }
}