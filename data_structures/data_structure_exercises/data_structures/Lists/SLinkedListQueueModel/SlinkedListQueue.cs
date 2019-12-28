using System;

namespace data_structures.Lists.SLinkedListQueueModel
{
    // A class to represent a queue The queue, 
    // front stores the front node of LL and 
    // rear stores the last node of LL 
    public class SlinkedListQueue
    {

        SlinkedListQNode front, rear;

        public SlinkedListQueue()
        {
            this.front = this.rear = null;
        }

        // Method to add an key to the queue. 
        public void enqueue(int key)
        {

            // Create a new LL node 
            SlinkedListQNode temp = new SlinkedListQNode(key);

            // If queue is empty, then new 
            // node is front and rear both 
            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }

            // Add the new node at the 
            // end of queue and change rear 
            this.rear.next = temp;
            this.rear = temp;
        }

        // Method to remove an key from queue. 
        public SlinkedListQNode dequeue()
        {
            // If queue is empty, return NULL. 
            if (this.front == null)
                return null;

            // Store previous front and 
            // move front one node ahead 
            SlinkedListQNode temp = this.front;
            this.front = this.front.next;

            // If front becomes NULL, 
            // then change rear also as NULL 
            if (this.front == null)
                this.rear = null;
            return temp;
        }
    }
}
