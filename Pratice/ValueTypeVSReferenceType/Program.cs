namespace ValueTypeVSReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var list1 = new List<int> { 1, 2, 3 };
            var list2 = list1;
            list2.Add(10);
            list1.Remove(1);

            Console.WriteLine($"Length of list1 is {list1.Count}");
            Console.WriteLine($"Length of list2 is {list2.Count}");


        }
    }

}
