namespace Intermediate
{


    partial class Program
    {

        //section-2-clases

        //static void Main(string[] args)
        //{
        //    //Person
        //    //var persion = new Person();
        //    //persion.Description("Shon");


        //    ////Customer V1
        //    //var customer = new Customer();
        //    //customer.Name = "Alice";
        //    //customer.Address = "Dhaka";
        //    //Console.WriteLine($"Customer name:{customer.Name} and Customer address: {customer.Address} ");
        //    //Console.WriteLine();

        //    ////Customer V2
        //    //var customer1 = new Customer() {Name="Bob",Address="Cicago"};  //object initialization syntax
        //    //Console.WriteLine($"Customer name:{customer1.Name} and Customer address: {customer1.Address} ");
        //    //Console.WriteLine();


        //    ////Customer V3
        //    //var customer2 = new Customer("Alex","Dublin");
        //    //Console.WriteLine($"Customer name:{customer2.Name} and Customer address: {customer2.Address} ");
        //    //Console.WriteLine();

        //    ////Customer V4
        //    //var customer3 = new Customer(address: "London", name: "Siri");
        //    //Console.WriteLine($"Customer name:{customer3.Name}  and Customer address:  {customer3.Address} ");
        //    //Console.WriteLine();
        //    //Console.ReadKey();  

        //    //var calculator = new ArrayCalculator();
        //    //Console.WriteLine(calculator.Add(1,2));
        //    //Console.WriteLine(calculator.Add(1,22,4422));
        //    //Console.WriteLine(calculator.Add(2323,2342,3212,122));
        //    //Console.WriteLine(calculator.Add(223,22,3,3,33,33,3,3,33333,33));

        //    //simple exception 

        //    //try
        //    //{
        //    //    int number;
        //    //    //int.Parse("abc");
        //    //    int.TryParse("abc",out number);
        //    //    Console.WriteLine("success");

        //    //}
        //    //catch (Exception)
        //    //{

        //    //    Console.WriteLine("error occur");
        //    //}


        //    //readonly field
        //    //var customer = new Customer(id: 1, name: "jhon");
        //    //customer.Orders.Add(new Order());
        //    //customer.Orders.Add(new Order());
        //    ////customer.Promote();
        //    //Console.WriteLine(customer.Orders.Count);

        //    //Access Modifier private
        //    //var person = new Person();
        //    //person.SetBirthdate(DateTime.Now);
        //    //Console.WriteLine(person.GetBirthdate());


        //    ////get set properties
        //    //var person = new Person(new DateTime(1998, 12, 12));
        //    //Console.WriteLine(person.Age);

            
        //    //indexer example

        //    //var cookie = new HttpCookie();
        //    //cookie["name"] = "jhon";
        //    //Console.WriteLine(cookie["name"]);


        //    //stopwatch without readonly
            
        //    //var timespan = new StopWatch();
        //    //timespan.Start();

        //    //Console.WriteLine("Press any key to Stop....");
        //    //Console.ReadKey();
        //    //var stop = timespan.Stop();

        //    //Console.WriteLine( timespan.GetTime(timespan.StartTime, stop));


        //    //stopwatch with readonly

        //    //var stopwatch = new StopWatch();

        //    //Console.WriteLine("Press any Key to start:");
        //    //Console.ReadKey();
        //    //stopwatch.Start();
        //    //Console.WriteLine("Your Stop Watch is running. Press Any key to stop:");
        //    //Console.ReadKey();
        //    //Console.WriteLine("Congratulation! Your Stopwatch time is:" + stopwatch.Duiration);


        //    //Posting Exercise

        //    //var post = new Post(title:"FistPost",description:"This is a post description", postTime:DateTime.Now);

        //    //post.Votes.Add(new Vote());
        //    //post.Votes.Add(new Vote());
        //    //post.Votes.Add(new Vote());
        //    //post.Votes.Add(new Vote());
        //    //Console.WriteLine("Number of vote is: "+post.Votes.Count);

        //}

        
        
        
        //section-3-association

        //static void Main(string[] args)
        //{
        //    //Inheritence example 

        //    //var text = new Text();
        //    //text.Copy();

            
        //    //Composition

        //    //var dbmigrator = new DbMigrator(new Logger());
        //    //var logger = new Logger();
        //    //var installer = new Installer(logger);

        //    //dbmigrator.Migrate();
        //    //installer.Install();

        //}



        //section-4
        static void Main(string[] args)
        {
            //var car = new Car();
            //var car2 = new Car("XYZ123");

            ////up casting
            //var textshape = new TextShape();
            //Shape shape = textshape; //typecasting
            //textshape.Width = 200;
            //shape.Width= 100;
            //Console.WriteLine(textshape.Width); //typecasting 

            //downcasting 

            //Shape shape = new TextShape();
            //TextShape text = (TextShape)shape;
            

            
        }
    }
    
}
 