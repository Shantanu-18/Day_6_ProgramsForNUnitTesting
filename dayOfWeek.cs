using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramsForNUnitTesting
{
    class dayOfWeek
    {
        public static void daysOfWeek()
        {
            int m, d, y;

            Console.Write("Enter month (1 for January,2 for February, 3 for March and so forth.): ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter day: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year in yyyy format: ");
            y = Convert.ToInt32(Console.ReadLine());


            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;

            Console.WriteLine("Sunday is 0, Monday is 1, Tuesday is 2, Wednesday is 3, Thursday is 4, and Friday is 5 and Saturday is 6");
            Console.WriteLine("It was: "+d0);

            
        }


    }
}
