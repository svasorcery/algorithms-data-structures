namespace AlgorithmsForBeginners.Stack
{
    public interface IStack<T>
    {
        void Push(T value);
        T Pop();
        T Peek();
        void Clear();
        bool IsEmpty();
        int Length();
        int Count();
        void Trim();
    }
}
