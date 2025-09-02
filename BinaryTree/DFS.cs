using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class DFS : System.Collections.IEnumerator
    {
        Tree tree = null;
        private int index = -1;
        public DFS(Tree tree)
        {
            this.tree = tree;
        }

        public object Current
        {
            get { return tree[index]; }
        }


        public bool MoveNext()
        {
            index++;
            return index >= tree.Count ? false : true;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
