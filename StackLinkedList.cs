using System;

namespace Udemy
{
    public class StackLinkedList
    {
        SinglyLinkedList linkedList;

        public StackLinkedList()
        {
            linkedList = new SinglyLinkedList();   
        }

        //Push method
        public void push(int value)
        {
            linkedList.insertInLinkedList(value, 0);
            Console.WriteLine("Inserted " + value + " in Stack");
        }

        //isEmpty method
        public Boolean isEmpty()
        {
            if (linkedList.head == null)
                return true;
            else
                return false;
        }

        //Pop method
        public int pop()
        {
            int result = -1;
            if (!isEmpty())
            {
                result = linkedList.head.value;
                linkedList.deleteNode(0);
            }                
            else
                Console.WriteLine("Stack is empty");

            return result;
        }

        //Peek method
        public int peek()
        {
            if (!isEmpty())
            {
                return linkedList.head.value;
            }                
            else
                Console.WriteLine("Stack is empty");
                return -1;            
        }

        //Delete method
        public void deleteStack()
        {
            linkedList.head = null;
            Console.WriteLine("Stack is deleted");
        }
    }
}