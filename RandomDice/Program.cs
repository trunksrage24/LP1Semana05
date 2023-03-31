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

            //random roll dice
            Random random = new Random();
            for (int i = 0; i < DiceNumber; i++)
            {
                int Roll = random.Next(1,7);
                //print dices and result
                Console.WriteLine("rolled " + (i+1) + ":" + Roll);
            }
        }
    }
}
