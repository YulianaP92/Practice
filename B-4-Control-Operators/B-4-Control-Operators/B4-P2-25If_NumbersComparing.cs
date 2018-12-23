using System;


namespace Basic.Lesson_4._1
{
    class B4_P2_25If_NumbersComparing
    {
        public static void If_NumbersComparing()
        {
            int x, y;
            Console.Write("Enter the number 1: ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the number 2: ");
            y = Int32.Parse(Console.ReadLine());
            if (x == y)
                Console.WriteLine("Values are equal");
            else if (x > y)
                Console.WriteLine($"{x}>{y} on {x - y}");
            else
                Console.WriteLine($"{x}<{y} on {y - x}");
        }
    }
}
