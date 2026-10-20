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

    /// <summary>Returns an independent enumerator over this list.</summary>
    public IEnumerator<T> GetEnumerator() => new Enumerator(_head);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private sealed class Enumerator(Node? head) : IEnumerator<T>
    {
        private readonly Node? _first = head;
        private Node? _current;
        private bool _started;
        private bool _ended;

        public T Current => !_started || _ended
            ? throw new InvalidOperationException("The enumerator is not positioned on an element.")
            : _current!.Value;

        object? IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (_ended)
                return false;

            if (!_started)
            {
                _current = _first;
                _started = true;
            }
            else
            {
                _current = _current!.Next;
            }

            if (_current is null)
                _ended = true;

            return !_ended;
        }

        public void Reset()
        {
            _current = null;
            _started = false;
            _ended = false;
        }

        public void Dispose()
        {
            // No unmanaged resources are held by this enumerator.
        }
    }
}
