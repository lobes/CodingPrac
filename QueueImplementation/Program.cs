using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    // Implementation of a FIFO queue
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        /*
        STDIN   Function
        -----   --------
        10      q = 10 (number of queries)
        1 42    1st query, enqueue 42
        2       dequeue front element
        1 14    enqueue 42
        3       print the front element
        1 28    enqueue 28
        3       print the front element
        1 60    enqueue 60
        1 78    enqueue 78
        2       dequeue front element
        2       dequeue front element

        Expected Output:
        14
        14

        */

        // read input from file
        using (var reader = new StreamReader("queueInput.txt"))
        {
            // Redirect standard input from the console to the input file.
            Console.SetIn(reader);
            string line;
            // first line is number of iterations
            int numOperations = Convert.ToInt32(Console.ReadLine().Trim());
            List<string> operation = new List<string>();
            List<string> queue = new List<string>();

            for (int i = 0; i < numOperations; i++)
            {
                line = Console.ReadLine().Trim();
                operation.Clear();
                operation.AddRange(line.Split(" ", StringSplitOptions.RemoveEmptyEntries));
                // if line starts with 1, push number after space to tail of queue
                if (operation[0] == "1")
                {
                    queue.Add(operation[1]);
                }
                // if line starts with 2, pop number from head of queue
                else if (operation[0] == "2")
                {
                    queue.RemoveAt(0);
                }
                // if line starts with 3, print number at head of queue to stdout
                else if (operation[0] == "3")
                {
                    Console.WriteLine(queue[0]);
                }
            }
        }
    }
}
