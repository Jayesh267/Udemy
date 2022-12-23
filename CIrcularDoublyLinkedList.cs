using System;

namespace Udemy
{
    public class CircularDoublyLinkedList
    {
        public DoublyNode head;
        public DoublyNode tail;
        public int size;
        public DoublyNode createNodeInCDLL(int nodeValue)
        {
            DoublyNode newNode = new DoublyNode();
            newNode.value = nodeValue;
            head = newNode;
            tail = newNode;
            size = 1;
            newNode.next = newNode;
            newNode.prev = newNode;
            return head;
        }

        public void insertInCDLL(int location, int nodeValue)
        {
            if (head != null)
            {
                DoublyNode newNode = new DoublyNode();
                newNode.value = nodeValue;
                if(location == 0)
                {
                    newNode.next = head;
                    newNode.prev = head.prev;
                    head.prev = newNode;
                    tail.next = newNode;
                    head = newNode;
                }
                else if (location >= size)
                {
                    newNode.prev = tail;
                    newNode.next = head;
                    tail.next.prev = newNode;
                    tail.next = newNode;
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
                    newNode.prev = tempNode;
                    tempNode.next.prev = newNode;
                    tempNode.next = newNode;
                }
                size++;

            }
            else
            {
                createNodeInCDLL(nodeValue);
                return;
            }
        }

        public void traverseCDLL()
        {
            if (head != null)
            {
                DoublyNode currentNode = head;
                for (int i=0; i<size; i++)
                {
                    Console.Write(currentNode.value);
                    currentNode = currentNode.next;
                    if (i != size-1)
                    {
                        Console.Write(" -> ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Circular DLL does not exist...");
                return;
            }
        }

        public void reverseTraverseCDLL()
        {
            if (head != null)
            {
                DoublyNode currentNode = tail;
                for (int i=0; i<size; i++)
                {
                    Console.Write(currentNode.value);
                    if (i < size-1)
                    {
                        Console.Write(" <- ");
                    }
                    currentNode = currentNode.prev;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Circular DLL does not exist...");
                return;   
            }
        }

        public Boolean searchInCDLL(int nodeValue)
        {
            if (head != null)
            {
                DoublyNode currentNode = head;
                for (int i=0; i<size; i++)
                {
                    if (currentNode.value == nodeValue)
                    {
                        Console.WriteLine("Node found in CDLL at location: " + i);
                        return true;
                    }
                    currentNode = currentNode.next;
                }
            }
            else
            {
                Console.WriteLine("Circular DLL does not exist...");
                return false; 
            }
            Console.WriteLine("Node not found in CDLL");
            return false;
        }

        public void deleteNodeInDLL(int location)
        {
            if (head != null)
            {
                if (location == 0)
                {
                    if (size == 1)
                    {
                        head.next = null;
                        head.prev = null;
                        head = null;
                        tail = null;
                    }
                    else
                    {
                        head.next.prev = tail;
                        tail.next = tail.next.next;
                        head = head.next;
                    }
                }
                else if (location > size)
                {
                    if (size == 1)
                    {
                        head.next = null;
                        head.prev = null;
                        head = null;
                        tail = null;
                    }
                    else
                    {
                        tail.prev.next = head;
                        head.prev = tail.prev;
                        tail = tail.prev;
                    }
                }
                else
                {
                    DoublyNode currentNode = head;
                    for (int i=0; i<location-1; i++)
                    {
                        currentNode = currentNode.next;
                    }
                    currentNode.next = currentNode.next.next;
                    currentNode.next.prev = currentNode;
                }
                size--;
            }
            else
            {
                Console.WriteLine("Circular DLL does not exist...");
                return; 
            }
        }

        public void deleteCDLL()
        {
            if (head != null)
            {
                DoublyNode currentNode = head;
                tail.next = null;
                head = null;
                tail = null;
                for(int i=0; i<size; i++)
                {
                    currentNode.prev = null;
                    currentNode = currentNode.next;
                }
                Console.WriteLine("Circular DLL successfully deleted");
            }
            else
            {
                Console.WriteLine("Circular DLL does not exist...");
                return; 
            }
        }
    }
}