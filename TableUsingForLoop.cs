using System;

namespace LabBasedAssignment3
{
    internal class TableUsingForLoop
    {
        static void Main()
        {
            Console.Write("Table of which Number = ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number of Lines = ");
            int l=Convert.ToInt32(Console.ReadLine());

            for (int i=1;i<=l;i++)
                Console.WriteLine($"{n} x {i} = {n * i}");
            Console.ReadLine();
        }
    }
}
