using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace BinaryTree
{
    internal class Tree : IEnumerable
    {
        public Node head = null;
        public int Count;
        public int value = 0;
        int findIndex = 0;
        Node findNode = null;

        public int this[int index]
        {
            get
            {

                if (index == 0)
                {
                    return head.Data;
                }
                if (index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                findIndex = index;
                findNode = head;
                RecursiveNode(findNode);
                return findNode.Data;
            }

        }

        public void RecursiveNode(Node node)
        {
            if (findIndex <= 0)
            {
                findNode = node;
                return;
            }
            if (node.Left != null)
            {
                findIndex--;
                RecursiveNode(node.Left);
            }

            if (node.Right != null && findIndex > 0)
            {
                findIndex--;
                RecursiveNode(node.Right);
            }
        }

        public void Add(int data)
        {
            head = AddRecursive(head, data);
            Count++;
        }

        public Node AddRecursive(Node node, int data)
        {

            if (node == null)
                return new Node(data);

            if (node.Data > data)
            {
                node.Left = AddRecursive(node.Left, data);
            }
            else
            {
                node.Right = AddRecursive(node.Right, data);
            }
            return node;

        }

        public void Remove(int data)
        {
            head = RemoveRecursive(head, data);
            Count--;
        }


        public Node FindMin(Node node)
        {
            Node minNode = node;
            while (minNode.Left != null)
            {
                minNode = minNode.Left;
            }

            return minNode;
        }

        public Node RemoveRecursive(Node node, int data)
        {

            if (node == null)
                return null;
            //    return new Node(data);

            if (node.Data > data)
            {
                node.Left = RemoveRecursive(node.Left, data);
            }
            else if (node.Data < data)
            {
                node.Right = RemoveRecursive(node.Right, data);

            }
            else
            {
                if (node.Right == null)
                {
                    return node.Left;
                }
                if (node.Left == null)
                {
                    return node.Right;
                }

                Node minNode = FindMin(node.Right);
                node.Data = minNode.Data;
                node.Right = RemoveRecursive(node.Right, minNode.Data);

            }
            return node;

        }

        public IEnumerator GetEnumerator()
        {
            IEnumerator BFS = new BFS(this);
            return BFS;

        }
    }
}

