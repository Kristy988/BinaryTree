using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinaryTree
{
    internal class Program
    {
        public static int index = 3;

        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Add(8);
            tree.Add(1);
            tree.Add(5);
            tree.Add(3);
            tree.Add(2);
            tree.Add(4);
            tree.Add(6);
            tree.Add(7);
            tree.Add(9);

            // tree.Remove(8);
            foreach (var item in tree)
            {
                Console.WriteLine(item);
            }

            //BFS(tree.head);
            Console.ReadKey();
        }
        public static void DFSRecursive(Node node)
        {
            if (index == 0)
            {
                Console.WriteLine(node.Data);
                return;
            }
            if (node.Left != null)
            {
                index--;
                DFSRecursive(node.Left);
            }

            if (node.Right != null)
            {
                index--;
                DFSRecursive(node.Right);
            }
        }

        public static void BFS(Node head)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(head);

            while (queue.Count > 0)
            {
                Node node = queue.Dequeue();
                Console.WriteLine(node.Data);

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }

        }

    }
}
