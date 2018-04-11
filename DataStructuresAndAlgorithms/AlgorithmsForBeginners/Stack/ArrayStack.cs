using System;

namespace AlgorithmsForBeginners.Stack
{
    internal class ArrayStack<T> : IStack<T>
    {
        private static readonly int DEFAULT_SIZE = 4;
        private static readonly float DEFAULT_TRIM_THRESHOLD = 0.90f;

        private T[] _values;
        private int _count;

        public ArrayStack() : this(DEFAULT_SIZE)
        {
        }

        public ArrayStack(int capacity)
        {
            _values = new T[capacity];
            _count = 0;
        }


        public void Push(T value)
        {
            if (_count == _values.Length)
            {
                Array.Resize(ref _values, _values.Length << 1);
            }

            _values[_count++] = value;
        }

        public T Pop()
        {
            T result = _values[--_count];
            _values[_count] = default(T);
            return result;
        }

        public T Peek()
        {
            return _values[_count - 1];
        }

        public void Clear()
        {
            for (int i = 0; i < _count; i++)
            {
                _values[i] = default(T);
            }

            _count = 0;
        }

        public bool IsEmpty()
        {
            return 0 == _count;
        }

        public int Length()
        {
            return _values.Length;
        }

        public int Count()
        {
            return _count;
        }

        public void Trim()
        {
            if (_count / (float)_values.Length < DEFAULT_TRIM_THRESHOLD)
            {
                Array.Resize(ref _values, Math.Max(_count, DEFAULT_SIZE));
            }
        }
    }
}
