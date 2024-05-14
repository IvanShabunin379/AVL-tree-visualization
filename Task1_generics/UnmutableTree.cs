using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_generics
{
    class UnmutableTree<T> : ITree<T> where T : IComparable<T>
    {
        private readonly ITree<T> _tree;

        public UnmutableTree(ITree<T> tree) => _tree = tree;

        public int Count => _tree.Count;

        public bool IsEmpty => _tree.IsEmpty;

        public IEnumerable<T> Nodes => _tree.Nodes;

        public void Add(T value) => throw new TreeException("Cannot modify an unmutable tree.");

        public void Clear() => throw new TreeException("Cannot modify an unmutable tree.");

        public bool Contains(T value) => _tree.Contains(value);

        public void Remove(T value) => throw new TreeException("Cannot modify an unmutable tree.");

        public IEnumerator<T> GetEnumerator() => _tree.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
