public static class Priority
{
    public static void Test()
    {
        
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue); // Output: []

        // Test Cases

        // Test 1: Enqueue with different priorities, dequeue in priority order
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Item C", 1);
        priorityQueue.Enqueue("Item B", 3);
        priorityQueue.Enqueue("Item A", 5);
        Console.WriteLine(priorityQueue); // Output: [(Pri:5), (Pri:3), (Pri:1)]

        Console.WriteLine(priorityQueue.Dequeue()); // Output: Item A
        Console.WriteLine(priorityQueue.Dequeue()); // Output: Item B
        Console.WriteLine(priorityQueue.Dequeue()); // Output: Item C

        // Test 2: Enqueue with the same priority, dequeue in FIFO order
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("Item X", 2);
        priorityQueue.Enqueue("Item Y", 2);
        priorityQueue.Enqueue("Item Z", 2);
        Console.WriteLine(priorityQueue); // Output: [(Pri:2), (Pri:2), (Pri:2)]

        Console.WriteLine(priorityQueue.Dequeue()); // Output: Item X
        Console.WriteLine(priorityQueue.Dequeue()); // Output: Item Y
        Console.WriteLine(priorityQueue.Dequeue()); // Output: Item Z

        // Test 3: Dequeue from an empty queue
        Console.WriteLine("Test 3");
        Console.WriteLine(priorityQueue.Dequeue()); // Output: The queue is empty.
    }
}