using System;

namespace Udemy
{
    public class DoublyLinkedList
    {
        public DoublyNode head;
        public DoublyNode tail;
        int size;

        public DoublyNode createDoublyLinkedList(int nodeValue)
        {
            DoublyNode doublyNode = new DoublyNode();
            doublyNode.next = null;
            doublyNode.prev = null;
            doublyNode.value = nodeValue;
            head = doublyNode;
            tail = doublyNode;
            size = 1;
            return head;
        }

        public void insertNodeInDLL(int location, int nodeValue)
        {
            if (head != null)
            {
                DoublyNode newNode = new DoublyNode();
                newNode.value = nodeValue;
                if (location == 0)
                {
                    newNode.next = head;
                    newNode.prev = null;
                    head.prev = newNode;
                    head = newNode;                    
                }
                else if (location >= size)
                {
                    tail.next = newNode;
                    newNode.prev = tail;
                    newNode.next = null;
                    tail = newNode;
                }
                else
                {
                    DoublyNode tempNode = head;
                    for (int i=0; i<location-1; i++)
                    {
                        tempNode = tempNode.next;
                    }
                    newNode.next = tempNode.next;
                    tempNode.next = newNode;
                    newNode.next.prev = newNode;
                    newNode.prev = tempNode;
                }
                size++; 
            }
            else
            {
                createDoublyLinkedList(nodeValue);
                return;
            }
        }

        public void traverseDLL()
        {
            if (head != null)
            {
                DoublyNode newNode = head;
                for (int i=0; i<size; i++)
                {
                    Console.Write(newNode.value);
                    newNode = newNode.next;
                    if (i<size-1)
                    {
                        Console.Write(" -> ");
                    }
                }
            }
            else
            {
                Console.WriteLine("DLL does not exists");
                return;
            }
            Console.WriteLine();
        }

        public void reverseTraverseDLL()
        {
            if (head != null)
            {
                DoublyNode tempNode = tail;
                for (int i=0; i<size; i++)
                {
                    Console.Write(tempNode.value);
                    tempNode = tempNode.prev;
                    if (i <size-1)
                    {
                        Console.Write(" <- ");
                    }
                }
            }
            else
            {
                Console.WriteLine("DLL does not exists");
                return;
            }
            Console.WriteLine();
        }

        public Boolean searchInDLL(int nodeValue)
        {
            if (head != null)
            {
                DoublyNode currentNode = head;
                for (int i=0; i<size; i++)
                {
                    if (currentNode.value == nodeValue)
                    {
                        Console.WriteLine("Node found in DLL at location: " + i);
                        return true;
                    }
                    currentNode = currentNode.next;
                }
                Console.WriteLine("Node not found in DLL");
                return false;
            }
            else
            {
                Console.WriteLine("DLL does not exists");
                return false;
            }
        }
    }
}