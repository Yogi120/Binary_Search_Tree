using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int value)
        {
            Root = InsertNode(Root, value);
        }

        private Node InsertNode(Node node, int value)
        {
            if (node == null)
            {
                node = new Node(value);
            }
            else if (value < node.Value)
            {
                node.Left = InsertNode(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = InsertNode(node.Right, value);
            }

            return node;
        }

        public void InOrderTraversal(Node node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.Write(node.Value + " ");
                InOrderTraversal(node.Right);
            }
        }

        public void PreOrderTraversal(Node node)
        {
            if (node != null)
            {
                Console.Write(node.Value + " ");
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }

        public void PostOrderTraversal(Node node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Console.Write(node.Value + " ");
            }
        }
    }
}
