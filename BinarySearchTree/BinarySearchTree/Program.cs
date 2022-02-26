using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating object of class
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);
            Console.Write("Items in Binary search tree = ");
            binarySearch.Display();
            Console.WriteLine();    
            Console.WriteLine("\xAIs 16 present in tree ? ");
            Console.WriteLine("Searching for item.....");
            Console.WriteLine("Answer = " + binarySearch.Search(16));
            Console.ReadKey();
        }
    }
}
