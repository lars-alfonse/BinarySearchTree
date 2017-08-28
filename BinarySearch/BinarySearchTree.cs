using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearchTree<T> where T : IComparable
    {
        private Node<T> root;



        public void AddNode(Node<T> node)
        {
            if (root == null)
            {
                root = node;
            }
            else if (node.data.CompareTo(root.data) < 0)
            {
                if (root.rightChild == null)
                {
                    root.rightChild = node;
                }
                else
                {
                    AddNode(node, root.rightChild);
                    return;
                }
            }
            else if (node.data.CompareTo(root.data) > 0)
            {
                if (root.leftChild == null)
                {
                    root.leftChild = node;
                }
                else
                {
                    AddNode(node, root.leftChild);
                    return;
                }
            }
        }
        public void AddNode(Node<T> node, Node<T> check)
        {
            if (check == null)
            {
                check = node;
            }
            else if (node.data.CompareTo(check.data) < 0)
            {
                if (check.rightChild == null)
                {
                    check.rightChild = node;
                }
                else
                {
                    AddNode(node, check.rightChild);
                    return;
                }
            }
            else if (node.data.CompareTo(check.data) > 0)
            {
                if (check.leftChild == null)
                {
                    check.leftChild = node;
                }
                else
                {
                    AddNode(node, check.leftChild);
                    return;
                }
            }
        }
        public void Display()
        {
            Display(root, 0);
            Console.WriteLine();
        }
        public void Display(Node<T> node, int level)
        {
            if (node == null)
            {
                return;
            }

            Display(node.rightChild, level + 1);
            Console.WriteLine();

            for (int i = 0; i < level; i++)
            {
                Console.Write("    ");
            }
            Console.Write(node.data);

            Display(node.leftChild, level + 1);
        }
        public bool Search(T item)
        {
            if (root == null)
            {
                return false;
            }
            else if (root.data.CompareTo(item) == 0)
            {
                return true;
            }
            else if (item.CompareTo(root.data) < 0 && root.rightChild != null)
            {
                return Search(item, root.rightChild);
            }
            else if (item.CompareTo(root.data) > 0 && root.leftChild != null)
            {
                return Search(item, root.leftChild);
            }
            else
            {
                return false;
            }
        }
        private bool Search(T item, Node<T> check)
        { 
            if (check.data.CompareTo(item) == 0)
            {
                return true;
            }
            else if (item.CompareTo(check.data) < 0 && check.rightChild != null)
            {
                return Search(item, check.rightChild);
            }
            else if (item.CompareTo(check.data) > 0 && check.leftChild != null)
            {
                return Search(item, check.leftChild);
            }
            else
            {
                return false;
            }
        }
    }
}
