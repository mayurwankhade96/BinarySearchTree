using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Binary Search Tree Program!");

            // Creating object
            BinarySearchTree<int> tree = new BinarySearchTree<int>(56);

            tree.Insert(30);
            tree.Insert(70);
            tree.DisplayBST();
        }
    }
}
