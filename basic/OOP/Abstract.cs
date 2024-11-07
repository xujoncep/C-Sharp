using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Sound
    {
        public virtual void Lazy()
        {
            Console.WriteLine("Lazy Base class");
        }
        public abstract void Sleep();
       


    }

    class AnimalSound: Sound
    {
        public override void Sleep()
        {
            Console.WriteLine("This is child class");

        }

    }
}
