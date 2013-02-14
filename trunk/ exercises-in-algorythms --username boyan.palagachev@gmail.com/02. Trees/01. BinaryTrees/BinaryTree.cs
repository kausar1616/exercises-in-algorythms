using System;
using MyStack;


class Program
{
    static void Main()
    {
        MyStack<BinaryNode<int>> parseConstructor = new MyStack<BinaryNode<int>>();
        BinaryTree<int> parseTree = new BinaryTree<int>();

        
        string expression = "123+45**6+*";

        BinaryNode<int> newNode = new BinaryNode<int>();
        for (int i = 0; i < expression.Length; i++)
        {
            newNode = BinaryTree<int>.CreateNewNode(expression[i]);
            if (expression[i] == '+' || expression[i] == '*')
            {
                newNode.Right = parseConstructor.Pop();
                newNode.Left = parseConstructor.Pop();
            }
            parseConstructor.Push(newNode);
        }
        parseTree.Root = newNode;
    

    }
}

class BinaryNode<T>
{
    private BinaryNode<T> left;
    private BinaryNode<T> right;
    private T data;

    public BinaryNode(T value, BinaryNode<T> left, BinaryNode<T> right)
    {
        this.left = left;
        this.right = right;
        this.data = value;
    }
    public BinaryNode(T value)
        : this(value, null, null)
    {
    }
    public BinaryNode(BinaryNode<T> left, BinaryNode<T> right)
    {
        this.left = left;
        this.right = right;
    }
    public BinaryNode()
    {
    }


    public BinaryNode<T> Right
    {
        get
        {
            return this.right;
        }
        set
        {
            this.right = value;
        }
    }
    public BinaryNode<T> Left
    {
        get
        {
            return this.left;
        }
        set
        {
            this.left = value;
        }
    }
    public T Data
    {
        get
        {
            return this.data;
        }
        set
        {
            this.data = value;
        }
    }
}

class BinaryTree<K>
{
    private BinaryNode<K> root;
    static private BinaryNode<K> dummy = new BinaryNode<K>(dummy, dummy);

    public BinaryTree()
    {
        root = new BinaryNode<K>(dummy, dummy);
    }
    public BinaryTree(K value)
    {
        root = BinaryTree<K>.CreateNewNode(value);
    }

    public BinaryNode<K> Root
    {
        get
        {
            return this.root;
        }
        set
        {
            this.root = value;
        }
    }
    public BinaryNode<K> Dummy
    {
        get
        {
            return dummy;
        }
    }

    static public BinaryNode<K> CreateNewNode(K value)
    {
        return new BinaryNode<K>(value, dummy, dummy);
    }
}