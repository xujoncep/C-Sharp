namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Recursion.Print(10);

            Console.WriteLine(Recursion.Sum(10));

            Recursion.Digit(1234);

        }
    }

    

    public class Recursion
    {
        // Print number from 1 to n using recursion

        public static void Print( int number, int i = 1)
        {
            if (number == 0)
            {
               return;
            }
            
            Console.WriteLine(i);
            number--;
            Print(number, i +1);
        }

       
        // Print the sum of 1 to n using recursion

        public static int Sum(int number, int sum = 0)
        {
            if (number == 0)
            {
                return sum;
            }

            return  Sum(number - 1, sum +number);
         
        }

        // Print number digits 

        public static void Digit(int number)
        {
            if(number < 10)
            {
                Console.Write(number + " ");
                return;
            }

            Digit(number/10);
            Console.Write(number % 10 + " ");
            

        }


    }


}
