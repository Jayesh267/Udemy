using System;

namespace Udemy
{
    public class CircularSLL
    {
        public Node head;
        public Node tail;
        public int size;

        public Node createCircularSLL(int nodeValue)
        {
            Node node = new Node();
            node.value = nodeValue;
            node.next = node;
            head = node;
            tail = node;
            size = 1;
            return head;
        }

        public void insertCircularSLL(int location, int nodeValue)
        {
            //Check if node exists
            if (head == null)
            {
                createCircularSLL(nodeValue);
                return;
            }

            Node newNode = new Node();
            newNode.value = nodeValue;
            //If the node is to be inserted at start
            if (location == 0)
            {
                newNode.next = head;
                head = newNode;
                tail.next = newNode;
            }
            //If the node is to be inserted at end
            else if (location >= size)
            {
                tail.next = newNode;
                newNode.next = head;
                tail = newNode; 
            }
            else
            {
                int index = 0;
                Node currentNode = head;
                while (index < location - 1)
                {
                    index++;
                    currentNode = currentNode.next;
                }
                newNode.next = currentNode.next;
                currentNode.next = newNode;
            }
            size++;
        }

        public void traverseCircularSLL()
        {
            if (head != null)
            {
                Node tempNode = head;
                for (int i=0; i<size; i++)
                {
                    Console.Write(tempNode.value);
                    if (i != size - 1)
                    {
                        Console.Write(" -> ");
                    }
                    tempNode = tempNode.next;
                }
            }
            else
            {
                Console.WriteLine("Circular SLL does not exists");
                return;
            }
        }
    }
}