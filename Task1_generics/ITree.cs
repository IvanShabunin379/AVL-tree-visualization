using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_generics
{
    interface ITree<T> : IEnumerable<T> where T : IComparable<T>
    {
        void Add(T value);
        void Remove(T value);
        void Clear();
        bool Contains(T value);

        int Count { get; }
        bool IsEmpty { get; }
        IEnumerable<T> Nodes { get; }
    }
}
