using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);


            Console.WriteLine("In-order Traversal:");
            tree.InOrderTraversal(tree.Root);
            Console.WriteLine();

            Console.WriteLine("Pre-order Traversal:");
            tree.PreOrderTraversal(tree.Root);
            Console.WriteLine();

            Console.WriteLine("Post-order Traversal:");
            tree.PostOrderTraversal(tree.Root);
            Console.WriteLine();
        }
    }
}
