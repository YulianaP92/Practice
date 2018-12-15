using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class B4_P25_25Cycle_WordRevercse
    {
        public static void Cycle_WordRevercse()
        {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            foreach (var i in word.Reverse())
            {
                Console.Write(i);
            }
        }
    }
}
