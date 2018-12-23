using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P1_25If_TimeOfDayGreeting
    {
        public static void If_TimeOfDayGreeting()
        {
            if (DateTime.Now.Hour < 12 && DateTime.Now.Hour > 4)
                Console.WriteLine("Доброе утро, Ольга");
            else if (DateTime.Now.Hour < 18 & DateTime.Now.Hour > 12)
                Console.WriteLine("Доброе дня, Ольга");
            else if (DateTime.Now.Hour > 18 & DateTime.Now.Hour < 0)
                Console.WriteLine("Добрый вечер, Ольга");
        }
    }
}
