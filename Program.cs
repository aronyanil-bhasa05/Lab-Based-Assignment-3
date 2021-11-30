using System;

namespace LabBasedAssignment3
{
    //Print in descending order from n th number to 1
    class ForLoop
    {
        static void Main()
        {
            Console.Write("Enter Last Number = ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i >= 1; i--)
                Console.Write($"{i} ");
            Console.ReadLine();
        }
    }
}
