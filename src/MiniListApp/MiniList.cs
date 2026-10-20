using System.Collections;

namespace MiniListApp;

/// <summary>
/// A generic singly linked list. Items are enumerated in insertion order.
/// </summary>
public sealed class MiniList<T> : IEnumerable<T>
{
    private Node? _head;
    private Node? _tail;

    public int Count { get; private set; }

    private sealed class Node(T value)
    {
        public T Value { get; } = value;
        public Node? Next { get; set; }
    }

    /// <summary>Adds an item to the end of the list and returns its zero-based index.</summary>
    public int Append(T item)
    {
        var node = new Node(item);
        int index = Count;

        if (_head is null)
            _head = node;
        else
            _tail!.Next = node;

        _tail = node;
        Count++;
        return index;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node? current = _head;
        while (current is not null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
