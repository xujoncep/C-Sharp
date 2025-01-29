using System.Globalization;
using System.Text.RegularExpressions;

namespace C_Sharp_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n \n");

            //DateTime printing in specific format

            DateTime dateTime = DateTime.UtcNow;
            var format = dateTime.ToString("'year = ' yyyy \n'month = 'M \n'day = 'd \n'minute = 'mm \n'second = 'ss\n'millisecond = 'ff");
            Console.WriteLine(dateTime);
            Console.WriteLine(format);

            //Printing Day of a week in full

            DateTime datetime1 = new DateTime(2016, 12 , 31);
            var format2 = datetime1.ToString("'The day of the week for 'd'/'M'/'yyyy 'is 'dddd");

            //Printing is it leap year or not
            //datetime1.DayOfYear == 366 ? Console.WriteLine($"{datetime1.DayOfYear} of {datetime1.Year}") : Console.WriteLine($"{datetime1.DayOfYear} of {datetime1.Year}")
            
            if (datetime1.DayOfYear == 366)
            {
                Console.WriteLine($"{datetime1.DayOfYear} of {datetime1.Year} (Leap Year)");

            }
            else
            {
                Console.WriteLine($"{datetime1.DayOfYear} of {datetime1.Year}");
            }

            //Culture info 
            var format3 = dateTime.ToString("F", new CultureInfo("bd-UK"));
            Console.WriteLine(format3);

            Console.WriteLine("For South Africa ");
            var format4 = dateTime.ToString("F", new CultureInfo("sa"));
            Console.WriteLine($"Local date and time:{format4}");


           
            // More About Calture 
           
            var calture = new CultureInfo(36);
            Console.WriteLine(calture.NativeName);
            Console.WriteLine(calture.Name);
            Console.WriteLine(calture.Calendar);
            Console.WriteLine(calture.NumberFormat);
            Console.WriteLine(calture.ThreeLetterISOLanguageName);

            //Age calculation 

            DateTime birthdate = new DateTime(1998, 12, 12);
            DateTime now = DateTime.Now;
            TimeSpan age = now.Subtract(birthdate);
            int year = (int) (age.TotalDays/365.25);
            int month = (int) (age.TotalDays - year*365.25)/30;
            int day = (int)(age.TotalDays - (year * 365.25 + month * 30));
            Console.WriteLine($"Your age is year: {year} Month: {month} Day: {day}");


        }
    }
}
