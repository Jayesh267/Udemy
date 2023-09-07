using System;

namespace Udemy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Program p1 = new Program();
            // var factorialResult = p1.factorial(0);
            // Console.WriteLine(factorialResult);

            // var fibonacciResult = p1.fibonacci(-3);
            // Console.WriteLine(fibonacciResult);

            // SumOfDigits p2 = new SumOfDigits();
            // var sumDigitsResult = p2.sumOfDigits(427);
            // Console.WriteLine(sumDigitsResult);

            // Power p3 = new Power();
            // var powerResult = p3.npower(2, 4);
            // Console.WriteLine(powerResult);

            // GCD p4 = new GCD();
            // var gcdResult = p4.gcd(8, -12);
            // Console.WriteLine(gcdResult);

            // DecimalBinary p5 = new DecimalBinary();
            // var binaryResult = p5.decimalBinary(134);
            // Console.WriteLine(binaryResult);
            
            // SingleDimensionalArray s1 = new SingleDimensionalArray(10);

            // s1.insert(1, 10);
            // s1.insert(0, 0);
            // s1.insert(3, 20);
            // s1.insert(3, 22);
            // s1.insert(13, 20);

            // //Accessing an array
            // Console.WriteLine(s1.arr[0]);

            // //Array Traversal
            // Console.WriteLine("Array Traversal");
            // s1.traverseArray();
            
            // //Search array
            // Console.WriteLine("Searching Array");
            // s1.searchArray(50);

            // //Delete value
            // Console.WriteLine("Deleting array element");
            // s1.deleteValue(3);
            // Console.WriteLine(s1.arr[3]);

            // DoubleDimensionalArray d1 = new DoubleDimensionalArray(3,3);
            // d1.insertInArray(0, 0, 30);

            // //Let's see if this works again...

            // SinglyLinkedList sll = new SinglyLinkedList();
            // sll.createSinglylinkedList(5);
            // //Console.WriteLine(sll.head.value);
            // sll.insertInLinkedList(6, 1);
            // sll.insertInLinkedList(7,3);
            // sll.insertInLinkedList(8,2);
            // sll.insertInLinkedList(9,0);
            // //Console.WriteLine(sll.head.next.next.value);
            // sll.traverseSingleLinkedList();

            // sll.searchNode(7);

            // sll.deleteNode(2);
            // sll.traverseSingleLinkedList();
            // sll.deleteSLL();
            // sll.traverseSingleLinkedList();

            // CircularSLL csll = new CircularSLL();
            // csll.createCircularSLL(5);
            // csll.insertCircularSLL(0,4);
            // csll.insertCircularSLL(1,6);
            // csll.insertCircularSLL(8,7);
            // csll.insertCircularSLL(9,3);
            // csll.insertCircularSLL(3,10);
            // //Console.WriteLine(csll.head.value);
            // csll.traverseCircularSLL();
            // //csll.searchCircularSLL(100);
            // csll.deleteNodeFromCircularSSL(3);
            // csll.traverseCircularSLL();
            // csll.deleteEntireCircularSLL();
            // csll.traverseCircularSLL();

            // DoublyLinkedList dll = new DoublyLinkedList();
            // dll.createDoublyLinkedList(1);
            // dll.insertNodeInDLL(0,2);
            // dll.insertNodeInDLL(1,3);
            // dll.insertNodeInDLL(7,4);
            // //Console.WriteLine(dll.tail.value);
            // dll.searchInDLL(14);
            // dll.traverseDLL();
            // //dll.reverseTraverseDLL();
            // dll.deleteNodeInDLL(1);
            // dll.traverseDLL();
            // dll.deleteDLL();
            // dll.traverseDLL();

            // CircularDoublyLinkedList cdll = new CircularDoublyLinkedList();
            // cdll.createNodeInCDLL(1);
            // cdll.insertInCDLL(0,2);
            // cdll.insertInCDLL(2,3);
            // cdll.insertInCDLL(5,4);
            // //Console.WriteLine(cdll.head.next.value);
            // cdll.traverseCDLL();
            // //cdll.reverseTraverseCDLL();
            // cdll.searchInCDLL(40);
            // cdll.deleteNodeInDLL(2);
            // cdll.traverseCDLL();
            // cdll.deleteCDLL();
            // cdll.traverseCDLL();

            // Stack newStack = new Stack(4);
            // newStack.push(1);
            // newStack.push(2);
            // newStack.push(3);
            // newStack.push(4);
            // newStack.push(5);
            // newStack.push(6);
            // newStack.pop();
            // newStack.peek();
            // newStack.deleteStack();

            // StackLinkedList newStack = new StackLinkedList();
            // newStack.push(1);
            // newStack.push(2);
            // newStack.push(3);
            // bool result = newStack.isEmpty();
            // Console.WriteLine(result);
            // int result1 = newStack.pop();
            // Console.WriteLine(result1);
            // int result2 = newStack.peek();
            // Console.WriteLine(result2);
            // int result3 = newStack.peek();
            // Console.WriteLine(result3);
            // newStack.deleteStack();

            // QueueArray newQueue = new QueueArray(3);
            // newQueue.enQueue(1);
            // newQueue.enQueue(2);
            // newQueue.enQueue(3);
            // newQueue.enQueue(4);
            // int result = newQueue.deQueue();
            // Console.WriteLine(result);
            // int result2= newQueue.deQueue();
            // Console.WriteLine(result2);
            // int result3= newQueue.peek();
            // Console.WriteLine(result3);
            // int result4= newQueue.peek();
            // Console.WriteLine(result4);
            // newQueue.deleteQueue();

            // CircularQueue newCQ = new CircularQueue(3);
            // bool result = newCQ.isEmpty();
            // Console.WriteLine(result);
            // bool result1 = newCQ.isFull();
            // Console.WriteLine(result1);
            // newCQ.enQueue(1);
            // newCQ.enQueue(2);
            // newCQ.enQueue(3);
            // newCQ.enQueue(4);

            // int result2 = newCQ.deQueue();
            // Console.WriteLine(result2);

            // newCQ.peek();
            // newCQ.peek();

            // newCQ.deleteQueue();

            // QueueLinkedList list1 = new QueueLinkedList();
            // list1.enQueue(10);
            // list1.enQueue(20);
            // list1.enQueue(30);
            // int deQueueValue = list1.deQueue();
            // Console.WriteLine(deQueueValue);
            // int deQueueValue2 = list1.deQueue();
            // Console.WriteLine(deQueueValue2);
            // int peekValue = list1.peek();
            // Console.WriteLine(peekValue);
            // int peekValue2 = list1.peek();
            // Console.WriteLine(peekValue2);
            // bool eresult = list1.isEmpty();
            // Console.WriteLine(eresult);
            // list1.deleteQueue();

            // TreeNode drinks = new TreeNode("Drinks");
            // TreeNode hotdrinks = new TreeNode("Hot Drinks");
            // TreeNode colddrinks = new TreeNode("Cold Drinks");
            // drinks.addChild(hotdrinks);
            // drinks.addChild(colddrinks);
            
            // TreeNode tea = new TreeNode("Tea");
            // TreeNode coffee = new TreeNode("Coffee");
            // TreeNode beer = new TreeNode("Beer");
            // TreeNode wine = new TreeNode("Wine");

            // hotdrinks.addChild(tea);
            // hotdrinks.addChild(coffee);
            // colddrinks.addChild(beer);
            // colddrinks.addChild(wine);

            // Console.WriteLine(drinks.print(1));

            BinaryTreeLinkedList binaryTree = new BinaryTreeLinkedList();
            BinaryNode N1 = new BinaryNode();
            N1.value = "N1";
            BinaryNode N2 = new BinaryNode();
            N2.value = "N2";
            BinaryNode N3 = new BinaryNode();
            N3.value = "N3";
            BinaryNode N4 = new BinaryNode();
            N4.value = "N4";
            BinaryNode N5 = new BinaryNode();
            N5.value = "N5";
            BinaryNode N6 = new BinaryNode();
            N6.value = "N6";
            BinaryNode N7 = new BinaryNode();
            N7.value = "N7";
            BinaryNode N8 = new BinaryNode();
            N8.value = "N8";
            BinaryNode N9 = new BinaryNode();
            N9.value = "N9";
            
            N1.left = N2;
            N1.right = N3;
            N2.left = N4;
            N2.right = N5;
            N3.left = N6;
            N3.right = N7;
            N4.left = N8;
            N4.right = N9;
            binaryTree.root = N1;

            binaryTree.searchBinaryTree("N8");
            binaryTree.insertInBinaryTree("N10");
            //binaryTree.postOrder(N1);
            Console.WriteLine(binaryTree.getDeepestNode().value);
            binaryTree.deleteBinaryTree();
        }

        //Recursive method to find factorial
        public int factorial (int n)
        {
            if (n<0)
            {
                return -1;
            }
            if (n==0 || n==1)
            {
                return 1;
            }
            //Console.WriteLine(n);
            return n * factorial(n-1);
        }
        
        //Recursive method for fibonacci sequence
        public int fibonacci (int n)
        {
            if (n<0)
            {
                return -1;
            }
            if (n==0 || n==1)
            {
                return n;
            }
            return fibonacci(n-1) + fibonacci(n-2);
        }
    }
}