namespace RawStringVsVerbatrim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verbatrim string");
            
            string verbatimJson = @"
                                {
                                    ""name"": ""John"",
                                    ""age"": 30,
                                    ""city"": ""New York""
                                }";
            Console.WriteLine(verbatimJson);

            Console.WriteLine("String Letaral");

            string rawJson = """
                            {
                            "name": "John",
                            "age": 30,
                            "city": "New York"
                            }
                            """;
            Console.WriteLine(rawJson);

        }
    }
}
