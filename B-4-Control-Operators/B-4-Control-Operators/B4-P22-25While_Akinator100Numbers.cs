using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P22_25While_Akinator100Numbers
    {
        public static void While_Akinator100Numbers()
        {
            var number = 0;
            Console.WriteLine("Загадайте число от 0 до 100 ");
            var value = Int32.Parse(Console.ReadLine());
            
            if (number!= value)
            {
                Console.WriteLine("Ты загадал число ...");
                number = Int32.Parse(Console.ReadLine());               
                while (number < value)
                {
                    Console.WriteLine("Нет, я загадал число больше");
                    number = Int32.Parse(Console.ReadLine());
                }
                while (number > value)
                {
                    Console.WriteLine("Нет, я загадал число меньше");
                    number = Int32.Parse(Console.ReadLine());
                }
            }
            if (number==value)
            {
                Console.WriteLine("Ты отгадал!");
            }
        }
    }
}
