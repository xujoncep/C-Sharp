namespace Intermediate
{ 
  public class Customer
    {
        public string Name;
        public string Address;

        public Customer()
        {
                
        }

        public Customer(string name)
        {
            this.Name = name;

        }

        public Customer(string name, string address)
        {
            this.Name = name;
            this.Address = address;

        }

    }
}
