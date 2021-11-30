using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBasedAssignment3
{
    internal class WhileLoop
    {
        static void Main()
        {
            Console.Write("Enter Last Number = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i<=n)
            {
                Console.Write($"{i} ");
                i++;
            }           
            Console.ReadLine();
        }
    }
}
