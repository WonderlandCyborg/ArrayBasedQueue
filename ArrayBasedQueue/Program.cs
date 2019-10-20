using System;

namespace ArrayBasedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Console.WriteLine("Hello. Welcome to the Queue. You are in the menu.");
            while (true)
            {
                Console.WriteLine("What would you like to do? Enqueue (e). Dequeue (d). Peek (p). Clear (c). Check if the queue is empty (i).");

                switch (Console.ReadLine())
                {
                    case "e":
                        Console.WriteLine("Great. What Value would you like to enqueue?");
                        queue.Enqueue(int.Parse(Console.ReadLine()));
                        break;
                    case "d":
                        if (queue.IsEmpty())
                        {
                            Console.WriteLine("Great. The Queue is empty. There is nothing left to dequeue.");
                            break;
                        }
                        Console.WriteLine($"Great. {queue.Dequeue()} has beeen dequeued.");
                        break;
                    case "p":
                        if (queue.IsEmpty())
                        {
                            Console.WriteLine("Great. The Queue is empty. There is nothing left to peek at.");
                            break;
                        }
                        Console.WriteLine($"Great. {queue.Peek()} is the top value.");
                        break;
                    case "c":
                        Console.WriteLine("Great. The Queue has been cleared.");
                        queue.Clear();
                        break;
                    case "i":
                        if (queue.IsEmpty())
                        {
                            Console.WriteLine("Great. The Queue is empty.");
                        }
                        else
                        {
                            Console.WriteLine("Great. The Queue is not empty.");
                        }
                        break;
                }
            }
        }
    }
}
