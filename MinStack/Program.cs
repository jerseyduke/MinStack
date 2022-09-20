using System;
using System.Collections.Generic;
using System.Linq;

namespace MinStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Console.WriteLine(minStack.GetMin());
            minStack.Pop();
            Console.WriteLine(minStack.Top());
            Console.WriteLine(minStack.GetMin());
        }
    }

    public class MinStack
    {
        private Stack<int> Stack;

        public MinStack()
        {
            Stack = new Stack<int>();
        }

        public void Pop()
        {
            Stack.Pop();
        }

        public void Push(int value)
        {
            Stack.Push(value);
        }

        public int Top()
        {
            //not necessary per constraints
            if (!Stack.Any())
            {
                throw new Exception("Stack underflow");
            }
            return Stack.FirstOrDefault();
        }

        public int GetMin()
        {
            return Stack.Min();
        }
    }
}
