using System.IO;
namespace OOP
{
    class Bike
{
    public string company;
    public string model;
    public string year;

    public Bike(string Bikecompany, string Bikemodel, string Bikeyear)
    {
        company = Bikecompany;
        model = Bikemodel;
        year = Bikeyear;
    }


}
class Car
{
    string color = "red";  //Fields and methods inside classes are often referred to as "Class Members":
    int speed = 5;         //A static method can be accessed without creating an object of the class,
                           //while public methods can only be accessed by objects.
    public void Info()
    {
        Console.WriteLine("This is a expensive car.");
    }
    //Note that the constructor name must match the class name, and it cannot have a return type(like void or int).
    //Also note that the constructor is called when the object is created.
    //All classes have constructors by default: if you do not create a class constructor yourself, C# creates one for you. However,
    //then you are not able to set initial values for fields.

}

class Vehicle
{
    public string name = "car";
    public void Info()
    {
        Console.WriteLine(" car is running");
    }
}

class Bmw:Vehicle
{
    public string name = "BmwCar";
    public string model = "bmw";
}

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("This is animal sound.");
    }
}

class Goat:Animal
{
    public override void Sound()
    {
        Console.WriteLine("This is goat sound.");
    }
}

class Dog:Animal
{
    public override void Sound()
    {
        Console.WriteLine("This is dog sound.");
    }
}


    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car(); //A constructor is a special method that is used to initialize objects. 
            //Console.WriteLine(car.color);
            //car.Info();

            //Bike cbr = new Bike("Honda", "cbr", "2022");

            //Console.WriteLine($"This is bike.\nCompany name is:{cbr.company}.\nModel is {cbr.model}.\nYear is {cbr.year}");

            //Bmw bike = new Bmw();

            //Console.WriteLine($"this is the name:{bike.name}");
            //bike.Info();

            //Animal animal = new Animal();
            //Animal dog = new Dog();
            //Animal goat = new Goat();

            //animal.Sound();
            //dog.Sound();
            //goat.Sound();

            //Sound sound = new Sound(); //we cannot create instance of the abstracta class

            //AnimalSound sound = new AnimalSound();
            //    sound.Sleep();
            //    sound.Lazy();

            //Interface

            //Cow cow = new Cow();
            //    cow.Sound();
            //    cow.Run();
            //string MyText = "this is a file text";
            //string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //string filepath = Path.Combine(folderPath, "file.txt");
            
            //File.WriteAllText(filepath, MyText);

        }

    }
}