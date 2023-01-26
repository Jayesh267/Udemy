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

        //deQueue method
        public int deQueue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty!!");
                return -1;
            }
            else
            {
                int result = arr[beginningOfQueue];
                arr[beginningOfQueue] = System.Int32.MinValue;
                if (beginningOfQueue == topOfQueue)
                {
                    beginningOfQueue = topOfQueue = -1;
                }
                else if (beginningOfQueue + 1 == size)
                {
                    beginningOfQueue = 0;
                }
                else
                {
                    beginningOfQueue++;
                }
                return result;
            }
        }

        //Peek method
        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty!!");
                return -1;
            }
            else
            {
                int result = arr[beginningOfQueue];
                Console.WriteLine(result);
                return result;
            }
        }

        //Delete queue
        public void deleteQueue()
        {
            arr = null;
            Console.WriteLine("Circular queue is successfully deleted!!");
        }
    }
}