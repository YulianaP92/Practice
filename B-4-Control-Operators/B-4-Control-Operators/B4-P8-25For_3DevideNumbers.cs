using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P8_25For_3DevideNumbers
    {
        public static void For_3DevideNumbers()
        {
            for (int i = 30; i > 0; i--)
            {
                if (i%3==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
