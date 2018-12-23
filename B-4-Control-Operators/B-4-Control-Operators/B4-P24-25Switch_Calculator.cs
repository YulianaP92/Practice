using System;


namespace Basic.Lesson_4._1
{
    class B4_P24_25Switch_Calculator
    {
        public static void Switch_Calculator()
        {
            Console.Write("Enter the first number: ");
            var number_1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            var number_2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operator '+', '-', '/', '*' ");
            var @operator = Console.ReadKey().KeyChar;
            switch (@operator)
            {
                case '+':
                    Console.WriteLine($"\nSum:{number_1 + number_2} ");
                    break;
                case '-':
                    Console.WriteLine($"\nDifference:{number_1 - number_2} ");
                    break;
                case '*':
                    Console.WriteLine($"\nMultiplication:{number_1 * number_2}");
                    break;
                case '/':
                    Console.WriteLine($"\nDivision:{number_1 / number_2}");
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
        }
    }
}
