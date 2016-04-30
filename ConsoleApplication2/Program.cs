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
            List<int> myList = new List<int>();
            myList.Add(3);
            myList.Add(14);
            myList.Add(71);
            Console.Write ("List: ");

            for (int i = 1; i < myList.Count; i++)
            {
                Console.Write( "{0}, ", myList[i]);
            }

            Console.WriteLine("{0}.", myList.Last());
            Console.ReadKey();
           
        }

       
    }
}
