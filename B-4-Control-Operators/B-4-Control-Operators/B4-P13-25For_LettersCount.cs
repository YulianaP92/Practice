using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P13_25For_LettersCount
    {
        public static void For_LettersCount()
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();
            int count = 0;
            foreach (var i in word)
            {
                if (i == 'а')
                {
                    count++;
                }
            }
            Console.WriteLine($"В слове '{word}' {count} 'a'");
        }
    }
}
