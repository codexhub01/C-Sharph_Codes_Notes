using System;
using System.Threading;
namespace ABC
{
    class X
    {
        public static void main(String[] args)
        {
            Thread th = new Thread(PrintNumbers);
            th.Start();
            th.Join();


            Task task = Task.Run(() => { 
                Console.WriteLine(""); 
            
            });

        }

        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}


/*       

Multithreading :-
-> It allows multiple threads to execute concurrently within the same process
-> With the help of multithreding multiple task can execute at once


Example :-
-> Downloading a file while updating the ui

Process :-
-> Independent program
-> Has its own memory
-> Heayyweight
-> Slower to create


Thread :-
-> Smallest exexcution unit inside a process
-> Shares process memory
-> Lightweight
-> Faster to create

Example :-


Chrome :-
-> Tab 1 ( Thread )
-> Tab 2 ( Thread )
-> Rendering thread

Chrome is a process containing multiple threads

-> th.start() :- to start thread
-> th.join() :- if this use then it will wait for the thread 1 to complete


Thread class limitations :-
creating many threads is expensive :-
1. High memory ussage
2. Context switching overhead
3. slower performance


That's why modern .net applications typically use TPL ( Task Parallel Library )

So instead of using thread like creating an object & all we do this

Task.Run(() =>
{
    Console.WriteLine("Running...");
});


Thread :-
-> Low level
-> Manual management
-> Expensive
-> Create OS today
-> Less common today

Task :-
-> High level 
-> Managed by task scheduler
-> Lightweight
-> Use thread pool
-> preferred in modern .net apps


Thread Pool :-
-> Maintains resuable threads
-> It reuses existing threads
-> Usually we dont call it directly , task.run() uses it internally


Race Condition :-
-> Multiple threads updating same variable
 */