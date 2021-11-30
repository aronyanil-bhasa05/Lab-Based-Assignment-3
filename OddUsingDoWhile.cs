using System;

namespace LabBasedAssignment3
{
    //Display all odds from nth to 1
    internal class OddUsingDoWhile
    {
        static void Main()
        {
            Console.Write("Enter Last Number = ");
            int n = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (n % 2 != 0)
                    Console.Write($"{n} ");
                n--;
            }
            while (n >= 2);
            Console.ReadLine();
        }
    }
}
