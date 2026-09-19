using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Three items are added to the queue with different priorities. Highest priority valued item gets dequued.
    // Expected Result: The item with the highest priority is dequeued first.
    // Defect(s) Found: 
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
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}