﻿//bool check = false;
//Console.WriteLine(check);

//uint num = 10000u;
//Console.WriteLine(uint.MaxValue);

//float num2 = 10000f;
//Console.WriteLine($"{num2:F6}");  // fraction digit printing using string interpolation

//long num3 = 10000l;
//Console.WriteLine(num3);

//ulong num4 = 1000444444444440ul;
//Console.WriteLine(num4);

//double num5 = 10000d;
//Console.WriteLine(num5);

//decimal num6 = 239482309578209358230m;
//Console.WriteLine(num6);

//Console.WriteLine(sizeof(bool));

//scientific notation

//decimal number = 1.2e6m;
//Console.WriteLine(number);

//int age = 16;
//string name = "sujon";

//Console.WriteLine($"Hey! My name is {name}.I am {age}");

//DateTime birthdate = new DateTime(1998, 12, 12);

//Console.WriteLine($"My birthdate is { birthdate}");

//DateTime dateTime = DateTime.Now;

////timespan

//TimeSpan ts = new TimeSpan(24, 12, 12);

//DateTime dateTime1 = birthdate.Add(ts);
//Console.WriteLine(dateTime1);

//DateTime dateTime = DateTime.Now;
//DateTime birthdate = new DateTime(1998, 12, 12);

//Console.WriteLine(dateTime.Subtract(birthdate).TotalSeconds);

//string number = "2000120123";
//DateTime dt;
//var date = DateTime.TryParse(number,out dt );
//Console.WriteLine(dt);

using System.Collections;
using System.Xml.Linq;

partial class Program
{
    //private static void ModifyClass(PointClass pointClass)
    //{
    //    pointClass.no1 += 100;
    //    pointClass.no2 += 100;
    //    Console.WriteLine($"Inside Modify First Number: {pointClass.no1} Second Number: {pointClass.no2}");
    //}

    //private static void ModifyStruct(PointStruct pointStruct)
    //{
    //    pointStruct.no1 += 100;
    //    pointStruct.no2 += 100;
    //    Console.WriteLine($"Inside Modify First Number: {pointStruct.no1} Second Number: {pointStruct.no2}");
    //}

    //static void Main(string[] args)
    //{
    //    ////Class
    //    //Console.WriteLine("------------Class------------");
    //    //Console.WriteLine("Before modify");
    //    //var pointClass = new PointClass(10, 20);
    //    //pointClass.Show();
    //    //ModifyClass(pointClass);
    //    //Console.WriteLine("After modify");
    //    //pointClass.Show();

    //    ////struct
    //    //Console.WriteLine("-------------Struct------------");
    //    //Console.WriteLine("Before modify");
    //    //var pointStruct = new PointStruct(10, 20);
    //    //pointStruct.Show();
    //    //ModifyStruct(pointStruct);
    //    //Console.WriteLine("After modify");
    //    //pointStruct.Show();

    //    //var day = WeekDaysEnum.Sunday;
    //    //Console.WriteLine((int)day);
    //}

    //ArryList

    //static void Main(string[] args)
    //{
    //    var arrList = new ArrayList();
    //    //arrList.Add(1);
    //    //arrList.Add("hi");
    //    //arrList.Add(false);

    //    Console.WriteLine("Enter array list item");
    //    for (int i = 0; i < 5; i++)
    //    {

    //        arrList.Add(Console.ReadLine());
    //    }
    //    Console.WriteLine("Printing arryList Item.");

    //    foreach (var item in arrList)
    //    {
    //        Console.WriteLine(item);
    //    }
    //}


    //static void Main(string[] args)
    //{
    //    //List 
    //    //List<int> numbers= new List<int>();
    //    //numbers.Add(1);
    //    //numbers.Add(2);
    //    //numbers.Add(3);

    //    //var city = new List<string>() { "Dhaka","Khulna","Barishal" };

    //    //var cites = new string[3] { "london", "kalkata", "Jashore" };
    //    //city.AddRange(cites);

    //    //foreach(var item  in city)
    //    //{
    //    //    Console.WriteLine(item);
    //    //}

    //    //Console.WriteLine(city.Contains("london"));

    //    //for (int i=0; i <5; i++)
    //    //{
    //    //    numbers.Add(Convert.ToInt32(Console.ReadLine()));
    //    //}

    //    //foreach(int i in numbers)
    //    //{
    //    //    Console.WriteLine(i);
    //    //}

    //    //var students = new List<Student>()
    //    //{
    //    //    new Student(12,"sujon"),
    //    //    new Student(14,"ali"),
    //    //    new Student(id:12,name:"md"),
    //    //};

    //    //var reult = from s in students
    //    //            where s.Name =="ali"
    //    //            select s;

    //    //foreach (var s in reult)
    //    //{
    //    //    Console.WriteLine(s.Id);
    //    //}

    //}


    //static void Main(string[] args)
    //{
    //    //SortedList
    //    var cities = new SortedList<string, string>()
    //                                {
    //                                    {"London", "UK"},
    //                                    {"New York", "USA"},
    //                                    { "Mumbai", "India"},
    //                                    {"Johannesburg", "South Africa"}
    //                                };

    //    foreach (var c in cities)
    //    {
    //        Console.WriteLine($"City Name:{c.Key} Country Name: {c.Value}");
    //    }

    //}

    //static void Main(string[] args)
    //{
    //    //Dictionary

    //    IDictionary<int, string> numNumber = new Dictionary<int, string>()
    //    {
    //        {1,"first" },
    //        {2,"second" },

    //    };
    //    Console.WriteLine("Before Update");

