using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P4_25If_Akinator5Numbers
    {
        public static void If_Akinator5Numbers()
        {
            Console.WriteLine("Загадайте число от 1 до 5 ");
            Console.WriteLine("Ваше число четное? (True/False)");
            bool answer = Boolean.Parse(Console.ReadLine());
            if (answer)
            {
                Console.WriteLine("Ваше число >2? (True/False)");
                bool answer_2 = Boolean.Parse(Console.ReadLine());
                if (answer_2)
                    Console.WriteLine("Ваше число 5");
                else
                    Console.WriteLine("Ваше число 2");
            }
            else
            {
                Console.WriteLine("Ваше число >3? (True/False)");
                bool answer_2 = Boolean.Parse(Console.ReadLine());
                if (answer_2)
                    Console.WriteLine("Ваше число 5");
                else
                {
                    Console.WriteLine("Ваше число <3? (True/False)");
                    bool answer_3 = Boolean.Parse(Console.ReadLine());
                    if (answer_3)
                        Console.WriteLine("Ваше число 1");
                    else
                        Console.WriteLine("Ваше число 3");
                }
            }
        }
    }
}
