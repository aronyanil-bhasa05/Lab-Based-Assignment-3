using System;

namespace LabBasedAssignment3
{
    internal class EvenInArray
    {
        static void Main()
        {
            Console.Write("ENTER ARRAY SIZE = ");
            int n= Convert.ToInt32(Console.ReadLine());
            int [] arr =new int [n];
            int c = 0;
            Console.WriteLine("ENTER ARRAY ELEMENTS BELOW");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter Element Number {i + 1}");
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] !=0 && arr[i] != 1 && arr[i] % 2 == 0)
                {
                    Console.Write ($"{arr[i]} ");
                    c++;
                }
            }
            Console.WriteLine($"\n{c} number of even elements found");
            Console.ReadLine();
        }
    }
}
