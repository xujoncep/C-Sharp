using System.Diagnostics;

namespace ThrowAndThrowEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            try
            {
                First();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
            }

            //Parse vs TryParse Vs Convert
            //string invalid = null;
            //int num = int.Parse(invalid);
            //int num = Convert.ToInt32(invalid);
            //bool num1 = int.TryParse(invalid, out int num);
            
            Console.ReadKey();
        }


        static void First()
        {
            Console.WriteLine("Hello First");
            try
            {
                Second();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        static void Second()
        {
            Console.WriteLine("Hello Second");         

            try
            {
                Third();

            }
            catch (Exception)
            {

                throw;
            }
        }

        static void Third()
        {
            Console.WriteLine("Hello third");
            //Console.WriteLine(Environment.StackTrace);
            throw new Exception("This is an exception");
        }
    }
}
    