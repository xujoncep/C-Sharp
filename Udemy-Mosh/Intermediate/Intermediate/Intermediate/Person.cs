namespace Intermediate
{
    public class Person
    {
        //auto implemented property in the top 
        public string Name;
        public DateTime Birthdate { get; private set; } //this property no longer be changed

        // constructor is here
        public Person(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }

        // calculated property is here
        public int Age 
        { 
         get
           {
                var timespan = DateTime.Now - Birthdate;
                var years = timespan.Days / 365;
                return years;
           }
        
        }

       
        //private DateTime _birthdate;

        //public void SetBirthdate(DateTime birthdate)
        //{
        //    this._birthdate = birthdate;
        //}

        //public DateTime GetBirthdate()
        //{
        //    return _birthdate;
        //}
        public void Description(string Name="jhon")
        {
            Console.WriteLine($" Hey! Welcome Mr {Name}");
        }


    }

    
}
