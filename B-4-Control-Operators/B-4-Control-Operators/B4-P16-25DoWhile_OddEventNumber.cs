using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P16_25DoWhile_OddEventNumber
    {
        public static void DoWhile_OddEventNumber()
        {
            var i = 1;
            do
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= 10);
        }
    }
}
