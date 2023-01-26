using System;
namespace Udemy
{
    public class QueueLinkedList
    {
        SinglyLinkedList list;
        public QueueLinkedList()
        {
            list = new SinglyLinkedList();
            Console.WriteLine("The queue is successfully created");
        }

        //isEmpty method
        public Boolean isEmpty()
        {
            if (list.head == null)
                return true;
            else
                return false;
        }

        //enQueue method
        public void enQueue(int value)
        {
            list.insertInLinkedList(value, list.size);
            Console.WriteLine("Successfully inserted "+ value + " in the queue");
        }

        //deQueue method
        public int deQueue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty, cannot perform delete function");
                return -1;
            }
            else
            {
                int returnedNode = list.head.value;
                list.deleteNode(0);
                return returnedNode;
            }
        }

        //peek method
        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty, cannot perform delete function");
                return -1;
            }
            else
            {
                int returnedNode = list.head.value;                
                return returnedNode;
            }
        }

        //Delete queue method
        public void deleteQueue()
        {
            list.head = null;
            list.tail = null;
            Console.WriteLine("Queue is successfully deleted!!");
        }
    }
}