namespace Intermediate
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized");
        //}

        public Vehicle( string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Here is the vehicle registration: "+ _registrationNumber);
        }
    }
    
}
 