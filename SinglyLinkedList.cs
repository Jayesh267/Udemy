using System;
namespace Udemy
{
    public class SinglyLinkedList
    {
        public Node head;
        Node tail;
        int size;
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
    }
}