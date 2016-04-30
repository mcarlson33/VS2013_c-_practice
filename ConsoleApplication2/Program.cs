using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // First, try with key => value pairs.  
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("tiger", 32);
            myDictionary.Add("grass", 1);
            myDictionary.Add("lamp", 20);
            Console.Write("Dictionary: ");

            foreach(var key in myDictionary)
            {
                Console.Write(key + " ");
            }
            Console.WriteLine();

            try
            {
                Console.WriteLine("For key = \"tiger\", value = {0}.", myDictionary["tiger"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key not found.");
            }

            Console.ReadKey();
           
        }

        public void ListTest()
        {
            List<int> myList = new List<int>();
            myList.Add(3);
            myList.Add(14);
            myList.Add(71);
            Console.Write("List: ");

            for (int i = 1; i < myList.Count; i++)
            {
                Console.Write("{0}, ", myList[i]);
            }

            Console.WriteLine("{0}.", myList.Last());
            Console.ReadKey();
        }
    }
}
