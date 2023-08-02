using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment21
{
    internal class Program
    {
        public static void Days(List<string> days)
        {
            foreach (string day in days)
            {
                Console.WriteLine(day);
                Thread.Sleep(2000);
            }
        }
        public static void Months(List<string> months)
        {
            foreach (string month in months)
            {
                Console.WriteLine(month);
                
            }
        }
        public static void Fruits(List<string> fruits)
        {
            foreach(string fruit in fruits) { Console.WriteLine(fruit);Thread.Sleep(2000); }
        }
        public static void Meaning(Dictionary<string, string> means)
        {
            foreach(var mean in means)
            {
                Console.WriteLine(mean);
                
            }
        }
        static void Main(string[] args)
        {
            List<string> days = new List<string> { "sunday","monday","tuesday","wednesday","Thursday","Friday","saturday"};
            List<string> months = new List<string>
            {
                "Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"
            };
            List<string> fruits = new List<string>
            { "Apple", "Banana", "Orange", "Grapes", "Watermelon", "Strawberry", "Mango", "Pineapple", "Cherry", "Kiwi" };
            Dictionary<string, string> meaning = new Dictionary<string, string>
            {
                { "Happy", "Feeling or showing pleasure or contentment." },
                { "Brave", "Ready to face and endure danger or pain; showing courage." },
                { "Beautiful", "Pleasing the senses or mind aesthetically." },
                { "Friend", "A person with whom one has a bond of mutual affection." },
                { "Explore", "Travel through (an unfamiliar area) in order to learn about it." }
            };
            Thread thread1 = new Thread(() => Days(days));
            Thread thread2 = new Thread(() => Months(months));
            Thread thread3= new Thread(() => Fruits(fruits));
            Thread thread4=new Thread(() => Meaning(meaning));
            Console.WriteLine("-------------------Welcome to Learning--------------------");
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread1.Join();
            thread2.Join();
            thread3.Join();
            thread4.Join();
            Console.WriteLine("End program");
            Console.ReadKey();
        }
    }
}
