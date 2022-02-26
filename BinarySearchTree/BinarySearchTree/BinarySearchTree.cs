using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        public T data;
        public BinarySearchTree<T> left;
        public BinarySearchTree<T> right;

        public BinarySearchTree(T Data)
        {
            this.data = Data;
            left = null;
            right = null;
        }

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

        


        

     

