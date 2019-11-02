using System;
using Xunit;
using ArrayBasedQueue;

namespace TestingQueue
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyQueueCountIsZeroPasses()
        {
            Queue<int> queue = new Queue<int>();

            Assert.Equal(0, queue.Count);
        }

        [Fact]
        public void EmptyQueueCountIsZeroFails()
        {
            Queue<int> queue = new Queue<int>();

            Assert.NotEqual(0, queue.Count);
        }


        [Fact]
        public void QueuePeekPasses()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(5);

            Assert.Equal(5, queue.Peek());
        }
    }
}
