using System;
namespace Udemy
{
    public class QueueArray
    {
        int[] arr;
        int topOfQueue;
        int beginningOfQueue;

        public QueueArray(int sizeOfQueue)
        {
            arr = new int[sizeOfQueue];
            topOfQueue = -1;
            beginningOfQueue = -1;
            Console.WriteLine("The Queue is successfully created with size of " + sizeOfQueue);
        }

        //Check if the queue is full
        public Boolean isFull()
        {
            if (topOfQueue == arr.Length - 1)
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
                topOfQueue++;
                arr[topOfQueue] = value;
                Console.WriteLine("Value is added in the queue at position " + topOfQueue);
            }
            else
            {
                topOfQueue++;
                arr[topOfQueue] = value;
                Console.WriteLine("Value is added in the queue at position " + topOfQueue);
            }
        }
    }
}