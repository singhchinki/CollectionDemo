using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class Program
    {
         static void  Main(string[] args)
        { 
            Console.WriteLine("Welcome to C# Collections");
            doListDemo();
        }
        private static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            List<string> list = new List<string>();
            list.Add("chinki");
            list.Add("suraj");
            list.Add("ravi");
            list.Add("ram");
            //Itreating List elements
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }

}