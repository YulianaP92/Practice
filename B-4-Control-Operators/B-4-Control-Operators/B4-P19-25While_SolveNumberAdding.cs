using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P19_25While_SolveNumberAdding
    {
        public static void While_SolveNumberAdding()
        {
            var x = 2 + 2;
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("Решите уравнение 2+2 ");
                Console.Write("Результат: ");
                var result = Int32.Parse(Console.ReadLine());
                if (result == x)
                {
                    flag = true;
                    Console.WriteLine("Правильно!");
                }
            }
        }
    }
}
