using System;

namespace TimesAndDates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            var year = dateTime.Year;

            Console.WriteLine(dateTime.ToString());
            Console.WriteLine(year);

            TimeSpan timeSpan = new TimeSpan(7,0,0);
            var ts = new TimeSpan(
                );

            Console.WriteLine(timeSpan.TotalSeconds);
        }
    }
}
