
////voteing checker

//int age;
//string? name;


//while (true)
//{
//    Console.WriteLine("Please enter your name (or type 'exit' to quit): ");
//    name = Console.ReadLine();



//    if (name != null && name.Equals("exit", StringComparison.OrdinalIgnoreCase)) // accepting any 
//    {
//        Console.WriteLine("Exiting the program. Goodbye!");
//        break; // Exit the loop
//    }

//    Console.WriteLine("Please enter your age: ");
//    age = Convert.ToInt32(Console.ReadLine());

//    if (name == null || (age <= 0 || age >= 100))
//    {
//        Console.WriteLine("Incorrect info. try again!");
//    }

//    else
//    {
//       if(age>=18 && age < 100)
//        {
//            Console.WriteLine($"Congratulation Mr. {name}! You are eligable for voting");
//        }

//       else
//        {
//            Console.WriteLine($"Sorry Mr. {name}! You are not eligable for voting");
//        }
//    }
//}


// Ternary Operator

//variable = (condition)? trueCase : falseCase

//int temp = 34;
//string result = temp > 25 ? "This is a hot day." : "This is cold day";
//Console.WriteLine(result);  

//// switch 

//    Console.WriteLine("Enter day short from. ");
//    string? day = Console.ReadLine();
//    switch (day)
//    {
//        case "sat":
//            Console.WriteLine("This is weekend day");
//            break;
//        case "sun":
//            Console.WriteLine("This is working day");
//            break;
//        case "mon":
//            Console.WriteLine("This is working day");
//            break;
//        case "tue":
//            Console.WriteLine("This is working day");
//            break;
//        case "wed":
//            Console.WriteLine("This is working day");
//            break;
//        case "thu":
//            Console.WriteLine("This is working day");
//            break;
//        case "fri":
//            Console.WriteLine("This is weekend day");
//            break;

//        default:
//            Console.WriteLine(" Invalid input");
//            break;
//    }

// switch 

//Console.WriteLine("Enter day short from. ");
//string? day = Console.ReadLine();
//switch (day)
//{
//    case "sat":
//    case "fri":
//        Console.WriteLine("This is weekend day");
//        break;

//    case "sun":

//    case "mon":

//    case "tue":

//    case "wed":

//    case "thu":
//        Console.WriteLine("This is working day");
//        break;

//    default:
//        Console.WriteLine(" Invalid input");
//        break;
//}

//nested for looping 

//for(int i = 1; i <= 10; i++)
//{
//    for(int j = 1; j <= i; j++)
//    {
//        Console.Write("# ");
//    }
//    //Console.WriteLine($"Number of loop: {i}");
//    Console.WriteLine("\n");
//}

// foreach loop


//string text = "Hello. this is a dummy text testing foreach loop";
//string[]textWord=text.Split(' ');
//foreach(string w in textWord)
//{
//    Console.WriteLine(w);
//}

// break and continue

//string text = "Hello. this is a dummy text testing foreach loop";
//string[] textWord = text.Split(' ');
//foreach (string w in textWord)
//{
//    if (w == "a")
//    {
//        continue;
//    }
//    if (w == "text")
//    {
//        break;
//    }

//    Console.WriteLine(w);
//}


//arry

//string[] books = { "c-books", "c-sharp", "clean-code" };

//string[] language = new string[4] { "c", "c++", "python","c#" };

//Console.WriteLine(books[0]);

//Console.WriteLine(books.Length);

//foreach (string book in language)
//{
//    Console.WriteLine(book);
//}


//int[] number = { 1, 2, 35, 3, 23, 7 };

//Array.Sort<int>(number);

//foreach(int item  in number)
//{
//    Console.WriteLine(item);    
//}

// finding max and min number into an arry

//Console.WriteLine("Enter the size of the array");
//int n= Convert.ToInt32(Console.ReadLine());
////int num= int.Parse(Console.ReadLine()); 
//int []arr = new int[n];


//// taking arry as input
//for (int i = 0; i < n; i++)
//{
//    Console.Write($"Enter the element no {i}: ");
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//int max = arr[0];
//int min = arr[0];
////finding the element

//for (int i=0; i < n; i++)
//{
//    if(arr[i] > max)
//    {
//        max = arr[i];
//    }

//    if (arr[i] < min)
//    {
//        min = arr[i];
//    }
//}

//for(int i = 0;i < n; i++)
//{
//    Console.WriteLine($"Element no {i} value is: {arr[i]}");
//}

//Console.WriteLine($"Lowest element of the array is: {min}");
//Console.WriteLine($"Heighest element of the array is: {max}");