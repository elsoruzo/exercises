using System;

namespace data_structures.Lists.SLinkedListQueueModel
{
    public class SlinkedListQNode
    {
        public int key;
        public SlinkedListQNode next;

        // constructor to create 
        // a new linked list node 
        public SlinkedListQNode(int key)
        {
            this.key = key;
            this.next = null;
        }
    }
}
