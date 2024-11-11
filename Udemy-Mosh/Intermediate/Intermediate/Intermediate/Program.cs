namespace Intermediate
{
    partial class Program
    {


        static void Main(string[] args)
        {
            //Person
            //var persion = new Person();
            //persion.Description("Shon");


            ////Customer V1
            //var customer = new Customer();
            //customer.Name = "Alice";
            //customer.Address = "Dhaka";
            //Console.WriteLine($"Customer name:{customer.Name} and Customer address: {customer.Address} ");
            //Console.WriteLine();

            ////Customer V2
            //var customer1 = new Customer() {Name="Bob",Address="Cicago"};  //object initialization syntax
            //Console.WriteLine($"Customer name:{customer1.Name} and Customer address: {customer1.Address} ");
            //Console.WriteLine();


            ////Customer V3
            //var customer2 = new Customer("Alex","Dublin");
            //Console.WriteLine($"Customer name:{customer2.Name} and Customer address: {customer2.Address} ");
            //Console.WriteLine();

            ////Customer V4
            //var customer3 = new Customer(address: "London", name: "Siri");
            //Console.WriteLine($"Customer name:{customer3.Name}  and Customer address:  {customer3.Address} ");
            //Console.WriteLine();
            //Console.ReadKey();  

            //var calculator = new ArrayCalculator();
            //Console.WriteLine(calculator.Add(1,2));
            //Console.WriteLine(calculator.Add(1,22,4422));
            //Console.WriteLine(calculator.Add(2323,2342,3212,122));
            //Console.WriteLine(calculator.Add(223,22,3,3,33,33,3,3,33333,33));

            //simple exception 

            //try
            //{
            //    int number;
            //    //int.Parse("abc");
            //    int.TryParse("abc",out number);
            //    Console.WriteLine("success");

            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("error occur");
            //}


            //readonly field
            //var customer = new Customer(id: 1, name: "jhon");
            //customer.Orders.Add(new Order());
            //customer.Orders.Add(new Order());
            ////customer.Promote();
            //Console.WriteLine(customer.Orders.Count);

            //Access Modifier private
            //var person = new Person();
            //person.SetBirthdate(DateTime.Now);
            //Console.WriteLine(person.GetBirthdate());


            ////get set properties
            //var person = new Person(new DateTime(1998, 12, 12));
            //Console.WriteLine(person.Age);

            
            //indexer example

            //var cookie = new HttpCookie();
            //cookie["name"] = "jhon";
            //Console.WriteLine(cookie["name"]);


            //stopwatch without readonly
            
            //var timespan = new StopWatch();
            //timespan.Start();

            //Console.WriteLine("Press any key to Stop....");
            //Console.ReadKey();
            //var stop = timespan.Stop();

            //Console.WriteLine( timespan.GetTime(timespan.StartTime, stop));


            //stopwatch with readonly

            var stopwatch = new StopWatch();

            Console.WriteLine("Press any Key to start:");
            Console.ReadKey();
            stopwatch.Start();
            Console.WriteLine("Your Stop Watch is running. Press Any key to stop:");
            Console.ReadKey();
            Console.WriteLine("Congratulation! Your Stopwatch time is:" + stopwatch.Duiration);



        }

    }
    
}
