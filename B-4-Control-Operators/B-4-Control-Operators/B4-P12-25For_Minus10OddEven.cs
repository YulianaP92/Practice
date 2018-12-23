using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P12_25For_Minus10OddEven
    {
        public static void For_Minus10OddEven()
        {
            for (int i = 0; i <= 0 & i >= -10; i--)
            {
                var result = i % 2 == 0 ? "Четное" : "Нечетное";
                Console.WriteLine($"{i} - {result}");
            }
        }
    }
}
