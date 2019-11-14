using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;


namespace LearningDotNet
{
    class Program
    {
        static void Main(string[] args)
        {

            // Hello World
            Console.WriteLine("Hello World!\n");


            // Lists
            List<String> customers = new List<string>();
            customers.Add("Kim");
            customers.Add("John");
            customers.Add("Tim");

            Console.WriteLine(customers.Count + "\n");
           

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("\n" + customers[1] + "\n");

            // Dictionary
            Dictionary<String, String> config = new Dictionary<string, string>();
            config.Add("resolution", "1920x1080");
            config.Add("title", "MyWebsite");

            Console.WriteLine(config["title"] + "\n");

            foreach (var setting in config)
            {
                Console.WriteLine(setting.Value);
            }

            Console.WriteLine("\n");

            // Array Lists (Deprecated, replaced by Lists)
            ArrayList list = new ArrayList();
            list.Add("some string");
            String s = (string)list[0];
            Console.WriteLine(s.Length + "\n");


            // Hash Table (replaced by Dictionary)
            Hashtable table = new Hashtable();
            table.Add("title", "MyWebsite");
            Console.WriteLine(table["title"]);
            var s1 = (String)table["title"];
            Console.WriteLine(s1.Length + "\n");


        }

    }
}
