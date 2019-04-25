using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string keepRun = "y";

            while (keepRun == "y")
            {
                Console.WriteLine("How many sides would you like on these pair of dice? ");
                int user = int.Parse(Console.ReadLine());


                if (user >= 4)
                {
                    Console.WriteLine("Here are your results: ");

                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine(RollDice(user));
                    }
                }
                else
                {
                    Console.WriteLine("That's not possible..");
                }

                Console.WriteLine("Would you like to keep playing? y or n");
                keepRun = Console.ReadLine();
            }

        }

            public static int RollDice(int num)
            {
                Random sides = new Random();
                int roll;
                return roll = sides.Next(1, num + 1);
            }
        
    }
}

