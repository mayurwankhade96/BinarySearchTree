using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }

        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }

        int leftCount = 0, rightCount = 0;
        bool result = false;

        /// <summary>
        /// Method to insert node to binary search tree
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(item) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    this.LeftTree.Insert(item);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    this.RightTree.Insert(item);
                }
            }
        }

        /// <summary>
        /// Method to get size of binary search tree
        /// </summary>
        public void GetSize()
        {
            Console.WriteLine("Size : " + (1 + this.leftCount + this.rightCount));
        }

        /// <summary>
        /// Method to display binary search tree
        /// </summary>
        public void DisplayBST()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.DisplayBST();
            }
            Console.WriteLine(this.NodeData.ToString());

            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.DisplayBST();
            }
        }

        /// <summary>
        /// Method to search element in binary search tree
        /// </summary>
        /// <param name="element"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool Search(T element, BinarySearchTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Element found " + node.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is " + node.NodeData + " in BST");
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                Search(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                Search(element, node.RightTree);
            }
            return result;
        }
    }
}
