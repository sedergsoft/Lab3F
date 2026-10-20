# Laboratory Report No. 3 — MiniList<T>

## Objective
Implement a generic collection using a singly linked list in C# and support iteration through the standard .NET enumeration interface.

## Background
A singly linked list consists of nodes. Each node stores a value and a reference to the next node. The elements do not need to occupy contiguous memory locations. The `MiniList<T>` class keeps references to the first and last nodes and tracks the number of elements.

## Implementation
- `Append(T item)` appends an item to the end of the list and returns its zero-based index.
- `Count` exposes the number of items.
- `IEnumerable<T>` enables use of `foreach`.
- The iterator visits nodes sequentially in insertion order.
- The Windows Forms application can create a list, add `CheckBox` controls, and compare iteration over visible controls with iteration over the collection.

## Recommended manual tests
1. Start the application and select **Создать список**.
2. Select **Добавить элемент** several times.
3. Select **Перебор кнопок** and verify that the count matches the controls added.
4. Select **Перебор объектов** and verify that the count matches the collection elements.
5. Create a new list and confirm that it is empty.
6. Try adding an item before creating a list and confirm that the application displays a helpful message instead of failing.

## Conclusion
This lab demonstrates how to build a generic linked data structure and integrate an iterator with common C# language constructs. The graphical interface makes the relationship between visual controls and collection objects observable.

## Verification limitation
This report describes the implementation committed to the repository. Build and runtime behavior must be verified on Windows with .NET 8, and the solution must be checked against the official assignment document before final submission.
