using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_generics
{
    class LinkedTreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public int Height { get; set; }
        public LinkedTreeNode<T> Left { get; set; }
        public LinkedTreeNode<T> Right { get; set; }

        public LinkedTreeNode(T value)
        {
            Value = value;
            Height = 1;
            Left = null;
            Right = null;
        }
    }

    class LinkedTree<T> : ITree<T> where T : IComparable<T>
    {
        private LinkedTreeNode<T> _root;
        private int _count;

        public LinkedTree()
        {
            _root = null;
            _count = 0;
        }

        public LinkedTreeNode<T> GetRoot()
        {
            return _root;
        }

        public int Count => _count;

        public bool IsEmpty => _root == null;

        public IEnumerable<T> Nodes => this;

        public IEnumerator<T> GetEnumerator()
        {
            if (_root != null)
            {
                foreach (T item in TraverseInOrder(_root))
                    yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IEnumerable<T> TraverseInOrder(LinkedTreeNode<T> node)
        {
            if (node.Left != null)
            {
                foreach (T item in TraverseInOrder(node.Left))
                    yield return item;
            }

            yield return node.Value;

            if (node.Right != null)
            {
                foreach (T item in TraverseInOrder(node.Right))
                    yield return item;
            }
        }

        public void Add(T value)
        {
            _root = Add(_root, value);
            ++_count;
        }

        private LinkedTreeNode<T> Add(LinkedTreeNode<T> node, T value)
        {
            if (node == null)
                return new LinkedTreeNode<T>(value);

            if (value.CompareTo(node.Value) < 0)
                node.Left = Add(node.Left, value);
            else if (value.CompareTo(node.Value) > 0)
                node.Right = Add(node.Right, value);
            else throw new TreeException("The value already exists in the tree.");

            return Balance(node);
        }

        public void Clear()
        {
            _root = null;
            _count = 0;
        }

        public bool Contains(T value)
        {
            return Contains(_root, value);
        }

        private bool Contains(LinkedTreeNode<T> node, T value)
        {
            if (node == null)
                return false;

            if (value.CompareTo(node.Value) < 0)
                return Contains(node.Left, value);

            if (value.CompareTo(node.Value) > 0)
                return Contains(node.Right, value);

            return true;
        }

        public void Remove(T value)
        {
            _root = Remove(_root, value);
            --_count;
        }

        private LinkedTreeNode<T> Remove(LinkedTreeNode<T> node, T value)
        {
            if (node == null)
                throw new TreeException("The value doesn't exist in the tree.");

            if (value.CompareTo(node.Value) < 0)
            {
                node.Left = Remove(node.Left, value);
            }
            else if (value.CompareTo(node.Value) > 0)
            {
                node.Right = Remove(node.Right, value);
            }
            else // (value.CompareTo(node.Value) == 0), т.е. значение найдено
            {
                // У удаляемого узла нет потомков или есть только один
                if (node.Left == null || node.Right == null)
                {
                    node = node.Left ?? node.Right;
                }
                else // У удаляемого узла есть оба потомка
                {
                    LinkedTreeNode<T> tmp = FindMinNode(node.Right);
                    node.Value = tmp.Value;
                    node.Right = Remove(node.Right, tmp.Value);
                }
            }

            if (node == null)
                return null;

            return Balance(node);
        }

        private int GetHeight(LinkedTreeNode<T> node)
        {
            return (node != null) ? node.Height : 0;
        }

        private void SetHeight(LinkedTreeNode<T> node)
        {
            node.Height = Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;
        }

        private int GetBalanceFactor(LinkedTreeNode<T> node)
        {
            if (node == null)
                return 0;

            return GetHeight(node.Left) - GetHeight(node.Right);
        }

        private LinkedTreeNode<T> RotateRight(LinkedTreeNode<T> y)
        {
            LinkedTreeNode<T> x = y.Left;
            LinkedTreeNode<T> z = x.Right;

            x.Right = y;
            y.Left = z;

            SetHeight(y);
            SetHeight(x);

            return x;
        }

        private LinkedTreeNode<T> RotateLeft(LinkedTreeNode<T> x)
        {
            LinkedTreeNode<T> y = x.Right;
            LinkedTreeNode<T> z = y.Left;

            y.Left = x;
            x.Right = z;

            SetHeight(x);
            SetHeight(y);

            return y;
        }

        private LinkedTreeNode<T> Balance(LinkedTreeNode<T> node)
        {
            SetHeight(node);

            if (GetBalanceFactor(node) > 1)
            {
                if (GetBalanceFactor(node.Left) < 0)
                    node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            if (GetBalanceFactor(node) < -1)
            {
                if (GetBalanceFactor(node.Right) > 0)
                    node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        private LinkedTreeNode<T> FindMinNode(LinkedTreeNode<T> node)
        {
            return (node.Left != null) ? FindMinNode(node.Left) : node;
        }
    }
}
