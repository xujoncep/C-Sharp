using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Fundamental
{
    class Program
    {
        class enumClass
        {
            public enum Level
            {
                low,
                medium,
                high

            }

        }
        static void Main(string[] args)
        {
            //with static method
            //int result = Calculator.AddStatic(5, 4);
            //Console.WriteLine(result);

            //with object
            //var calculator = new Calculator();
            //int result = calculator.Add(7, 4);
            //Console.WriteLine(result);

            //with strings formater

            //string firstName = "Md. Sahabuddin";
            //string lastName = "Hosssain";
            ////string fullName = string.Format("{0} {1}", firstName, lastName);
            ////Console.WriteLine(fullName);
            //Console.WriteLine("My name is {0} {1}",firstName,lastName);
            //Console.WriteLine($"My name is {firstName} {lastName}");

            // string are immutable 

            //verbatim string
            //var VerbatimString = @"c:\projects\myproject\folder ";

            //Console.WriteLine(VerbatimString);

            //String name = "mr x";
            //Console.WriteLine(name);

            //var names = new string[] { "jhon", "bob", "alice" };

            //var allNames = string.Join(" ", names);
            //Console.WriteLine($"all names are {allNames}");


            //enum should be use where a number of related constant are 

            //var MyLevel = enumClass.Level.high;
            //Console.WriteLine(MyLevel); // string value
            //Console.WriteLine((int)MyLevel); // int value

            //all primitive are structure

            //arrys, strings, custom classes are non primitives

            // structure are value types and classes are reference type


            //call by value
            //var a = 10;
            //var b = a;
            //b++;

            //Console.WriteLine($"a={a} b={b}");

            
            //// call by reference
            //var arry1 = new int[] { 4, 4, 5, 8 };
            //var arry2 = arry1;
            //arry2[0] = 1;

            //Console.WriteLine($"The first arry element: {arry1[0]}");
            //Console.WriteLine($"The second arry element: {arry2[0]}");




        }
    }
}