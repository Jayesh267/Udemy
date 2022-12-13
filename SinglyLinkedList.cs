using System;
namespace Udemy
{
    public class SinglyLinkedList
    {
        public Node head;
        Node tail;
        int size;
        //Create Single node in linked list
        public Node createSinglylinkedList(int nodeValue)
        {
            head = new Node();
            Node node = new Node();
            node.next = null;
            node.value = nodeValue;
            head = node;
            tail = node;
            size = 1;
            return head;
        }

        //Insert method in SinglyLinkedList
        public void insertInLinkedList(int nodeValue, int location)
        {
            Node node = new Node();
            node.value = nodeValue;
            if (head == null)
            {
                createSinglylinkedList(nodeValue);
            }
            else if (location == 0)
            {
                node.next = head;
                head = node;
            }
            else if (location >= size)
            {
                tail.next = node;
                tail = node;
                node.next = null;
            }
            else
            {
                Node tempNode = head;
                int index = 0;
                while (location < index)
                {
                    tempNode = tempNode.next;
                    index++;
                }
                node.next = tempNode.next;
                tempNode.next = node;                
            }
            size++;
        }

        //Traversal of Single Linked List
        public void traverseSingleLinkedList()
        {
            if (head == null)
            {
                Console.WriteLine("Single Linked List does not exist");
            }
            else
            {
                Node tempNode = head;
                for (int i=0; i<size; i++)
                {
                    Console.Write(tempNode.value);
                    if (i!=(size-1))
                    {
                        Console.Write("->");
                    }
                    tempNode = tempNode.next;
                }
                Console.WriteLine("\n");               
            }
        }

        //Search node in Singly Linked List
        public Boolean searchNode (int nodeValue)
        {
            Node tempNode = head;
            for (int i=0; i<size; i++)
            {
                if (head != null)
                {
                    if (tempNode.value == nodeValue)
                    {
                        Console.WriteLine("Found node at location: " + i);
                        return true;
                    }
                    tempNode = tempNode.next;
                }
            }
            Console.WriteLine("Node not found");
            return false;
        }

        //Delete node from Singly Linked List
        public void deleteNode (int location)
        {
            if (head != null)
            {
                Node tempNode = head;
                if (size == 1)
                {
                    head = null;
                    tail = null;
                    size--;
                }
                else if (location == 0)
                {
                    head = tempNode.next;
                    size--;
                }
                else if (location >= size)
                {
                    int index = 0;
                    while (index < (size - 1))
                    {
                        index++;
                        tempNode = tempNode.next;
                    }
                    tempNode.next = null;
                    tail = tempNode;
                    size--;
                }
                else
                {
                    int index = 0;
                    while (index < (location-1))
                    {
                        index++;
                        tempNode = tempNode.next;
                    }
                    tempNode.next = tempNode.next.next;                    
                    size--;
                }
            }
            else
            {
                Console.WriteLine("Node does not exists");
            }
        }

        //Delete entire singly linked list
        public void deleteSLL()
        {
            head = null;
            tail = null;
            Console.WriteLine("Deleted SLL successfully");
        }
    }
}