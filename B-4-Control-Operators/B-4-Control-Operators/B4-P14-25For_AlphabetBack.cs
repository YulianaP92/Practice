using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P14_25For_AlphabetBack
    {
        public static void For_AlphabetBack()
        {
            for (int i = 90; i <= 90 & i >= 65; i--)
            {
                char x = (char)i;
                Console.Write(x + "\t");
            }
        }
    }
}
