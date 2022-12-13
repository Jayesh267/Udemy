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
    }
}