using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; } = null;
        public Node Right { get; set; } = null;
        public Node(int Data)
        {
            this.Data = Data;
        }
    }
}
