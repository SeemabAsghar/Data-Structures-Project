﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarkett
{
    public class redBlack<T> where T : IComparable
    {

        public Node<T> root;
        public int numberElements;
        public Node<T> insertedNode;
        public Node<T> nodeBeingDeleted;
        public bool siblingToRight;
        public bool parentTORight;
        public bool nodeToDeleteRed;
        public void Add(T item)
        {
            root = InsertNode(root, item, null);
            numberElements++;
            if (numberElements > 2)
            {
                Node<T> parent, grandParent, greatGrandParent;
                GetNodesAbove(insertedNode, out parent, out grandParent, out greatGrandParent);
                FixTreeAfterInsertion(insertedNode, parent, grandParent, greatGrandParent);
            }
        }
        public void Remove(T item)
        {
            if (numberElements > 1)
            {
                root = DeleteNode(root, item, null);
                numberElements--;
                if (numberElements == 0)
                {
                    root = null;
                }
                Node<T> curNode = null;
                if (nodeBeingDeleted.Right != null)
                {
                    curNode = nodeBeingDeleted.Right;
                }
                Node<T> parent, sibling, grandParent;
                if (curNode == null)
                {
                    parent = nodeBeingDeleted.Parent;
                }
                else
                {
                    parent = curNode.Parent;
                }
                GetParentGrandParentSibling(curNode, parent, out sibling, out grandParent);
                if (curNode != null && curNode.Red)
                {
                    curNode.Red = false;
                }
                else if (!nodeToDeleteRed && !nodeBeingDeleted.Red)
                {
                    FixTreeAfterDeletion(curNode, parent, sibling, grandParent);
                }
                root.Red = false;
            }
        }
        public bool Search(T item)
        {
            return Search(root, item) != null;
        }

        private Node<T> InsertNode(Node<T> node, T item, Node<T> parent)
        {
            if (node == null)
            {
                Node<T> newNode = new redBlack<T>.Node<T>(item, parent);
                if (numberElements > 0)
                {
                    newNode.Red = true;
                }
                else
                {
                    newNode.Red = false;
                }
                insertedNode = newNode;
                return newNode;
            }
            else if (item.CompareTo(node.Item) < 0)
            {
                node.Left = InsertNode(node.Left, item, node);
                return node;
            }
            else if (item.CompareTo(node.Item) > 0)
            {
                node.Right = InsertNode(node.Right, item, node);
                return node;
            }
            else
            {
                throw new InvalidOperationException("Cannot add duplicate objects");
            }
        }
        private void GetNodesAbove(Node<T> curnode, out Node<T> parent, out Node<T> grandParent, out Node<T> greatGrandParent)
        {
            parent = null;
            grandParent = null;
            greatGrandParent = null;
            if (curnode != null)
            {
                parent = curnode.Parent;
            }
            if (parent != null)
            {
                grandParent = parent.Parent;
            }
            if (grandParent != null)
            {
                greatGrandParent = grandParent.Parent;
            }
        }

        private void FixTreeAfterInsertion(Node<T> child, Node<T> parent, Node<T> grandParent, Node<T> greatGrandParent)
        {


            if (grandParent != null)
            {
                Node<T> uncle = (grandParent.Right == parent) ? grandParent.Left : grandParent.Right;
                if (uncle != null && parent.Red && child.Red)
                {
                    uncle.Red = false;
                    parent.Red = false;
                    grandParent.Red = true;
                    Node<T> higher = null;
                    Node<T> stillHigher = null;
                    if (greatGrandParent != null)
                    {
                        higher = greatGrandParent.Parent;
                    }
                    if (higher != null)
                    {
                        stillHigher = higher.Parent;
                    }
                    FixTreeAfterInsertion(grandParent, greatGrandParent, higher, stillHigher);
                }
                else if (uncle == null || (parent.Red && !uncle.Red))
                {
                    if (grandParent.Right == parent && parent.Right == child)//right-right
                    {
                        parent.Red = false;
                        grandParent.Red = true;
                        if (greatGrandParent != null)
                        {
                            if (greatGrandParent.Right == grandParent)
                            {
                                LeftRotate(ref grandParent);
                                greatGrandParent.Right = grandParent;
                            }
                            else
                            {
                                LeftRotate(ref grandParent);
                                greatGrandParent.Left = grandParent;
                            }
                        }
                        else
                        {
                            LeftRotate(ref root);
                        }
                    }
                    else if (grandParent.Left == parent && parent.Left == child)//left-left case
                    {
                        parent.Red = false;
                        grandParent.Red = true;
                        if (greatGrandParent != null)
                        {
                            if (greatGrandParent.Right == grandParent)
                            {
                                RightRotate(ref grandParent);
                                greatGrandParent.Right = grandParent;
                            }
                            else
                            {
                                RightRotate(ref grandParent);
                                greatGrandParent.Left = grandParent;
                            }
                        }
                        else { RightRotate(ref root); }
                    }
                    else if (grandParent.Right == parent && parent.Left == child)//right-left case
                    {
                        child.Red = false;
                        grandParent.Red = true;
                        RightRotate(ref parent);
                        grandParent.Right = parent;
                        if (greatGrandParent != null)
                        {
                            if (greatGrandParent.Right == grandParent)
                            {
                                LeftRotate(ref grandParent);
                                greatGrandParent.Right = grandParent;
                            }
                            else
                            {
                                LeftRotate(ref grandParent);
                                greatGrandParent.Left = grandParent;
                            }
                        }
                        else
                        {
                            LeftRotate(ref root);
                        }
                    }
                    else if (grandParent.Left == parent && parent.Right == child)//left-right case
                    {
                        child.Red = false;
                        grandParent.Red = true;
                        LeftRotate(ref parent);
                        grandParent.Left = parent;
                        if (greatGrandParent != null)
                        {
                            if (greatGrandParent.Right == grandParent)
                            {
                                RightRotate(ref grandParent);
                                greatGrandParent.Right = grandParent;
                            }
                            else
                            {
                                RightRotate(ref grandParent);
                                greatGrandParent.Left = grandParent;
                            }
                        }
                        else
                        {
                            RightRotate(ref root);
                        }
                    }
                }
                if (root.Red)
                {
                    root.Red = false;
                }

            }
        }
        private void LeftRotate(ref Node<T> node)
        {
            Node<T> nodeParent = node.Parent;
            Node<T> right = node.Right;
            Node<T> temp = right.Left;
            right.Left = node;
            node.Parent = right;
            node.Right = temp;
            if (temp != null)
            {
                temp.Parent = node;
            }
            if (right != null)
            {
                right.Parent = nodeParent;
            }
            node = right;
        }
        private void RightRotate(ref Node<T> node)
        {
            Node<T> nodeParent = node.Parent;
            Node<T> left = node.Left;
            Node<T> temp = left.Right;
            left.Right = node;
            node.Parent = left;
            node.Left = temp;
            if (temp != null)
            {
                temp.Parent = node;
            }
            if (left != null)
            {
                left.Parent = nodeParent;
            }
            node = left;
        }

        private Node<T> DeleteNode(Node<T> node, T item, Node<T> parent)
        {
            if (node == null)
            {
                throw new InvalidOperationException("Item not found");
            }
            if (item.CompareTo(node.Item) < 0)
            {
                node.Left = DeleteNode(node.Left, item, node);
            }
            else if (item.CompareTo(node.Item) > 0)
            {
                node.Right = DeleteNode(node.Right, item, node);
            }
            else if (item.CompareTo(node.Item) == 0)
            {//item found
                nodeToDeleteRed = node.Red;
                nodeBeingDeleted = node;
                if (node.Left == null)
                {//no children or only a right child
                    node = node.Right;
                    if (node != null)
                    {
                        node.Parent = parent;
                    }
                }
                else if (node.Right == null)
                {//only a left child
                    node = node.Left;
                    node.Parent = parent;
                }
                else
                {//two children
                 //Delete using leftmost node of right subtree
                    T replaceWithValue = LeftMost(node.Right);
                    node.Right = DeleteLeftMost(node.Right, node);
                    node.Item = replaceWithValue;
                }
            }
            return node;
        }

        private Node<T> DeleteLeftMost(Node<T> node, Node<T> parent)
        {
            if (node.Left == null)
            {
                nodeBeingDeleted = node;

                if (node.Right != null)
                {
                    node.Parent = parent;
                }
                return node.Right;

            }
            else
            {
                node.Left = DeleteLeftMost(node.Left, node);
                return node;
            }
        }
        private T LeftMost(Node<T> node)
        {
            if (node.Left == null)
            {
                return node.Item;
            }
            else
            {
                return LeftMost(node.Left);
            }
        }
        private void GetParentGrandParentSibling(Node<T> curNode, Node<T> parent, out Node<T> sibling, out Node<T> grandParent)
        {
            sibling = null;
            grandParent = null;
            if (parent != null)
            {
                if (parent.Right == curNode)
                {
                    siblingToRight = false;
                    sibling = parent.Left;
                }
                else if (parent.Left == curNode)
                {
                    siblingToRight = true;
                    sibling = parent.Right;
                }
            }
            if (parent != null)
            {
                grandParent = parent.Parent;
            }
            if (grandParent != null)
            {
                if (grandParent.Right == parent)
                {
                    parentTORight = true;
                }
                else if (grandParent.Left == parent)
                {
                    parentTORight = false;
                }
            }
        }
        private void FixTreeAfterDeletion(Node<T> curNode, Node<T> parent, Node<T> sibling, Node<T> grandParent)
        {
            Node<T> siblingLeftChild = null;
            Node<T> siblingRightChild = null;
            if (sibling != null && sibling.Left != null)
            {
                siblingLeftChild = sibling.Left;
            }
            if (sibling != null && sibling.Right != null)
            {
                siblingRightChild = sibling.Right;
            }
            bool siblingRed = (sibling != null && sibling.Red);
            bool siblingLeftRed = (siblingLeftChild != null && siblingLeftChild.Red);
            bool siblingRightRed = (siblingRightChild != null && siblingRightChild.Red);
            if (parent != null && !parent.Red && siblingRed && !siblingLeftRed && !siblingRightRed)
            {
                Case1(curNode, parent, sibling, grandParent);
            }
            else if (parent != null && !parent.Red && !siblingRed && !siblingLeftRed && !siblingRightRed)
            {
                Case2A(curNode, parent, sibling, grandParent);
            }
            else if (parent != null && parent.Red && !siblingRed && !siblingLeftRed && !siblingRightRed)
            {
                Case2B(curNode, parent, sibling, grandParent);
            }
            else if (siblingToRight && !siblingRed && siblingLeftRed && !siblingRightRed)
            {
                Case3(curNode, parent, sibling, grandParent);
            }
            else if (!siblingToRight && !siblingRed && !siblingLeftRed && siblingRightRed)
            {
                Case3P(curNode, parent, sibling, grandParent);
            }
            else if (siblingToRight && !siblingRed && siblingRightRed)
            {
                Case4(curNode, parent, sibling, grandParent);
            }
            else if (!siblingToRight && !siblingRed && siblingLeftRed)
            {
                Case4P(curNode, parent, sibling, grandParent);
            }

        }

        private void Case1(Node<T> curNode, Node<T> parent, Node<T> sibling, Node<T> grandParent)
        {
            if (siblingToRight)
            {
                parent.Red = !parent.Red;
                sibling.Red = !sibling.Red;
                if (grandParent != null)
                {
                    if (parentTORight != null)
                    {
                        LeftRotate(ref parent);
                        grandParent.Right = parent;
                    }
                    else if (!parentTORight)
                    {
                        LeftRotate(ref parent);
                        grandParent.Left = parent;
                    }
                    else
                    {
                        LeftRotate(ref parent);
                        root = parent;
                    }
                    grandParent = sibling;
                    parent = parent.Left;
                    parentTORight = false;
                }
                else if (!siblingToRight)
                {
                    parent.Red = !parent.Red;
                    sibling.Red = !sibling.Red;
                    if (grandParent != null)
                    {
                        if (parentTORight)
                        {
                            RightRotate(ref parent);
                            grandParent.Right = parent;
                        }
                        else if (!parentTORight)
                        {
                            RightRotate(ref parent);
                            grandParent.Left = parent;
                        }
                        else
                        {
                            RightRotate(ref parent);
                            root = parent;
                        }
                        grandParent = sibling;
                        parent = parent.Right;
                        parentTORight = true;
                    }
                    if (parent.Right == curNode)
                    {
                        sibling = parent.Left;
                        siblingToRight = false;
                    }
                    else if (parent.Left == curNode)
                    {
                        sibling = parent.Right;
                        siblingToRight = true;
                    }
                    Node<T> siblingLeftChild = null;
                    Node<T> siblingRightChild = null;
                    if (sibling != null && sibling.Left != null)
                    {
                        siblingLeftChild = sibling.Left;
                    }
                    if (sibling != null && sibling.Right != null)
                    {
                        siblingRightChild = sibling.Right;
                    }
                    bool siblingRed = (sibling != null && sibling.Red);
                    bool siblingLeftRed = (siblingLeftChild != null && siblingLeftChild.Red);
                    bool siblingRightRed = (siblingRightChild != null && siblingRightChild.Red);
                    if (parent.Red && !siblingRed && !siblingLeftRed && !siblingRightRed)
                    {
                        Case2B(curNode, parent, sibling, grandParent);
                    }
                    else if (siblingToRight && !siblingRed && siblingLeftRed && !siblingRightRed)
                    {
                        Case3(curNode, parent, sibling, grandParent);
                    }
                    else if (!siblingToRight && !siblingRed && !siblingLeftRed && siblingRightRed)
                    {
                        Case3P(curNode, parent, sibling, grandParent);
                    }
                    else if (siblingToRight && !siblingRed && siblingRightRed)
                    {
                        Case4(curNode, parent, sibling, grandParent);
                    }
                    else if (!siblingToRight && !siblingRed && siblingLeftRed)
                    {
                        Case4P(curNode, parent, sibling, grandParent);
                    }
                }
            }
        }
        private void Case2A(Node<T> curNode, Node<T> parent, Node<T> sibling, Node<T> grandParent)
        {
            if (sibling != null)
            {
                sibling.Red = !sibling.Red;
            }
            curNode = parent;
            if (curNode != root)
            {
                parent = curNode.Parent;
                GetParentGrandParentSibling(curNode, parent, out sibling, out grandParent);
                Node<T> siblingLeftChild = null;
                Node<T> siblingRightChild = null;
                if (sibling != null && sibling.Left != null)
                {
                    siblingLeftChild = sibling.Left;
                }
                if (sibling != null && sibling.Right != null)
                {
                    siblingRightChild = sibling.Right;
                }
                bool siblingRed = (sibling != null && sibling.Red);
                bool siblingLeftRed = (siblingLeftChild != null && siblingLeftChild.Red);
                bool siblingRightRed = (siblingRightChild != null && siblingRightChild.Red);
                if (parent != null && !parent.Red && !siblingRed && !siblingLeftRed && !siblingRightRed)
                {
                    Case2A(curNode, parent, sibling, grandParent);
                }
                else if (parent != null && parent.Red && !siblingRed && !siblingLeftRed && !siblingRightRed)
                {
                    Case2B(curNode, parent, sibling, grandParent);
                }
                else if (siblingToRight && !siblingRed && siblingLeftRed && !siblingRightRed)
                {
                    Case3(curNode, parent, sibling, grandParent);
                }
                else if (!siblingToRight && !siblingRed && !siblingLeftRed && siblingRightRed)
                {
                    Case3P(curNode, parent, sibling, grandParent);
                }
                else if (siblingToRight && !siblingRed && siblingRightRed)
                {
                    Case4(curNode, parent, sibling, grandParent);
                }
                else if (!siblingToRight && !siblingRed && siblingLeftRed)
                {
                    Case4P(curNode, parent, sibling, grandParent);
                }

            }
        }
        private void Case2B(Node<T> curNode, Node<T> parent, Node<T> sibling, Node<T> grandParent)
        {
            if (sibling != null)
            {
                sibling.Red = !sibling.Red;
            }
            curNode = parent;
            curNode.Red = !curNode.Red;
        }
        private void Case3(Node<T> curNode, Node<T> parent, Node<T> sibling, Node<T> grandParent)
        {
            if (parent.Left == curNode)
            {
                sibling.Red = true;
                sibling.Left.Red = false;
                RightRotate(ref sibling);
                parent.Right = sibling;
            }
            Case4(curNode, parent, sibling, grandParent);
        }
        private void Case3P(Node<T> curNode, Node<T> parent, Node<T> sibling, Node<T> grandParent)
        {
            if (parent.Right == curNode)
            {
                sibling.Red = true;
                sibling.Right.Red = false;
                LeftRotate(ref sibling);
                parent.Left = sibling;
            }
            Case4P(curNode, parent, sibling, grandParent);
        }
        private void Case4(Node<T> curNode, Node<T> parent, Node<T> sibling, Node<T> grandParent)
        {
            sibling.Red = parent.Red;
            sibling.Right.Red = false;
            parent.Red = false;
            if (grandParent != null)
            {
                if (parentTORight)
                {
                    LeftRotate(ref parent);
                    grandParent.Right = parent;
                }
                else
                {
                    LeftRotate(ref parent);
                    grandParent.Left = parent;
                }
            }
            else
            {
                LeftRotate(ref parent);
                root = parent;
            }
        }
        private void Case4P(Node<T> curNode, Node<T> parent, Node<T> sibling, Node<T> grandParent)
        {
            sibling.Red = parent.Red;
            sibling.Left.Red = false;
            parent.Red = false;
            if (grandParent != null)
            {
                if (parentTORight)
                {
                    RightRotate(ref parent);
                    grandParent.Right = parent;
                }
                else
                {
                    RightRotate(ref parent);
                    grandParent.Left = parent;
                }
            }
            else
            {
                RightRotate(ref parent);
                root = parent;
            }
        }
        private Node<T> Search(Node<T> node, T item)
        {
            if (node == null || item.CompareTo(node.Item) == 0)
            {
                return node;
            }
            else if (item.CompareTo(node.Item) < 0)
            {
                return Search(node.Left, item);
            }
            else
            {
                return Search(node.Right, item);
            }
        }
        public class Node<T> where T : IComparable
        {
            public T item;
            public Node<T> left, right, parent;
            public bool red = true;


            public Node(T item, Node<T> parent)
            {
                this.item = item;
                this.Parent = parent;
                left = right = null;
            }
            public Node<T> Left
            {
                get { return left; }
                set { left = value; }
            }
            public Node<T> Right
            {
                get { return right; }
                set { right = value; }
            }
            public Node<T> Parent
            {
                get { return parent; }
                set { parent = value; }
            }
            public T Item
            {
                get { return item; }
                set { item = value; }
            }
            public bool Red
            {
                get { return red; }
                set { red = value; }
            }
        }
    }
}