using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayBasedQueue
{
    public class Queue<T>
    {
        public int Count { get; private set; }
        private T[] data = new T[10];
        private int head = 0;
        private int tail = 0;
        int capacity = 9;
        int size = 0;

        public Queue()
            {}

        public void Enqueue (T value)
        {
            if(size >= capacity)
            {
                Resize(capacity * 2);
            }
            tail %= capacity;
            data[tail] = value;
            tail++;
            size++;
        }

        public T Dequeue()
        {
            head %= capacity;
            T deq = data[head]; 
            head++;
            size--;                       
            return deq; 
        }

        public T Peek()
        {
            return data[head];
        }

        public void Resize(int Size)
        {
            T[] temp = new T[Size];
            for (int x = 0; x < capacity; x++)
            {
                temp[x] = data[(head + x)%capacity];
            }
            data = temp;
            head = 0;
            tail = size;
            capacity = Size;
        }

        public bool IsEmpty()
        {
            if (size == 0)
            {
                return true;
            }
            return false;
        }

        public void Clear()
        {
            head = 0;
            tail = 0;
            size = 0;
            Resize(10);
        }
    }
}
