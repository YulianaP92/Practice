using System;


namespace Basic.Lesson_4._1
{
    class B4_P5_25_Switch_DayOfWeek
    {
        public static void Switch_DayOfWeek()
        {
            var today = DateTime.Today;
            var dayOfWeek = (int) today.DayOfWeek;
            switch (dayOfWeek)
            {
                case 0:
                    Console.WriteLine("Доброго воскресенья,Ольга");
                    break;
                case 1:
                    Console.WriteLine("Доброго понедельника,Ольга");
                    break;
                case 2:
                    Console.WriteLine("Доброго вторника,Ольга");
                    break;
                case 3:
                    Console.WriteLine("Доброй  среды ,Ольга");
                    break;
                case 4:
                    Console.WriteLine("Доброго четверга,Ольга");
                    break;
                case 5:
                    Console.WriteLine("Доброй пятницы,Ольга");
                    break;
                case 6:
                    Console.WriteLine("Доброй субботы,Ольга");
                    break;
            }
        }
    }
}
