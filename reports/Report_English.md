# Laboratory Report No. 3 — MiniList<T>

## Objective
Implement a generic singly linked list in C# and support enumeration through `IEnumerable<T>` and `IEnumerator<T>`.

## Background
A singly linked list consists of nodes. Each node stores a value and a reference to the next node. `MiniList<T>` stores references to the first and last nodes and tracks the item count.

## Implementation
- `Append(T item)` appends an item and returns its zero-based index.
- `Count` exposes the number of stored items.
- `MiniList<T>` implements both generic and non-generic enumeration entry points through `IEnumerable<T>` and `IEnumerable`.
- Its private enumerator explicitly implements `IEnumerator<T>`: `Current`, `MoveNext()`, `Reset()`, and `Dispose()`.
- Once the enumerator reaches the end, subsequent `MoveNext()` calls continue returning `false` until `Reset()` is called.
- The Windows Forms interface creates the list, adds `CheckBox` controls, and compares visual-control traversal with collection traversal.

## Manual test plan
1. Start the app and select **Создать список**.
2. Add several elements and verify the count increases.
3. Select **Перебор кнопок** and verify the count matches the controls.
4. Select **Перебор объектов** and verify the count matches the collection.
5. Create a new list and verify it is empty.
6. Try adding an item before creating the list and verify that an informative message is shown.
7. Test enumeration of empty, single-item, and multi-item lists. After `MoveNext()` first returns `false`, later calls should remain `false` until `Reset()`.

## Conclusion
The implementation demonstrates a generic linked list and an explicit enumerator that follows the .NET enumeration contract. The interface makes the relationship between UI controls and stored objects observable.

## Verification status
The code has been reviewed statically, but compilation and execution must be confirmed by the Windows/.NET 8 GitHub Actions workflow. Do not treat the lab as fully verified until the workflow succeeds and the implementation has been checked against the official assignment.
