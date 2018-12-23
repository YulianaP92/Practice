using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P15_25While_OddEventNumber
    {
        public static void While_OddEventNumber()
        {
            var i = 1;
            while (i <= 10)
            {
                if (i % 2 == 0)
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
