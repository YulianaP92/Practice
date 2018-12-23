using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P6_25Switch_GameNavigation
    {
        public static void Switch_GameNavigation()
        {
            var ch = Console.ReadKey();
            switch (ch.KeyChar)
            {
                case 'w':
                case 'W':
                    Console.WriteLine("Движение вверх");
                    break;
                case 's':
                case 'S':
                    Console.WriteLine("Движение вниз");
                    break;
                case 'a':
                case 'A':
                    Console.WriteLine("Движение вправо");
                    break;
                case 'd':
                case 'D':
                    Console.WriteLine("Движение влево");
                    break;
                default:
                    Console.WriteLine("Движение запрещено");
                    break;
            }
        }
    }
}
