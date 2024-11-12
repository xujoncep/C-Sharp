//bool check = false;
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

partial class Program
{
    struct PointStruct
    {
        public int no1, no2;

        public PointStruct(int n1, int n2)
        {
            this.no1 = n1;
            this.no2 = n2;
        }

        public void Show()
        {
            Console.WriteLine($"First Number: {this.no1} Second Number: {this.no2}");

        }
    }
}