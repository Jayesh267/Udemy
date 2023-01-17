using System;
namespace Udemy
{
    public class QueueArray
    {
        int[] arr;
        int endOfQueue;
        int beginningOfQueue;

        public QueueArray(int sizeOfQueue)
        {
            arr = new int[sizeOfQueue];
            endOfQueue = -1;
            beginningOfQueue = -1;
            Console.WriteLine("The Queue is successfully created with size of " + sizeOfQueue);
        }

        //Check if the queue is full
        public Boolean isFull()
        {
            if (endOfQueue == arr.Length - 1)
            {
                Console.WriteLine("Queue is full");
                return true;
            }
            else
            {
                Console.WriteLine("Queue is not full");
                return false;
            }
        }

        //Check if the queue is empty
        public Boolean isEmpty()
        {
            if (beginningOfQueue == -1 || beginningOfQueue == arr.Length)
            {
                Console.WriteLine("Queue is empty");
                return true;   
            }
            else
            {
                Console.WriteLine("Queue is not empty");
                return false;
            }
        }

        //enQueue method
        public void enQueue(int value)
        {
            if (isFull())
            {
                Console.WriteLine("Queue is full cannot add new value");
            }                
            else if (isEmpty())
            {
                beginningOfQueue = 0;
                endOfQueue++;
                arr[endOfQueue] = value;
                Console.WriteLine("Value is added in the queue at position " + endOfQueue);
            }
            else
            {
                endOfQueue++;
                arr[endOfQueue] = value;
                Console.WriteLine("Value is added in the queue at position " + endOfQueue);
            }
        }

        //DeQueue method
        public int deQueue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            else
            {
                int result = arr[beginningOfQueue];
                beginningOfQueue++;
                if (beginningOfQueue > endOfQueue)
                {
                    beginningOfQueue = endOfQueue = -1;
                }
                return result;
            }
        }

        //Peek method
        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            else
            {
                return arr[beginningOfQueue];
            }
        }

        //Delete queue
        public void deleteQueue()
        {
            arr = null;
            Console.WriteLine("Queue is successfully deleted");
        }
    }
}