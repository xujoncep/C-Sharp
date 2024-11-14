class Program
{
    static void Main(string[] args)
    {

        //var student = new List<Student>()
        //{
        //  new Student(id:1,name:"Mr A"),
        //  new Student(id:1,name:"Mr X"),
        //  new Student(id:2,name:"Mr B"),
        //  new Student(id:3,name:"Mr C"),
        //  new Student(id:3,name:"Mr A"),
        //  new Student(id:1,name:"Mr Y"),

        //};


        //// For first value of duplicate list item
        //Dictionary<int,string> firstItemDictionary = student
        //                .GroupBy(p => p.Id)
        //                .ToDictionary(g => g.Key, g => g.First().Name);

        //Console.WriteLine("Keeping first value of duplicate list item");
        //foreach (var item in firstItemDictionary)
        //{
        //    Console.WriteLine($"Key: {item.Key} Value:{item.Value}");
        //}

        
        //// For Last value of duplicate list item
        //var lastItemDictionary = student
        //                .GroupBy(p => p.Id)
        //                .ToDictionary(g => g.Key, g => g.Last().Name);

        //Console.WriteLine("Keeping last value of duplicate list item");
        //foreach (var item in lastItemDictionary)
        //{
        //    Console.WriteLine($"Key: {item.Key} Value:{item.Value}");
        //}

        //// For all item of a Key using list
        //Dictionary<int, List<string>> allItemDictionary = student
        //    .GroupBy(p => p.Id)
        //    .ToDictionary(g => g.Key, g => g.Select(p => p.Name).ToList());

        //Console.WriteLine("All item using list");
        //foreach (var item in allItemDictionary)
        //{
        //    Console.WriteLine($"Id: {item.Key}, Names: {string.Join(", ", item.Value)}");
        //}

        
        //// Composite key using id and name
        //var compositeKeydictionary = student
        //                        .ToDictionary(
        //                            p => Tuple.Create(p.Id, p.Name),
        //                            p => p.Name                      
        //                        );

        //Console.WriteLine("All item using composite key");

        //foreach( var item in compositeKeydictionary)
        //{
        //    Console.WriteLine($"Id: {item.Key} Names: {item.Value}");
        //}

        
        //others operation in Linq 
        List<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
        List<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
        List<string> emptyList = new List<string>();

        Console.WriteLine($"1st Element: {intList.FirstOrDefault()}");
        Console.WriteLine($"1st Even Element: {intList.FirstOrDefault(i => i % 2 == 0)}");                                
        Console.WriteLine("1st Element in emptyList: {0}", emptyList.FirstOrDefault());

        Console.WriteLine($"last Element: {intList.LastOrDefault()}");
        Console.WriteLine($"last Even Element: {intList.LastOrDefault(i => i % 2 == 0)}");
        Console.WriteLine("last Element in emptyList: {0}", emptyList.LastOrDefault());

        //Console.WriteLine($"Single Element: {intList.SingleOrDefault()}");
        //Console.WriteLine($"Single Even Element: {intList.SingleOrDefault(i => i % 2 == 0)}");
        //Console.WriteLine("Single Element in emptyList: {0}", emptyList.SingleOrDefault());


    }
}