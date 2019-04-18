using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class BinaryTree
    {
        private Node Root { get; set; }
        public int Height { get { return Root != null ? Root.Height : 0; } }
        public int Count { get { return Root != null ? CountRecursive(Root) : 0; } }

        public void Print()
        {
            BinaryTreePrinter.PrintNode(Root);
        }

        private int CountRecursive(Node r)
        {
            throw new NotImplementedException();
        }

        public void Insert(char i)
        {
            if (Root == null)
            {
                Root = new Node(i);
            }
            else
            {
                Insert(Root, i);
            }
        }

        private void Insert(Node n, char i)
        {
            if (i >= n.Value && n.RightChild == null)
            {
                n.RightChild = new Node(i);
                return;
            }

            else if (i < n.Value && n.LeftChild == null)
            {
                n.LeftChild = new Node(i);
                return;
            }

            if (i >= n.Value)
                Insert(n.RightChild, i);

            else if (i < n.Value)
                Insert(n.LeftChild, i);

        }

        public bool Remove(char r)
        {
            throw new NotImplementedException();
        }

        private bool Remove(Node R, char r)
        {
            throw new NotImplementedException();
        }

        public bool Search(char s)
        {
            throw new NotImplementedException();
        }

        private bool Search(Node S, char s)
        {
            throw new NotImplementedException();
        }

        public bool PreOrderPrint()
        {
            throw new NotImplementedException();
        }

        private bool PreOrderPrint(Node P)
        {
            throw new NotImplementedException();
        }

        public void InOrderPrint()
        {

        }

        private void InOrderPrint(Node I)
        {

        }

        public void PostOrderPrint()
        {

        }

        private void PostOrderPrint(Node Po)
        {

        }
    }
}
