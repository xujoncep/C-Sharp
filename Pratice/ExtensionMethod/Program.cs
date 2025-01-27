namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var numbers = new List<int> {1,2,3,4,5};

            var result = numbers.Avg();
            Console.WriteLine(result);

        }

    }
}

public static class IEnumerableExtensions
{
    public static double Avg(this IEnumerable<int> data)
    {
        if(data == null)
        {
            throw new ArgumentNullException("data");
        }

        return (double)data.Sum()/ data.Count();
    }

}
