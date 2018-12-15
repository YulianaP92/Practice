using System;


namespace Basic.Lesson_4._1
{
    class B4_P23_25IfElse_Calculator
    {
        public static void IfElse_Calculator()
        {
            Console.Write("Enter the first number: ");
            var number_1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            var number_2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operator '+', '-', '/', '*' ");
            var @operator = Console.ReadKey().KeyChar;
            if (@operator == '+')
                Console.WriteLine($"\nSum:{number_1 + number_2} ");
            else if (@operator == '-')
                Console.WriteLine($"\nDifference:{number_1 - number_2} ");
            else if (@operator == '*')
                Console.WriteLine($"\nMultiplication:{number_1 * number_2} ");
            else if (@operator == '/')
                Console.WriteLine($"\nDivision:{number_1 / number_2} ");
            else
                Console.WriteLine("Invalid operator");
        }
    }
}
