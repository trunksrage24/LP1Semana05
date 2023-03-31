using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            //create dices
            Console.WriteLine("insert number of dices: ");
            int DiceNumber = int.Parse(Console.ReadLine());

            //declare int to sum rolls
            int Sum = 0;

            //random roll dice
            Random random = new Random();
            for (int i = 0; i < DiceNumber; i++)
            {
                int Roll = random.Next(1,7);
                //print dices and result
                Console.WriteLine("rolled " + (i+1) + ":" + Roll);
                //sum all rolls
                Sum += Roll;
            }

            //print sum
            Console.WriteLine("sum of all dices is = " + Sum);
        }
    }
}
