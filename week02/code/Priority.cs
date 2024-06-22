public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Test will add people with associated priority; Bob(1), Greg(2), Tim(2), Hal(3). Then it will get rid of Bob and Greg. After this it will queue up 
        // Gregory(1) and Henry(2).
        // Expected Result: (Bob, Tim, Gregory, Henry)
        Console.WriteLine("Test 1");
        var addPeople = new PriorityQueue();
        addPeople.Enqueue("Bob", 1);
        addPeople.Enqueue("Greg", 2);
        addPeople.Enqueue("Tim", 2);
        addPeople.Enqueue("Hal", 3);
        addPeople.Dequeue();
        addPeople.Dequeue();
        addPeople.Enqueue("Gregory", 1);
        addPeople.Enqueue("Henry", 2);

        Console.WriteLine(addPeople);
        // Defect(s) Found: Changed index to 0 in Dequeue function. Added (_queue.Remove(_queue[highPriorityIndex]);) 
        // to dequeue function. Deleted "- 1" from dequeue function if statement. Added if statement nested in a for statement
        // to find the first instance of a particular priority.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Passing an empty queue to the dequeue function.
        // Expected Result: Error Message
        Console.WriteLine("Test 2");
        addPeople = new PriorityQueue();
        addPeople.Dequeue();
        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}