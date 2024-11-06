using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Program
    {
        //When a parameter is passed to the method, it is called an argument.

        //with one parameter
        static void Greeting(string name)
        {
            Console.WriteLine($"Wellcome Mr {name} at C# \n");
        }

        //with multiple parameter
        static void GreetingUpdate(string name, int age, string dream)
        {
            Console.WriteLine($"Wellcome Mr {name} to the new world.\nYour are {age} years old.\nYour dream is {dream}\n");
        
        }

        //with default

        static void GreetingDefault(string name="Jhon", int age=45, string dream="Raceing")
        {
            Console.WriteLine($"Wellcome Mr {name} to the new world.\nYour are {age} years old.\nYour dream is {dream} ");

        }

        //with return type
        static int Addition(int a , int b)
        { 
            return a + b;
        }
        static int Xor(int a , int b)
        {
            return (a ^ b);
        }

        //static void Main(string[] args) {
        
        //    //Greeting("Sujon");
        //    //Greeting("Sahab");
        //    //Greeting("Sekh");
        //    //GreetingUpdate(name:"sahab", age:25, dream:"Developer"); //This is named argument with key:value format
        //    //GreetingUpdate("sahab", 25, "Engineer");
        //    //GreetingUpdate("sahab", 25, "Teacher");
        //    //GreetingDefault();
        //    //Console.WriteLine(Xor(1,2)); 

        //}

    }
  
}
