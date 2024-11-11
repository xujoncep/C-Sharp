namespace Intermediate
{ 
  public class Customer
    {
        public int Id;
        public string Name;
        public string Address;
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Customer(int id, string name, string address)
         : this(id,name)
        {
            this.Address = address;
        }

        public void Promote()
        {
            //Orders = new List<Order> (); 
        }

    }
}
