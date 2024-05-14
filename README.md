# AVL-tree-visualization

Лабораторная работа по C#: реализация АВЛ-дерева и его визуализация через WindowsForms.

## Классы для АВЛ-дерева:

1. **ITree<T> : IEnumerable<T>** – базовый интерфейс для всех сбалансированных деревьев:
    - Методы:
        - `void Add(T data);`
        - `void Clear();`
        - `void Contains(T data);`
        - `void Remove(T data);`
    - Свойства:
        - `int Count;`
        - `bool IsEmpty;`
        - `IEnumerable<T> nodes;`

2. **TreeException** – класс, описывающий исключения, которые могут происходить в ходе работы со сбалансированным деревом (также можно написать ряд наследников от TreeException);

3. **ArrayTree<T> : ITree<T>** – класс сбалансированного дерева на основе массива;

4. **LinkedTree<T> : ITree<T>** – класс сбалансированного дерева на основе связного списка;

5. **UnmutableTree<T> : ITree<T>** – класс неизменяющегося сбалансированного дерева, является оберткой над любым существующим деревом (должен кидаться исключениями на вызов любого метода, изменяющего дерево);

6. **TreeUtils** – класс различных операций над сбалансированным деревом.
    - Методы:
        - `static bool Exists<T>(ITree<T>, CheckDelegate<T>);`
        - `static ITree<T> FindAll<T>(ITree<T>, CheckDelegate<T>, TreeConstructorDelegate<T>);`
        - `static void ForEach(ITree<T>, ActionDelegate<T>);`
        - `static bool CheckForAll<T>(ITree<T>, CheckDelegate<>);`
    - Свойства:
        - `static readonly TreeConstructorDelegate<T> ArrayTreeConstructor;`
        - `static readonly TreeConstructorDelegate<T> LinkedTreeConstructor;`
