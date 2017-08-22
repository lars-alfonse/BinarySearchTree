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
            else if (node.data.CompareTo(root.data) > 0)
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
            else if (node.data.CompareTo(root.data) < 0)
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
            else if (node.data.CompareTo(check.data) > 0)
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
            else if (node.data.CompareTo(check.data) < 0)
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
    }
}
