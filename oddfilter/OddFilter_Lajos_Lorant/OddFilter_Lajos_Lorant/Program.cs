using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddFilter_Lajos_Lorant
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an OddFilter function that takes a list as a parameter,
            // and returns a new list with every odd element from the orignal list
            List<int> oddElements = OddFilter(new List<int> { 1, 2, 3, 4, 5 });

            // In case of the example input above, the given PrintList function should print 1 3 5 
            PrintList(oddElements);

            Console.ReadLine();
        }

        private static void OddFilter(List<int> list)
        {
            List<int> OriginalList = new List<int> { };
            List<int> oddElements = new List<int> { };
        
        for (int i = 0; i < OriginalList.Count; i++)
			{
            if (OriginalList[i]%2 != 0)
	        {
             oddElements.Add(OriginalList(i));
	        }
            }
         return new List<int>(oddElements);
        }

        private static void PrintList(List<int> list)        
        {
        foreach (int element in OriginalList)
            {
            Console.Write("{0} ", element);
            }
        }

     }   
}
