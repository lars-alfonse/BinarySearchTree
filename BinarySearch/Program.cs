using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            List<Node<int>> nodes = new List<Node<int>>();
            tree.AddNode(new Node<int>(38));
            tree.AddNode(new Node<int>(38));
            tree.AddNode(new Node<int>(30));
            tree.AddNode(new Node<int>(38));
            //for (int i = 0; i < 100; i++)
            //{
            //    Node<int> node = new Node<int>(random.Next(1, 100));
            //    nodes.Add(node);
            //}
            //foreach (Node<int> node in nodes)
            //{
            //    tree.AddNode(node);
            //}
            tree.Display();
            Console.WriteLine(tree.Search(25));
            Console.ReadLine();
        }
    }
}
