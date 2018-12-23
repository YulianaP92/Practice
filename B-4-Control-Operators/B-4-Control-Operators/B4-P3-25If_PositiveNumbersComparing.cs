using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P3_25If_PositiveNumbersComparing
    {
        public static void If_PositiveNumbersComparing()
        {
            int x, y;
            Console.Write("Enter the number 1: ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the number 2: ");
            y = Int32.Parse(Console.ReadLine());
            if (x >= 0 & y >= 0)
            {
                if (x == y)
                    Console.WriteLine("Values are equal");
                else if (x > y)
                    Console.WriteLine($"{x}>{y} on {x - y}");
                else
                    Console.WriteLine($"{x}<{y} on {y - x}");
            }
            else
            {
                Console.WriteLine("Only numbers are compared > оr == 0");
            }
        }
    }
}
