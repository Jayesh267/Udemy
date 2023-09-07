using System;
namespace Udemy
{
    public class BinaryTreeLinkedList
    {
        public BinaryNode root;
        public BinaryTreeLinkedList()
        {
            this.root = null;
        }

        //Pre-order Traversal
        void preOrder(BinaryNode node)
        {
            if (node == null)
                return;
            Console.WriteLine(node.value + " ");
            preOrder(node.left);
            preOrder(node.right);
        }

        //In-Order traversal
        public void inOrder(BinaryNode node)
        {
            if (node == null)
                return;
            inOrder(node.left);
            Console.WriteLine(node.value + " ");
            inOrder(node.right);
        }

        //Post-Order Traversal
        public void postOrder(BinaryNode node)
        {
            if (node ==  null)
                return;
            postOrder(node.left);
            postOrder(node.right);
            Console.WriteLine(node.value + " ");
        }

        //Search Binary tree using level-order traversal
        public void searchBinaryTree (String value)
        {
            Queue<BinaryNode> queue = new Queue<BinaryNode>();
            queue.Enqueue(root);
            Console.WriteLine(queue.Count);

            while (queue.Count > 0)
            {
                BinaryNode presentNode = queue.Dequeue();
                Console.WriteLine(value + ": " + presentNode.value);
                if (presentNode.value == value)
                {
                    Console.WriteLine("The value "+ value + " is found in Tree!!");
                    return;
                }
                else
                {
                    if (presentNode.left != null)
                    {
                        queue.Enqueue(presentNode.left);
                    }
                    if (presentNode.right != null)
                    {
                        queue.Enqueue(presentNode.right);
                    }
                }
            }
            Console.WriteLine("The value "+ value + " is not found in Tree!!");
        }

        //Insert node in Binary tree using level order traversal
        public void insertInBinaryTree (String value)
        {
            BinaryNode newNode = new BinaryNode();
            newNode.value = value;

            if (root == null)
            {
                root = newNode;
                Console.WriteLine("Inserted new node at root");
                return;
            }

            Queue<BinaryNode> queue = new Queue<BinaryNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                BinaryNode presentNode = queue.Dequeue();
                if (presentNode.left == null)
                {
                    presentNode.left = newNode;
                    Console.WriteLine("New node is inserted at " + presentNode.value);
                    return;
                }
                if (presentNode.right == null)
                {
                    presentNode.right = newNode;
                    Console.WriteLine("New node is inserted at " + presentNode.value);
                    return;
                }
                queue.Enqueue(presentNode.left);
                queue.Enqueue(presentNode.right);
            }
        }

        //Get Deepest node in Binary Tree
        public BinaryNode getDeepestNode ()
        {
            Queue<BinaryNode> queue = new Queue<BinaryNode>();
            queue.Enqueue(root);
            BinaryNode presentNode = null;      

            while (queue.Count > 0)
            {
                presentNode = queue.Dequeue();
                if (presentNode.left != null)
                {
                    queue.Enqueue(presentNode.left);
                }
                if (presentNode.right != null)
                {
                    queue.Enqueue(presentNode.right);
                }
            }
            return presentNode;
        }

        //Delete Deepest Node in Binary Tree
        public void deleteDeepestNode (BinaryNode node)
        {
            Queue<BinaryNode> queue = new Queue<BinaryNode>();
            queue.Enqueue(root);
            BinaryNode presentNode, previousNode = null;

            while (queue.Count > 0)
            {

            }

        }

        //Delete Binary Tree
        public void deleteBinaryTree ()
        {
            root = null;
            Console.WriteLine("Binary tree deleted and ready for garbage collection");
        }
    }
}