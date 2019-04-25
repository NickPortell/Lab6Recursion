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
            string keepRun = "y", test;
            int user;
            Random sides = new Random();

            while (keepRun == "y")
            {
                Console.WriteLine("How many sides would you like on these pair of dice? ");
                test = Console.ReadLine();
                bool notNum = int.TryParse(test, out user);


                if (notNum == false)
                {
                    Console.WriteLine("That is not a number..");
                }
                else
                {
                    if (user >= 4)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine(RollDice(user,sides));
                        }
                    }
                    else
                    {
                        Console.WriteLine("That's not a possible dice.");
                    }
                }

                Console.WriteLine("Would you like to keep playing? y or n");
                keepRun = Console.ReadLine();
            }

        }

        public static int RollDice(int num, Random sides)
        {
            int roll;
            return roll = sides.Next(1, num + 1);
        }
       
    }
}

