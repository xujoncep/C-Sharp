namespace Spot_Test_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            static string DayAfterNDays(int n)
            {
                return DateTime.Now.AddDays(n).ToString("dddd");
            }
            Console.WriteLine(DayAfterNDays(56));
        }

    }
}
