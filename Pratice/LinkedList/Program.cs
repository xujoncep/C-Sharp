using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Link List Node 
            LinkedListNode<string> linkListNode = new LinkedListNode<string>("Alice");

            //Link List 
            LinkedList<string> values = new LinkedList<string> ();
            values.AddFirst ("Jhon");
            values.AddFirst("Bob");
            values.AddLast("HI");
            values.AddLast(linkListNode);
            values.AddBefore(linkListNode, "alice");
            
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            // LinkedList using class
            Node node1 = new Node(1, null);
            Node node2 = new Node(2, null);
            Node node3 = new Node(3, null);



            Console.ReadKey();
        }
    }

    public class Node
    {
        public int data ;
        public Node? next;
       
        public Node(int data, Node next)
        {
             this.data = data;
             this.next = next;
        }

    }
}
