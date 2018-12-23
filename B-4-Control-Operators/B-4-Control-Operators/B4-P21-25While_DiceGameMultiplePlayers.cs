using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P21_25While_DiceGameMultiplePlayers
    {
        public static void While_DiceGameMultiplePlayers()
        {
            var number_1 = 0;
            var number_2 = 0;
            var start_1 = 0;
            var start_2 = 0;
            var finish = 25;

            while (start_1 != finish | start_2 != finish)
            {
                if (start_1 < finish)
                {
                    Console.WriteLine("Первый игрок введите число от 1 до 6: ");
                    number_1 = Int32.Parse(Console.ReadLine());
                    start_1 += number_1;

                    if (start_1 > finish)
                    {
                        start_1 -= finish;
                    }
                    Console.WriteLine($"{start_1} очков");
                }
                if (start_2 < finish)
                {
                    Console.WriteLine("Второй игрок введите число от 1 до 6: ");
                    number_2 = Int32.Parse(Console.ReadLine());
                    start_2 += number_2;

                    if (start_2 > finish)
                    {
                        start_2 -= finish;
                    }
                    Console.WriteLine($"{start_2} очков");
                }
            }
            Console.WriteLine("Игра окончена");
        }
    }
}
