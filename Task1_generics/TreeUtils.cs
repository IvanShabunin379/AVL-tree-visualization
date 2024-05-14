using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_generics
{
    public delegate bool CheckDelegate<T>(T value) where T : IComparable<T>;

    static class TreeUtils<T> where T : IComparable<T>
    {
        public delegate ITree<T> TreeConstructorDelegate();
        public static readonly TreeConstructorDelegate ArrayTreeConstructor = () => new ArrayTree<T>();
        public static readonly TreeConstructorDelegate LinkedTreeConstructor = () => new LinkedTree<T>();

        public static bool Exists(ITree<T> tree, CheckDelegate<T> check)
        {
            foreach (T node in tree)
            {
                if (check(node))
                    return true;
            }

            return false;
        }

        public static ITree<T> FindAll(ITree<T> tree, CheckDelegate<T> check, TreeConstructorDelegate constructor)
        {
            ITree<T> result = constructor();

            foreach (T node in tree)
            {
                if (check(node))
                    result.Add(node);
            }

            return result;
        }

        public static void ForEach(ITree<T> tree, Action<T> action)
        {
            foreach (T node in tree)
            {
                action(node);
            }
        }

        public static bool CheckForAll(ITree<T> tree, CheckDelegate<T> check)
        {
            foreach (T node in tree)
            {
                if (!check(node))
                    return false;
            }

            return true;
        }
    }
}
