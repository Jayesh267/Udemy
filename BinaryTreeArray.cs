namespace Udemy;

public class BinaryTreeArray
{
    String[] arr;
    int lastUsedIndex;

    public BinaryTreeArray (int size)
    {
        arr = new string[size + 1];
        this.lastUsedIndex = 0;
        Console.WriteLine("Binary tree of size " + size + " is created!!");
    }

    //Check if tree is full
    public Boolean isFull()
    {
        if (arr.Length - 1 == lastUsedIndex)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //Insert method in Binary tree
    public void insertInBinaryTree(string value)
    {
        if (isFull())
        {
            Console.WriteLine("Value cannot be inserted because the tree is full");
            return;
        }
        else
        {
            arr[lastUsedIndex + 1] = value;
            lastUsedIndex++;
            Console.WriteLine("The value {0} is inserted at index {1}", value, lastUsedIndex-1);
        }
    }

    //Pre-order traversal (root -> left -> right)
    public void preOrder(int index)
    {
        if (index > lastUsedIndex)
        {
            return;
        }
        Console.Write(arr[index] + " ");
        preOrder(index * 2);
        preOrder(index * 2 + 1);
    }

    //In-order traversal (left -> root -> right)
    public void inOrder(int index)
    {
        if (index > lastUsedIndex)
        {
            return;
        }
        inOrder(index * 2);
        Console.Write(arr[index] + " ");
        inOrder(index * 2 + 1);
    }

    //Post-order traversal (left -> right -> root)
    public void postOrder (int index)
    {
        if (index > lastUsedIndex)
        {
            return;
        }
        postOrder(index * 2);
        postOrder(index * 2 + 1);
        Console.Write(arr[index] + " ");
    }

    //Level-order traversal
    public void levelOrder ()
    {
        for (int i=1; i<= lastUsedIndex; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }

    //Search for a value in binary tree
    public int searchTree(string value)
    {
        for (int i=1; i<=lastUsedIndex; i++)
        {
            if (arr[i] == value)
            {
                Console.WriteLine("Value {0} found at position {1}", value, i);
                return i;
            }
        }
        Console.WriteLine("Item does not exist in this binary tree");
        return -1;
    }

    //Delete a value in binary tree
    public void delete(string value)
    {
        int location = searchTree(value);
        if (location == -1)
            return;
        else
        {
            //lastUsedIndex is the deepest node
            arr[location] = arr[lastUsedIndex];
            lastUsedIndex--;
            Console.WriteLine("Value is successfully deleted");
        }
    }

    //Delete entire binary tree
    public void deleteTree ()
    {
        arr = null;
        Console.WriteLine("Binary tree successfully deleted!!");
    }
}