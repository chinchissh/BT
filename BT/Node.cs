using System;
using System.Collections.Generic;
using System.Text;

namespace BT
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        public Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void Insert(int key)
        {
            root = Insert(root, key);
        }

        Node Insert(Node root, int key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            if (key < root.data)
            {
                root.left = Insert(root.left, key);
            }
            else if (key > root.data)
            {
                root.right = Insert(root.right, key);
            }

            return root;
        }

        public void InOrder()
        {
            InOrder(root);
        }

        void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.left);
                Console.Write(root.data + " ");
                InOrder(root.right);
            }
        }
    }
}
