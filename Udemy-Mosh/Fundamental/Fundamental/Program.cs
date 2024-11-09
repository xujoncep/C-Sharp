namespace Fundamental
{
    class Program
    {

        // upto section-04 program class
        //static void Main(string[] args)
        //{
        //    //with static method
        //    //int result = Calculator.AddStatic(5, 4);
        //    //Console.WriteLine(result);

        //    //with object
        //    //var calculator = new Calculator();
        //    //int result = calculator.Add(7, 4);
        //    //Console.WriteLine(result);

        //    //with strings formater

        //    //string firstName = "Md. Sahabuddin";
        //    //string lastName = "Hosssain";
        //    ////string fullName = string.Format("{0} {1}", firstName, lastName);
        //    ////Console.WriteLine(fullName);
        //    //Console.WriteLine("My name is {0} {1}",firstName,lastName);
        //    //Console.WriteLine($"My name is {firstName} {lastName}");

        //    // string are immutable 

        //    //verbatim string
        //    //var VerbatimString = @"c:\projects\myproject\folder ";

        //    //Console.WriteLine(VerbatimString);

        //    //String name = "mr x";
        //    //Console.WriteLine(name);

        //    //var names = new string[] { "jhon", "bob", "alice" };

        //    //var allNames = string.Join(" ", names);
        //    //Console.WriteLine($"all names are {allNames}");


        //    //enum should be use where a number of related constant are 

        //    //var MyLevel = EnumClass.Level.high;
        //    //Console.WriteLine(MyLevel); // string value
        //    //Console.WriteLine((int)MyLevel); // int value

        //    //all primitive are structure

        //    //arrys, strings, custom classes are non primitives

        //    // structure are value types and classes are reference type


        //    //call by value
        //    //var a = 10;
        //    //var b = a;
        //    //b++;

        //    //Console.WriteLine($"a={a} b={b}");


        //    //// call by reference
        //    //var arry1 = new int[] { 4, 4, 5, 8 };
        //    //var arry2 = arry1;
        //    //arry2[0] = 1;

        //    //Console.WriteLine($"The first arry element: {arry1[0]}");
        //    //Console.WriteLine($"The second arry element: {arry2[0]}");


        //    //var seasion = EnumClass.Level.low;


        //}


        // section-05 program class

        //static void Main(string[] args)
        //{
        //    // four loop, for , foreach, while, do-while


        //    //// for loop
        //    //for (int i = 0; i < text.Length; i++)
        //    //{
        //    //    Console.WriteLine(text[i]);
        //    //}


        //    //foreach loop
        //    //foreach (char item in text)
        //    //{
        //    //    Console.WriteLine(item);
        //    //}

        //    // while loop

        //    //int i = 0;
        //    //while (i < text.Length)
        //    //{
        //    //    Console.WriteLine(text[i]);
        //    //    i++;
        //    //}

        //    //string text = "this is a string";

        //    //int i = 0;
        //    //do
        //    //{
        //    //    Console.WriteLine(text[i]);
        //    //    i++;
        //    //}
        //    //while (i < text.Length);


        //    //while pratices 
        //    //while (true)
        //    //{
        //    //    Console.WriteLine("enter your name");
        //    //    var name = Console.ReadLine();

        //    //    if (!String.IsNullOrEmpty(name))
        //    //    {
        //    //        Console.WriteLine($"Your name is:{name}");
        //    //        continue;
        //    //    }
        //    //    break;
        //    //}


        //    //Random Numbers

        //    var random = new Random();

        //    //for (int i = 0; i < 10; i++) 
        //    //{
        //    //    //Console.WriteLine($"Random number {i}: {random.Next()}"); //without limit
        //    //    Console.WriteLine($"Random number {i}: {random.Next(1,10)}"); // with a limit
        //    //}

        //    // password genarator 

        //    //for (int i = 0; i < 10; i++)
        //    //{
        //    //    Console.Write((char)random.Next(33,122)); // with ascii value is used
        //    //}

        //    //var password = new char[8];
        //    //for (int i = 0; i <= 7; i++)
        //    //{
        //    //    password[i]= (char)(random.Next(33, 122)); // with ascii value is used
        //    //}
        //    //string mypass = new string(password);
        //    //Console.WriteLine(mypass);
        //}



        //section-06-arry and list

        //static void Main(string[] args)
        //{

        //    // there are two types of array in c-sharp. ractangular array and jagged array
        //    //2d array

        //    //var matrix = new int[2, 2] { { 1,2},{ 3,4} };
        //    //Console.WriteLine($"first element: {matrix[0,0]}");

        //    //// input a n X m matrix from user and print them
        //    //Console.WriteLine("Enter your matrix row: ");
        //    //int row = Convert.ToInt32(Console.ReadLine());

        //    //Console.WriteLine("Enter your matrix collum: ");
        //    //int col = Convert.ToInt32(Console.ReadLine());
            
        //    //int [,]martix = new int[row, col];

        //    //Console.WriteLine("Great! Enter your matrix");
            
        //    ////input loop
        //    //for (int i = 0;i<row;i++)
        //    //{
        //    //    for (int j = 0;j<col;j++)
        //    //    {
        //    //        Console.WriteLine($"Enter element: Row:{i+1} Collum: {j+1}");
        //    //        martix[i,j] = Convert.ToInt16(Console.ReadLine());
        //    //    }
        //    //}

        //    ////print

        //    //Console.WriteLine("This is your Matrix:");

        //    //for (int i = 0; i < row; i++)
        //    //{
        //    //    for (int j = 0; j < col; j++)
        //    //    {
        //    //        Console.Write(martix[i, j] + " ");
        //    //    }
        //    //    Console.WriteLine();
        //    //}

        //    //var numbers = new[] {23,2, 32, 4, 5};

        //    ////array length
        //    //Console.WriteLine("array length is"+numbers.Length);
        //    ////get index
        //    //int index = Array.IndexOf(numbers, 4);
        //    //Console.WriteLine($" index of 4 is: {index}");
            
        //    ////clear
        //    //Array.Clear(numbers,2,1);
        //    //foreach(int i in numbers) Console.WriteLine(i);
        //    ////copy 
        //    //int []numbersCopy = new int[5];
        //    //Array.Copy(numbers,numbersCopy,numbers.Length-2);
        //    //Console.WriteLine("This is the copy array");
        //    //foreach( int i in numbersCopy ) Console.WriteLine( i );

        //    ////sort 
        //    //int []sortedAaary= new int[5];
        //    //Array.Sort(numbers);
        //    //sortedAaary = numbers;
        //    ////sorted array
        //    //Console.WriteLine("sorted array");
        //    //foreach (var i in sortedAaary) Console.WriteLine(i);


        //    //work with List
        //    var number = new List<int>() { 1, 33, 34, 4, 32, 32,2,2,1,343,23,2,1 };
           
        //    //number.Add(1);

        //    //var arr = new int[] { 2, 23, 43 };
        //    //number.AddRange(arr);
        //    //foreach (int i in number)
        //    //{
        //    //    Console.WriteLine("element: "+ i);
        //    //}

        //    //Console.WriteLine($"Index of 1 : {number.IndexOf(1)}");
        //    //Console.WriteLine($"Last Index of 1: {number.LastIndexOf(1)}");
        //    //Console.WriteLine($"Element of numbers: {number.Count}");

        //    for (int i = 0; i < number.Count; i++) // foreach loop doesn't support modified element at the runtime 
        //    {
        //        if (number[i] == 1)
        //        {
        //            number.Remove(number[i]);
        //        }
        //    }

        //    foreach (int i in number)
        //    {
        //        Console.WriteLine("Element are here: "+i);
        //    }


        //}

        //section-07-date and time

        static void Main(string[] args)
        {
            var dateTime = new DateTime(2024, 12, 12);  //datetime is immutable
            var now = DateTime.Now;
            var today = DateTime.Today;

            //Console.WriteLine("Current Year: " + now.Year);
            //Console.WriteLine("Current Month: " + now.Month);
            //Console.WriteLine("Current Day: " + now.Day);
            //Console.WriteLine("Current Hour: "+ now.Hour);
            //Console.WriteLine("Current Min: " + now.Minute);
            //Console.WriteLine("Current Second: " + now.Second);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("G"));

        }

    }
}