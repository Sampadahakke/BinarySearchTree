using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        //Variables
        public T data;
        public BinarySearchTree<T> left;
        public BinarySearchTree<T> right;

        //Creating constructor of class to initialize 
        public BinarySearchTree(T Data)
        {
            this.data = Data;
            left = null;
            right = null;
        }

        //Creating method to insert  items
        public void Insert(T item)
        {
            if (this.data.CompareTo(item) > 0)
            {
                if (left != null)
                    left.Insert(item);
                else
                    left = new BinarySearchTree<T>(item);
            }
            else if (right != null)
            {
                right.Insert(item);
            }
            else
                right = new BinarySearchTree<T>(item);

        }

        //Creating method to display the nodes
        public void Display()
        {
           
            if (left != null)
                left.Display();

            Console.Write(data + " ");

            if (right != null)
                right.Display();
        }

    }
}

        


        

     

