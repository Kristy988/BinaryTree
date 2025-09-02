using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class BFS : System.Collections.IEnumerator
    {
        Tree tree = null;
        Queue<Node> queue = new Queue<Node>();

        public BFS(Tree tree)
        {
            this.tree = tree;
            queue.Enqueue(tree.head);

        }

        public object Current
        {
            get
            {
                Node node = queue.Dequeue();
                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
                return node.Data;
            }
        }


        public bool MoveNext()
        {
            return queue.Count > 0;
        }

        public void Reset()
        {

        }
    }
}
