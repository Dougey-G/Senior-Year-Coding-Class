﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Node
    {
        public char Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public int Height
        {
            get
            {
                int leftTreeHeight = 0;
                int rightTreeHeight = 0;

                if (LeftChild != null)
                    leftTreeHeight = LeftChild.Height + 1;
                if (RightChild != null)
                    rightTreeHeight = RightChild.Height + 1;

                if (leftTreeHeight > rightTreeHeight)
                    return leftTreeHeight;
                else
                    return rightTreeHeight;
            }
        }

        public Node(char val)
        {
            Value = val;
        }

        public Node(string a)
        {

        }

        class BinarySearchTree
        {
            public Node root, current;
            public BinarySearchTree()
            {
                this.root = null;
            }

            public void AddNode(string a) // code to insert nodes to the binary search tree
            {
                Node newNode = new Node(a); //create a new node
                if (root == null) // if the tree is empty new node will be the root node
                    root = newNode;
                else
                {
                    Node previous;
                    current = root;
                    while (current != null)
                    {
                        previous = current;

                        if (a.CompareTo(current.Value) < 1) //if the new node is less than the current node
                        {
                            current = current.LeftChild;
                            if (current == null)
                                previous.LeftChild = newNode;
                        }
                        else //if the new node is greater than the current node
                        {
                            current = current.RightChild;
                            if (current == null)
                                previous.RightChild = newNode;
                        }
                    }
                }
            }
        }

        public string FindNode(Node node, string s)
        {
            if (node == null)
                return Output = "not found";
            else if (s.CompareTo(node.Value) < 0)
                return FindNode(node.LeftChild, s);
            else if (s.CompareTo(node.Value) > 0)
                return FindNode(node.RightChild, s);

            return Output = "found";
        }

        string SearchResult = "";
        static string Output = "";
        public string Display(Node rootNode)
        {
            if (rootNode != null)
            {
                Display(rootNode.LeftChild);
                Output += rootNode.Value;
                Display(rootNode.RightChild);
            }
            return Output;
        }


        private void BtnExecute_Click(object sender, EventArgs e)
        {
            BinarySearchTree btree = new BinarySearchTree();
            btree.AddNode("D");
            btree.AddNode("B");
            btree.AddNode("F");
            btree.AddNode("E");
            btree.AddNode("A");
            btree.AddNode("G");
            btree.AddNode("C");
            Console.WriteLine("The sorted values of the Binary Search Tree are: \r\n \r\n");
            //txtOutput.Text += btree.Display(btree.root);
            Display(btree.root);
            //Node(btree.root, "A");
        }
    }
}