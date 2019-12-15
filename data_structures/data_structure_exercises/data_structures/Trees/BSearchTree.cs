using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures.Trees
{
    // C# program to demonstrate delete  
    // operation in binary search tree 

    public class BSearchTree
    {

        // _root of BST  
        private BinaryTreeNode _root;

        // Constructor  
        public BSearchTree()
        {
            _root = null;
        }

        // This method mainly calls deleteRec()  
        public void deleteKey(int key)
        {
            _root = deleteRec(_root, key);
        }

        public void removeNonRec(int key)
        {
            _root = RemoveNonRec(key);
        }

        public void insertNonRec(int key)
        {
            _root = InsertNonRec(key);
        }

        /* A recursive function to insert a new key in BST */
        BinaryTreeNode deleteRec(BinaryTreeNode _root, int key)
        {
            /* Base Case: If the tree is empty */
            if (_root == null) return _root;

            /* Otherwise, recur down the tree */
            if (key < _root.Value)
                _root.LeftNode = deleteRec(_root.LeftNode, key);
            else if (key > _root.Value)
                _root.RightNode = deleteRec(_root.RightNode, key);

            // if key is same as _root's key, then This is the node  
            // to be deleted  
            else
            {
                // node with only one child or no child  
                if (_root.LeftNode == null)
                    return _root.RightNode;
                else if (_root.RightNode == null)
                    return _root.LeftNode;

                // node with two children: Get the 
                // inorder successor (smallest  
                // in the RightNode subtree)  
                _root.Value = minValue(_root.RightNode);

                // Delete the inorder successor  
                _root.RightNode = deleteRec(_root.RightNode, _root.Value);
            }
            return _root;
        }

        int minValue(BinaryTreeNode _root)
        {
            int minv = _root.Value;
            while (_root.LeftNode != null)
            {
                minv = _root.LeftNode.Value;
                _root = _root.LeftNode;
            }
            return minv;
        }

        public BinaryTreeNode RemoveNonRec(int value)
        {
            BinaryTreeNode node = _root;
            while (node != null)
            {
                if (value < node.Value)
                {
                    if (node.LeftNode != null && node.LeftNode.Value == value)
                    {
                        return Remove(value, node.LeftNode);
                        //break;
                    }
                    node = node.LeftNode;
                }
                else if (value > node.Value)
                {
                    if (node.RightNode != null && node.RightNode.Value == value)
                    {
                        return Remove(value, node.RightNode);
                        //break;
                    }
                    node = node.RightNode;
                }
                else
                {
                    return Remove(value, _root);
                    //break;
                }
            }
            return node;
        }

        private BinaryTreeNode Remove(int value, BinaryTreeNode node)
        {
            if (node != null)
            {
                if (node.Counter > 1)
                {
                    --node.Counter;
                    Console.WriteLine("Deleted element: {0}, elements in the node: {1}", node.Value, node.Counter);
                }
                else
                {
                    int vMes = node.Value;

                    if (node.LeftNode == null && node.RightNode == null)
                    {
                        node = null;
                    }
                    else if (node.LeftNode != null && node.RightNode == null)
                    {
                        node = node.LeftNode;
                    }
                    else if (node.LeftNode == null && node.RightNode != null)
                    {
                        node = node.RightNode;
                    }
                    else
                    {
                        if (node.RightNode.LeftNode == null)
                        {
                            node.RightNode.LeftNode = node.LeftNode;
                            node = node.RightNode;
                        }
                        else
                        {
                            BinaryTreeNode p = node.RightNode;
                            while (p.LeftNode.LeftNode != null)
                                p = p.LeftNode;
                            BinaryTreeNode q = p.LeftNode;
                            p.LeftNode = q.RightNode;
                            q.LeftNode = node.LeftNode;
                            q.RightNode = node.RightNode;
                            node = q;
                        }
                    }

                    Console.WriteLine("Deleted node: {0}", vMes);  
                }
            }
            return node;
        }


        public BinaryTreeNode InsertNonRec(int value)
        {
            BinaryTreeNode current = _root;
            while (current != null)
            {
                if (current.Value < value)
                    if (current.LeftNode == null)
                    { current.LeftNode = new BinaryTreeNode(value); break; }
                    else current = current.LeftNode;
                else
                    if (current.RightNode == null)
                { current.RightNode = new BinaryTreeNode(value); break; }
                else current = current.RightNode;
            }
            return current;
        }

        // This method mainly calls insertRec()  
        public void insert(int key)
        {
            _root = insertRec(_root, key);
        }

        /* A recursive function to insert a new key in BST */
        BinaryTreeNode insertRec(BinaryTreeNode _root, int key)
        {

            /* If the tree is empty, return a new node */
            if (_root == null)
            {
                _root = new BinaryTreeNode(key);
                return _root;
            }

            /* Otherwise, recur down the tree */
            if (key < _root.Value)
                _root.LeftNode = insertRec(_root.LeftNode, key);
            else if (key > _root.Value)
                _root.RightNode = insertRec(_root.RightNode, key);

            /* return the (unchanged) node pointer */
            return _root;
        }

        // This method mainly calls InorderRec()  
        public void inorder()
        {
            inorderRec(_root);
        }

        // A utility function to do inorder traversal of BST  
        void inorderRec(BinaryTreeNode _root)
        {
            if (_root != null)
            {
                inorderRec(_root.LeftNode);
                Console.Write(_root.Value + " ");
                inorderRec(_root.RightNode);
            }
        }
        public void dispouse()
        {
            _root = null;
        }
    }
}