    //    foreach (var c in numNumber)
    //    {
    //        Console.WriteLine($"Key:{c.Key} Value: {c.Value}");
    //    }

    //    numNumber[1] = "One";

    //    if ( numNumber.ContainsKey(2) )
    //    {
    //        numNumber[2] = "two";
    //    }

    //    Console.WriteLine("After Update");
    //    foreach (var c in numNumber)
    //    {
    //        Console.WriteLine($"Key:{c.Key} Value: {c.Value}");
    //    }
    //}


    //static void Main(string[] args)
    //{
    //    //Hashtable 

    //    Hashtable hashtable = new Hashtable();
    //    hashtable.Add(1, "one");
    //    hashtable.Add(2, "two");

    //    foreach (DictionaryEntry de in hashtable)
    //    {
    //        Console.WriteLine($"Key: {de.Key} Value:{de.Value}");
    //    }
    //}



    static void Main(string[] args)
    {
        //working with dictionary 

        //var student = new List<Student>()
        //{
        //  new Student(id:1,name:"Mr A"),
        //  new Student(id:1,name:"Mr X"),
        //  new Student(id:2,name:"Mr B"),
        //  new Student(id:3,name:"Mr C"),

        //};

        //object list print

        //foreach (var item in student)
        //{
        //    Console.WriteLine($"Student Id:{item.Id} Student Name: {item.Name}");
        //}

        //Dictionary<int, string> dictionary = student.ToDictionary(p=>p.Id, p=>p.Name);

        ////dictionary printing

        //foreach (var item in dictionary)
        //{
        //    Console.WriteLine($"Key:{item.Key} Value: {item.Value}");
        //}

        //Dictionary<int, string> dictionary = new Dictionary<int, string>();

        //foreach (var i in student)
        //{
        //    if (!dictionary.ContainsKey(i.Id))
        //    {
        //        dictionary.Add(i.Id, i.Name);
        //    }

        //    else
        //    {
        //        Console.WriteLine($"Duplicate id for {i.Name}");
        //    }
        //}

        var student = new List<Student>()
        {
          new Student(id:1,name:"Mr A"),
          new Student(id:1,name:"Mr X"),
          new Student(id:2,name:"Mr B"),
          new Student(id:3,name:"Mr C"),
          new Student(id:3,name:"Mr A"),
          new Student(id:1,name:"Mr Y"),

        };

        var dictionary = student
                        .GroupBy(p => p.Id)
                        .ToDictionary(g => g.Key, g => g.First().Name);

      

        foreach (var item in dictionary)
        {
            Console.WriteLine($"Key: {item.Key} Value:{item.Value}");
        }


        //Dictionary<int, List<string>> dictionary = student
        //    .GroupBy(p => p.Id)
        //    .ToDictionary(g => g.Key, g => g.Select(p => p.Name).ToList());





        //foreach (var item in dictionary)
        //{
        //    Console.WriteLine($"Key: {item.Key}");
        //    foreach (var s in item.Value)
        //    {
        //        Console.WriteLine($"Name: {s}");
        //    }
        //}

        ////Display the result
        //foreach (var item in dictionary)
        //{
        //    Console.WriteLine($"Id: {item.Key}, Names: {string.Join(", ", item.Value)}");
        //}


        //var student = new List<Student>()
        //{
        //  new Student(id:1,name:"Mr A"),
        //  new Student(id:1,name:"Mr X"),
        //  new Student(id:2,name:"Mr B"),
        //  new Student(id:3,name:"Mr C"),

        //};

        //var groupByKey= from s in student
        //                group s by s.Id;

        //foreach (var keyGroup in groupByKey )
        //{
        //    Console.WriteLine($" Key Group: {keyGroup.Key}");
        //    foreach(Student s in keyGroup)
        //    {
        //        Console.WriteLine($"Name: {s.Name}");
        //    }
        //}


    }


    //static void Main(string[] args)
    //{
    //    //LINQ in array

    //    // string[] names ={ "Bill", "Steve", "James", "Jhon","bob","Bill" };

    //    // var myLinq = from name in names
    //    //              where name.Length >4
    //    //              select name;

    //    //foreach(var name in myLinq)
    //    // {
    //    //     Console.WriteLine(name);
    //    // }

    //    //Linq in List 

    //    //List<string> stringList = new List<string>()
    //    //{
    //    //    "C# videos",
    //    //    "C blog",
    //    //    "html videos",
    //    //    "java blog",
    //    //};

    //    // var myLinq2 = from item in stringList
    //    //              where item.Contains("C") || item.Contains("java")
    //    //              select item;

    //    // foreach(var item in myLinq2)
    //    // {
    //    //     Console.WriteLine(item);
    //    // }

    //    // Student collection
    //    //List<Student> studentList = new List<Student>() {
    //    //new Student(id : 1, name : "John", age : 13),
    //    //new Student(id : 2, name : "Moin", age : 21),
    //    //new Student(id : 3, name : "Bill", age : 18),
    //    //new Student(id : 4, name : "Ram", age : 20),
    //    //new Student(id : 5, name : "Ron", age : 15),
    //    //};


    //    //var myLinq = from s in studentList   //Linq Query syntax 
    //    //             where s.Age >= 20 && s.Name.Contains("in")
    //    //             select s;

    //    //var myLinq2 = studentList.Where( s => s.Age >= 20 && s.Name.Contains("in")); //Linq Method syntax


    //    //foreach ( var s in myLinq2)
    //    //{
    //    //    Console.WriteLine(s.Name);
    //    //}


    //}
}