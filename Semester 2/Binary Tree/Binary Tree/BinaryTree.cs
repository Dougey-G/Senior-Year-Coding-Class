using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class BinaryTree
    {
        public char Value { get; set; }
        private Node Root { get; set; }
        public int Height { get { return Root != null ? Root.Height : 0; } }
        public int Count { get { return Root != null ? CountRecursive(Root) : 0; } }

        public void Print()
        {
            BinaryTreePrinter.PrintNode(Root);
        }

        private int CountRecursive(Node Value)
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

        public void Remove(char Value)
        {
            Root = Remove(Root, Value);
        }

        private Node Remove(Node R, char Val)
        {
            if (Root == null)
                return R;

            if (Val < R.Value)
                R.LeftChild = Remove(R.LeftChild, Val);
            else if (Val > R.Value)
                R.RightChild = Remove(R.RightChild, Val);

            else
            {
                if (R.LeftChild == null)
                    return R.RightChild;
                else if (R.RightChild == null)
                    return R.LeftChild;

                R.Value = MinV(R.RightChild);
                R.RightChild = Remove(R.RightChild, R.Value);                
            }
            return R;
        }
        
        public char MinV(Node Root)
        {
            char MinV = Root.Value;
            while (Root.LeftChild != null)
            {
                MinV = Root.LeftChild.Value;
                Root = Root.LeftChild;
            }
            return MinV;
        }        

        public bool Search(char s)
        {
            if (Root == null)
            {
                return false;
            }

            else
            {
                return Search(Root, s);
            }
        }

        private bool Search(Node S, char s)
        {
            if (s > S.Value && S.RightChild != null)
            {
                return Search(S.RightChild, s);
            }
            else if (s < S.Value && S.LeftChild != null)
            {
                return Search(S.LeftChild, s);
            }

            if(s == S.Value)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void PreOrderPrint()
        {
            PreOrderPrint(Root);
        }

        private void PreOrderPrint(Node P)
        {
            if (P != null)
            {
                Console.Write(P.Value + " ");
                PreOrderPrint(P.LeftChild);
                PreOrderPrint(P.RightChild);
            }
        }

        public void InOrderPrint()
        {
            InOrderPrint(Root);
        }

        private void InOrderPrint(Node I)
        {
            if (I != null)
            {
                InOrderPrint(I.LeftChild);
                Console.Write(I.Value + " ");
                InOrderPrint(I.RightChild);
            }
        }

        public void PostOrderPrint()
        {
            PostOrderPrint(Root);
        }

        private void PostOrderPrint(Node Po)
        {
            if (Po != null)
            {
                PostOrderPrint(Po.LeftChild);
                PostOrderPrint(Po.RightChild);
                Console.Write(Po.Value + " ");
            }
        }
    }
}
