using System;

namespace AlgorithmsForBeginners
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack.ArrayStack<int>();
            Display("Created", stack);

            stack.Push(0);
            stack.Push(3);
            stack.Push(9);
            Display("Pushed 3 numbers", stack);

            stack.Push(1);
            stack.Push(7);
            stack.Push(5);
            Display("Pushed 3 more numbers", stack);

            var element = stack.Pop();
            Display($"Popped: {element}", stack);

            stack.Trim();
            Display("Trimed", stack);

            stack.Clear();
            Display("Cleared", stack);
        }

        private static void Display(string state, Stack.IStack<int> S)
        {
            Console.WriteLine(state);
            Console.WriteLine($"Empty: {S.IsEmpty()}, Length: {S.Length()}, Count: {S.Count()}" + (S.Count() > 0 ? $", Peek: {S.Peek()}" : ""));
            Console.WriteLine();
        }
    }
}
