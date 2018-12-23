using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P20_25While_DiceGame
    {
        public static void While_DiceGame()
        {

            var number = 0;
            var start = 0;
            var finish = 25;
            while (start < finish)
            {
                Console.WriteLine("Введите число от 1 до 6: ");
                number = Int32.Parse(Console.ReadLine());
                start += number;

                if (start > finish)
                {
                    start -= finish;
                }
                Console.WriteLine($"{start} очков");
            }
            Console.WriteLine("Игра окончена");
        }
    }
}
