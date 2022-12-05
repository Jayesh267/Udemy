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
    }
}