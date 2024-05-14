using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_generics
{
    class ArrayTreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public int Height { get; set; }
        public int LeftChildIndex { get; set; }
        public int RightChildIndex { get; set; }

        public ArrayTreeNode(T value)
        {
            Value = value;
            Height = 1;
            LeftChildIndex = -1;
            RightChildIndex = -1;
        }
    }

    class ArrayTree<T> : ITree<T> where T : IComparable<T>
    {
        private ArrayTreeNode<T>[] _nodes;
        private int _rootIndex;
        private int _count;

        public ArrayTree()
        {
            _nodes = new ArrayTreeNode<T>[15];
            _rootIndex = -1;
            _count = 0;
        }

        public ArrayTreeNode<T>[] GetNodesArray()
        {
            return _nodes;
        }

        public int GetRootIndex()
        {
            return _rootIndex;
        }

        public int Count => _count;

        public bool IsEmpty => _count == 0;

        public IEnumerable<T> Nodes => this;

        public IEnumerator<T> GetEnumerator()
        {
            if (_rootIndex != -1)
            {
                foreach (T item in InOrderTraversal(_rootIndex))
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IEnumerable<T> InOrderTraversal(int nodeIndex)
        {
            if (_nodes[nodeIndex].LeftChildIndex != -1)
            {
                foreach (T item in InOrderTraversal(_nodes[nodeIndex].LeftChildIndex))
                    yield return item;
            }

            yield return _nodes[nodeIndex].Value;

            if (_nodes[nodeIndex].RightChildIndex != -1)
            {
                foreach (T item in InOrderTraversal(_nodes[nodeIndex].RightChildIndex))
                    yield return item;
            }
        }

        public void Add(T value)
        {
            _rootIndex = Add(_rootIndex, value);
            ++_count;
        }

        private int Add(int nodeIndex, T value)
        {
            if (nodeIndex == -1)
            {
                int newNodeIndex = Array.IndexOf(_nodes, null);
                if (newNodeIndex == -1)
                {
                    newNodeIndex = _nodes.Length;
                    Array.Resize(ref _nodes, _nodes.Length * 2);
                }
                _nodes[newNodeIndex] = new ArrayTreeNode<T>(value);
                return newNodeIndex;
            }

            ArrayTreeNode<T> currentNode = _nodes[nodeIndex];

            if (currentNode == null)
                _nodes[nodeIndex] = new ArrayTreeNode<T>(value);
            else
            {
                if (value.CompareTo(currentNode.Value) < 0)
                    currentNode.LeftChildIndex = Add(currentNode.LeftChildIndex, value);
                else if (value.CompareTo(currentNode.Value) > 0)
                    currentNode.RightChildIndex = Add(currentNode.RightChildIndex, value);
                else throw new TreeException("The value already exists in the tree.");

                return Balance(nodeIndex);
            }
            //return Balance(nodeIndex);
            return nodeIndex;
        }

        public void Clear()
        {
            Array.Clear(_nodes, 0, _nodes.Length);
            _count = 0;
        }

        public bool Contains(T value)
        {
            return Contains(_rootIndex, value);
        }

        private bool Contains(int nodeIndex, T value)
        {
            if (nodeIndex == -1)
                return false;

            ArrayTreeNode<T> node = _nodes[nodeIndex];

            if (value.CompareTo(node.Value) < 0)
                return Contains(node.LeftChildIndex, value);

            if (value.CompareTo(node.Value) > 0)
                return Contains(node.RightChildIndex, value);

            return true;
        }

        public void Remove(T value)
        {
            _rootIndex = Remove(_rootIndex, value);
            --_count;
        }

        private int Remove(int nodeIndex, T value)
        {
            if (nodeIndex == -1)
                throw new TreeException("The value doesn't exist in the tree.");

            ArrayTreeNode<T> node = _nodes[nodeIndex];

            if (value.CompareTo(node.Value) < 0)
                node.LeftChildIndex = Remove(node.LeftChildIndex, value);
            else if (value.CompareTo(node.Value) > 0)
                node.RightChildIndex = Remove(node.RightChildIndex, value);
            else
            {
                if (node.LeftChildIndex == -1 && node.RightChildIndex == -1)
                {
                    _nodes[nodeIndex] = null;
                    return -1;
                }
                else if (node.LeftChildIndex == -1)
                {
                    int rightChild = node.RightChildIndex;
                    _nodes[nodeIndex] = _nodes[rightChild];
                    _nodes[rightChild] = null;
                    return nodeIndex;
                }
                else if (node.RightChildIndex == -1)
                {
                    int leftChild = node.RightChildIndex;
                    _nodes[nodeIndex] = _nodes[leftChild];
                    _nodes[leftChild] = null;
                    return nodeIndex;
                }
                else
                {
                    int successorIndex = FindMinNode(node.RightChildIndex);
                    ArrayTreeNode<T> successor = _nodes[successorIndex];
                    node.Value = successor.Value;
                    node.RightChildIndex = Remove(node.RightChildIndex, successor.Value);
                }
            }

            return Balance(nodeIndex);
        }

        private int GetHeight(int nodeIndex)
        {
            return (nodeIndex != -1) ? _nodes[nodeIndex].Height : 0;
        }

        private void SetHeight(int nodeIndex)
        {
            ArrayTreeNode<T> node = _nodes[nodeIndex];
            int leftChildHeight = GetHeight(node.LeftChildIndex);
            int rightChildHeight = GetHeight(node.RightChildIndex);
            node.Height = Math.Max(leftChildHeight, rightChildHeight) + 1;
        }

        private int GetBalanceFactor(int nodeIndex)
        {
            if (nodeIndex == -1)
                return 0;

            return GetHeight(_nodes[nodeIndex].LeftChildIndex) - GetHeight(_nodes[nodeIndex].RightChildIndex);
        }

        private int RotateRight(int nodeIndex)
        {
            int newRootIndex = _nodes[nodeIndex].LeftChildIndex;
            int tmpIndex = _nodes[newRootIndex].RightChildIndex;

            _nodes[newRootIndex].RightChildIndex = nodeIndex;
            _nodes[nodeIndex].LeftChildIndex = tmpIndex;

            SetHeight(nodeIndex);
            SetHeight(newRootIndex);

            return newRootIndex;
        }

        private int RotateLeft(int nodeIndex)
        {
            int newRootIndex = _nodes[nodeIndex].RightChildIndex;
            int tmpIndex = _nodes[newRootIndex].LeftChildIndex;

            _nodes[newRootIndex].LeftChildIndex = nodeIndex;
            _nodes[nodeIndex].RightChildIndex = tmpIndex;

            SetHeight(nodeIndex);
            SetHeight(newRootIndex);

            return newRootIndex;
        }

        private int Balance(int nodeIndex)
        {
            SetHeight(nodeIndex);

            ArrayTreeNode<T> node = _nodes[nodeIndex];

            if (GetBalanceFactor(nodeIndex) > 1)
            {
                if (GetBalanceFactor(node.LeftChildIndex) < 0)
                {
                    node.LeftChildIndex = RotateLeft(node.LeftChildIndex);
                    //SetHeight(node.LeftChildIndex);
                }
                return RotateRight(nodeIndex);
            }

            if (GetBalanceFactor(nodeIndex) < -1)
            {
                if (GetBalanceFactor(node.RightChildIndex) > 0)
                {
                    node.RightChildIndex = RotateRight(node.RightChildIndex);
                    //SetHeight(node.RightChildIndex);
                }
                return RotateLeft(nodeIndex);
            }

            return nodeIndex;
        }

        private int FindMinNode(int nodeIndex)
        {
            return (_nodes[nodeIndex].LeftChildIndex != -1) ? FindMinNode(_nodes[nodeIndex].LeftChildIndex) : nodeIndex;
        }
    }
}
