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
            Console.WriteLine("Ваше число однозначное? (True/False)");
            bool answer_2 = Boolean.Parse(Console.ReadLine());
            if (answer_2)
            {
                Console.WriteLine("Ваше число четное? (True/False)");
                bool answer_3 = Boolean.Parse(Console.ReadLine());
                if (answer_3)
                {
                    while (number < 19)
                    {
                        if (number % 2 == 0)
                        {
                            Console.WriteLine($"Ваше число {number}?");
                            bool answer_4 = Boolean.Parse(Console.ReadLine());
                            if (answer_4)
                            {
                                Console.WriteLine("Игра окончена");
                                break;
                            }
                        }
                        number++;
                    }
                }
                else
                {
                    while (number < 19)
                    {
                        if (number % 3 == 0 | number == 1)
                        {
                            Console.WriteLine($"Ваше число {number}?");
                            bool answer_4 = Boolean.Parse(Console.ReadLine());
                            if (answer_4)
                            {
                                Console.WriteLine("Игра окончена");
                                break;
                            }
                        }
                        number++;
                    }

                }
            }
            else
            {
                Console.WriteLine("Ваше число четное? (True/False)");
                bool answer_3 = Boolean.Parse(Console.ReadLine());

                if (answer_3)
                {
                    number = 10;
                    while (number >= 10 & number < 100)
                    {
                        if (number % 2 == 0)
                        {
                            Console.WriteLine($"Ваше число {number}?");
                            bool answer_4 = Boolean.Parse(Console.ReadLine());
                            if (answer_4)
                            {
                                Console.WriteLine("Игра окончена");
                                break;
                            }
                        }
                        number++;
                    }
                }
                else
                {
                    while (number > 19 & number < 100)
                    {
                        if (number % 3 == 0 | number == 1)
                        {
                            Console.WriteLine($"Ваше число {number}?");
                            bool answer_4 = Boolean.Parse(Console.ReadLine());
                            if (answer_4)
                            {
                                Console.WriteLine("Игра окончена");
                                break;
                            }
                        }
                        number++;
                    }
                }
            }
        }
    }
}
