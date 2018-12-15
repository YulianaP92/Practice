using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P18_25While_Multiplier
    {
        public static void While_Multiplier()
        {
            Console.WriteLine("Введите число: ");
            var number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень: ");
            var pow = Int32.Parse(Console.ReadLine());
            var count = 1;
            var x = 1;
            while (count <= pow)
            {
                x *= number;
                count++;
            }
            Console.WriteLine(x);
        }
    }
}
