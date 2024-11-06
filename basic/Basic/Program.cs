// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine(" Using Visual Studio");


//string FirstName = "Sahabuddin";
//string LastName = "Hossain";
//Console.WriteLine("Hey! Mr " + FirstName +" " + LastName +" Wellcome");


//const int number = 019;
//Console.WriteLine(number);
//You cannot declare a constant variable without assigning the value. If you do, an error will occur: A const field requires a value to be provided

//All C# variables must be identified with unique names. These unique names are called identifiers.

//int MyNumber = 12;
//double DoubleNumber = 45.23D;
//float MyFloat = 1.939f;
//char MyChar = 'A';
//bool Mybool = false;
//string MyString  = "This is a string!";

//long MyLong = 4646566565446546544L;

//Console.WriteLine($"Hello. Welcome to the data type section in C#.\nHere is the different types of variable.\nThis is an integer data type value: {MyNumber}" +
//    $"\nThis is a float data types value: {MyFloat}" +
//    $"\nThis is a double data types value: {DoubleNumber}" +
//    $"\nThis is a char data types value: {MyChar}" +
//    $"\nThis is a bool data types value: {Mybool}" +
//    $"\nThis is a Long data types value: {MyLong}" +
//    $"\nThis is a String data types value: {MyString}");

//The precision of a floating point value indicates how many digits the value can have after the decimal point. 
//The precision of float is only six or seven decimal digits, while double variables have a precision of about 15 digits.
//Therefore it is safer to use double for most calculations.


// Type Casting 
//In C#, there are two types of casting:
//Implicit Casting (automatically) - converting a smaller type to a larger type size
//char -> int -> long -> float -> double
//Explicit Casting (manually) - converting a larger type to a smaller size type
//double -> float -> long -> int -> char

// implicit type casting 

//int MyInt = 39;
//double MyDouble = MyInt; // automatically
//Console.WriteLine(MyDouble);

//Explicit type casting

//double MyDecimal = 788.35;
//int MyInt2 = (int)MyDecimal;
//Console.WriteLine(MyInt2); 

//with in-build method

//int MyInt = 45;
//Console.WriteLine("Here is in-build method"+ Convert.ToDouble(MyInt));
//double MyDouble = 58.23;
//Console.WriteLine("Here is in-build method" + Convert.ToInt32(MyDouble));


//user input 
//string Name;
//Console.WriteLine("Please enter your name here.");
//Name = Console.ReadLine();

//Console.WriteLine("Please enter your Age here.");
//int Age = Convert.ToInt32( Console.ReadLine()); // readline is by default string mode
//Console.WriteLine($"wellcome Mr {Name}. Your age is {Age}");


//Operator

//Arithmetic Operator + = * / % ++ --
// Assignment Operator =  += -= *= /= 

////And Operator
//int number = 5;                 // 101
//int number2 = 6;                // 110

//int Result = number &  number2; // 100

//Console.WriteLine(Result);

////Or Operator
//int number = 5;                 // 101
//int number2 = 6;                // 110

//int Result = number | number2;  // 111

//Console.WriteLine(Result);


////X-Or Operator
//int number = 5;                 // 101
//int number2 = 6;                // 110

//int Result = number ^ number2;  // 011

//Console.WriteLine(Result);

////Left-Shift Operator
//int number = 5;                 // 0000 0101

//int Result = number >> 3;       // 0000 0000

//Console.WriteLine(Result);

//Right-Shift Operator
//int number = 5;                 // 0000 0101
//int Result = number << 3;       // 0010 1000
//Console.WriteLine(Result);


// Comparision operator  == != > < >= <=

// Logical operator (And or not) && || !


//Math in-build methods 

//Console.WriteLine(Math.Tau);

//Console.WriteLine(Math.Round(-6352.25));

//list of  Math in-build function

//Math.Abs() Math.Max() Math.Min() Math.Sqrt() Math.Round Math.floor() Math.Ceiling() Math.Log() Math.Log10() Math.Sign()

//Console.WriteLine(Math.Abs(455.35));

//Console.WriteLine(Math.Max(45,48));

//Console.WriteLine(Math.Sqrt(81));

//Console.WriteLine( Math.Floor(8.654));

//Console.WriteLine(Math.Ceiling(8.654));

//Console.WriteLine( Math.Log2(8));

//Console.WriteLine(Math.Log10(1000));

//Console.WriteLine( Math.Sign(10222));

// String Manipulation

//string demo = " This is a demo text";
////Console.WriteLine(demo);
//Console.WriteLine(demo.Length);
//Console.WriteLine(demo.ToUpper());
//Console.WriteLine(demo.GetType());
//Console.WriteLine(demo.Replace("text","String"));
//Console.WriteLine(demo.GetType());

//string FirstName = "Mr";
//string LastName = " X";
//string FullName = FirstName + LastName; // string concatenation
//Console.WriteLine(FullName);
//int number = 10, number1 = 12; 
//Console.WriteLine(number + number1);

//Remember: Numbers are added.Strings are concatenated.

// string interpolation using doller sign

//string FirstName = "Mr.";
//string LastName = " Doe";
//string Name = $"Your full name is: {FirstName} {LastName}";
//Console.WriteLine(Name);