using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class EnumProgram
    {
        public enum DaysOfWeek
        { 
            sunday,
            monday,
            tuesday,
            wednesday,
            thusday,
            friday,
            staturday
        }

        enum Level
        {
            begginer,
            intermediate,
            advance,
            fluent
        }

        //static void Main(string[] args)
        //{
        //    DaysOfWeek mydays = DaysOfWeek.friday;
        //    Console.WriteLine(mydays);           //its printing days into string format for auto in console.Writeline
        //    Console.WriteLine((int)mydays);      //After type casting

        //    Level mylevels = Level.begginer;
        //    Console.WriteLine($"My C-Sharp Programming level is {mylevels}");
        //}
    }
}
