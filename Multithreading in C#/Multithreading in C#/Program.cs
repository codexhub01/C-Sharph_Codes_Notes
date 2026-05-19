using System;
namespace ABC
{
    class X
    {
        static void Display()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("print saomething");
            }
        }
        public static void main(String[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);

                // this means it will wait for 1 second
                Thread.Sleep(1000);
            }

            //creating custom thread and starting too by ourself
            Thread td = new Thread(Display);
            td.Start();

            Task.Run(() => { Console.WriteLine("print something"); });

        }
    }
}


/*       
 Thread :- 
-> smallest unit of execution inside a process
-> process conatins one or more thread
-> thread inside same process share memory
-> It shares same heap memory
-> all thread have their own stack , but shares same heap ( and this is a problem )

Multithreading :-
-> executing multiple threads concurrently
 
 Deadlock :-
-> means thraed waiting forever for each other

-> Moderly C# rarely uses thread , instaed of it they use task
 
 Async programming :- non blocking operations
 Async :- it does not always create new thread
 
 
 
 
 
 
 
 
 */