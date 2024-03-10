﻿﻿public static class TakingTurns {
    public static void Test() {
        // TODO Problem 1 - Run test cases and fix the code to match requirements
        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3) and
        // run until the queue is empty
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 1");
        var players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);    // This can be un-commented out for debug help
        while (players.Length > 0)
            players.GetNextPerson();

        /// Defect(s) Found: 
        /* Sequence of the result is reversed from expected. It returns all the turns of the last person first, being a stack before proceeding to the next. 
       

        Console.WriteLine("---------");

       */

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3)
        // After running 5 times, add George with 3 turns.  Run until the queue is empty.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, George, Sue, Tim, George, Tim, George
        Console.WriteLine("Test 2");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        for (int i = 0; i < 5; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }

        players.AddPerson("George", 3);
        //Console.WriteLine(players); // This can be un-commented out for debug help
        while (players.Length > 0)
            players.GetNextPerson();

        // Defect(s) Found:  getnextperson only ran five times. 
        /*The queue is not processing the turns in the expected order.  It's outputting all of "Sue's" turns,
         then all of "Tim's", then all of "George's", then the remaining turns of "Tim", and finally all of "Bob's".*/ 

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 3");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 4);   // Tim should be processed 4 times but rather had 0 value. Adjusted this
        players.AddPerson("Sue", 3);
        //Console.WriteLine(players);
        for (int i = 0; i < 10; i++) {
            players.GetNextPerson();
             //Console.WriteLine(players);  // This can be un-commented out for debug help
        }
        // Defect(s) Found: 
        //The function keppings printing names on the list forever didn't work.
        Console.WriteLine("---------");

         // Test 4
        // Scenario: Create a queue with the following people and turns: Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Tim, Sue, Tim, Sue, Tim, Sue, Tim, Tim, Tim, Tim
        Console.WriteLine("Test 4");
        players = new TakingTurnsQueue();
        players.AddPerson("Tim", 7);
        players.AddPerson("Sue", 3);
        //Console.WriteLine(players);  
        for (int i = 0; i < 10; i++) {
            players.GetNextPerson();
            //Console.WriteLine(players);  
        }
        // Defect(s) Found: Tims name is only display once

        Console.WriteLine("---------");

        // Test 5
        // Scenario: Try to get the next person from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 5");
        players = new TakingTurnsQueue();
        players.GetNextPerson();

        // Defect(s) Found:
        /* None, Everything worked as expected.*/
    }
}