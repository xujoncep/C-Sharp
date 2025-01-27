namespace Ref_In_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ref
            Console.WriteLine("Hello, World!");

            int number1 = 5;
            int number2 = 3;

            Console.WriteLine($"Before swap Number1: {number1} Number2: {number2}");

            Swap( ref number1, ref number2 );
            //SwapWithoutRef( number1, number2 );
            Console.WriteLine($"Before swap Number1: {number1} Number2: {number2}");

            //In
            int  balance = 10;
            Display(balance);


            //Out
            double result = 20;
            TryDivide(12, 12, out result);
            Console.WriteLine("After Divdie result value" + result);


        }


        static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        static void SwapWithoutRef( int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        static void Display(in int balance)
        {
            //balance = balance + 1;
            Console.WriteLine("Your balance is "+balance);
        }


        static void TryDivide(int x, int y, out double result)
        {
            if (y != 0)
            {
                Console.WriteLine("Successfully completed");
                result = (x / y);
            }

            else
            {
                Console.WriteLine("Opps!");
                result = 0;
            }

        }
    }
}
