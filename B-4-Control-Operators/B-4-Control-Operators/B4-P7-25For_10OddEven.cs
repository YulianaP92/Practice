using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P7_25For_10OddEven
    {
        public static void For_10OddEven()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"{i} четное");
                else
                    Console.WriteLine($"{i} нечетное");
            }
        }
    }
}
