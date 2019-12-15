using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures.Trees
{
    /* Class containing LeftNode and RightNode  
    child of current node and key value*/
    public class BinaryTreeNode
    {
        public int Value;
        public int Counter = 0;
        public BinaryTreeNode LeftNode, RightNode;

        public BinaryTreeNode(int item)
        {
            Value = item;
            LeftNode = RightNode = null;
            Counter++;
        }
    }
}
