using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Three items are added to the queue with different priorities. Highest priority valued item gets dequued.
    // Expected Result: The item with the highest priority is dequeued first.
    // Defect(s) Found: None 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 5);
        priorityQueue.Enqueue("Item3", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Item2", result);
    }

    [TestMethod]
    // Scenario: Multiple items with the same priority are added to the queue.
    // Expected Result: The first item added with that priority should be dequeued first.
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Item1", 5);
        priorityQueue.Enqueue("Item2", 3);
        priorityQueue.Enqueue("Item3", 5);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Item1", result);
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Multiple items with different priorities in queue are dequeued in priority order.
    // Expected Result: All items dequeued in order of priority (high to low).
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
    
        priorityQueue.Enqueue("Item1", 3);
        priorityQueue.Enqueue("Item2", 5);
        priorityQueue.Enqueue("Item3", 1);

        Assert.AreEqual("Item2", priorityQueue.Dequeue());
        Assert.AreEqual("Item1", priorityQueue.Dequeue());
        Assert.AreEqual("Item3", priorityQueue.Dequeue());
    }
}