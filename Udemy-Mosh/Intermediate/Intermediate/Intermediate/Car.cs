namespace Intermediate
{
    public class Car: Vehicle
    {

        //public Car()
        //{
        //    Console.WriteLine("Car is being initialized");
        //}
        public Car(string _registrationNumber)
           :base(_registrationNumber)
        {
            Console.WriteLine("Here is the vehicle registration: " + _registrationNumber);  
        }

    }
    
}
 