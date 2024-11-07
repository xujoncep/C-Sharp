using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    interface IAnimal
    {
        void Sound();
        void Run();
    }

    class Cow : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("This is cow sound.");

        }

       public  void Run()
        { 
        Console.WriteLine("cow is running");
        }
    }
}
