using System;
namespace Udemy
{
    public class CircularQueue
    {
        int topOfQueue;
        int beginningOfQueue;
        int[] arr;
        int size;

        public CircularQueue(int size)
        {
            arr = new int[size];
            this.size = size;
            this.topOfQueue = -1;
            this.beginningOfQueue = -1;
            Console.WriteLine("Circular queue is successfully created with size of " + size);
        }

        //Check if the circular queue is empty
        public Boolean isEmpty()
        {
            if (topOfQueue == -1 || beginningOfQueue == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Check if the circular queue is full
        public Boolean isFull()
        {
            if (beginningOfQueue == 0 && topOfQueue + 1 == size)
            {
                return true;
            }
            else if (beginningOfQueue == topOfQueue + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //enQueue method
        public void enQueue(int value)
        {
            if (isFull())
            {
                Console.WriteLine("Circular queue is full");
            }
            else if (isEmpty())
            {
                beginningOfQueue = 0;
                topOfQueue++;
                arr[topOfQueue] = value;
                Console.WriteLine("Added value at position " + topOfQueue);
            }
            else
            {
                if (topOfQueue + 1 == size)
                {
                    topOfQueue = 0;
                }
                else
                {
                    topOfQueue++;
                }
                arr[topOfQueue] = value;
                Console.WriteLine("Added value at position " + topOfQueue);
            }
        }
    }
}