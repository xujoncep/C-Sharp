using System.Globalization;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {

        // Solution Method-01: in details 
        //string number = "12,14,20,5,8,3";

        ////string list

        //List<string> strList = number.Split(',').ToList();
        //Console.WriteLine("Printing string list");
        //foreach (string str in strList)
        //{
        //    Console.WriteLine(str);
        //}


        ////int list
        //List<int> intList = new List<int>();
        //Console.WriteLine("Printing int list");
        //for (var i = 0; i < strList.Count; i++)
        //{
        //    intList.Add(int.Parse(strList[i]));
        //}
        //foreach (int str in intList)
        //{
        //    Console.WriteLine(str);
        //}

        ////int stack
        //Stack<int> stack = new Stack<int>(intList);
        //Console.WriteLine("Printing Stack");
        //foreach (int str in stack)
        //{
        //    Console.WriteLine(str);
        //}

        ////Poping and printing stack
        //int num = stack.Count;
        //Console.WriteLine("Stack length is " +num);
        //Console.WriteLine("Poping and Printing");
        //for (int i = 0; i < 6; i++)
        //{
        //    Console.WriteLine(stack.Pop());
        //}


        // Method 02: Short Way
        string number = "12,14,20,5,8,3";
        //List<int> strList = number.Split(',').Select(int.Parse).ToList();
        Stack<int> intStack = new Stack<int>(number.Split(',').Select(int.Parse));
        Console.WriteLine("Printing element of stack:");
        foreach (int str in intStack)
        {
            Console.WriteLine(str);
        }
      
        
        Console.WriteLine("Poping element of stack:");
        int Length = intStack.Count;
        
        for (int i = 0; i < Length; i++)  
        {
            Console.WriteLine(intStack.Pop());
        }
    }
}