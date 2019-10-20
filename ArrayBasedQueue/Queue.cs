using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayBasedQueue
{
    class Queue<T>
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
                Resize(size * 2);
            }
            tail %= capacity;//mod size (tail?) to wrap
            data[tail] = value;
            tail++;
            size++;
        }

        public T Dequeue()
        {
            
            if (size <= capacity/4)
            {
                Resize(size / 2);
            }
            head %= capacity;//mod size (head?) to wrap
            T deq = data[head]; 
            head++;
            size--;                       
            return deq; 
        }

        public T Peek()
        {
            return data[head];
        }

        public void Resize(int Size)// resizing capacity 
        {
            T[] temp = new T[Size];
             //move over, don't move blanks between tail and head
            data = temp;
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

        }
    }
}
