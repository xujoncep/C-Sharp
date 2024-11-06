using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class Overloading
    {
        static int Sum(int a, int b)
        {
         return a + b;
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static float Sum(float a, float b)
        {
            return a + b ;
        }
        static float Sum(float a, float b, float c)
        {
            return a + b + c;
        }
        static string Sum(string a, string b)
        {
            return a + b;
        }

        static string Sum(string a, string b, string c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(Sum("Mr ","Sahabuddin ", "Hossain"));
            Console.WriteLine(Sum(545, 456));
            Console.WriteLine(Sum(545, 456,637));
            Console.WriteLine(Sum(5.32f, 6.23f));



        }

    }


}
