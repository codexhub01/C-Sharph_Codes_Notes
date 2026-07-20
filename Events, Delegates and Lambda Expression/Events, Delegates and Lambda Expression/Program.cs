using System;
namespace ABC
{
    public delegate void MyDelegate();

    public delegate void operation(int a, int b);
    class X
    {
        
        public static void Main(string[] args)
        {
            MyDelegate obj = PrintMessage;
            operation add1 = Add;
            add1(3, 4);
            Multiply(13, 4);
            obj();
        }

        static void PrintMessage()
        {
            Console.WriteLine("Hello World");
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}

/*
    
Delegate :-
-> It's a type safe function pointer
-> Holds a refrence of a method
-> Instead of calling directly , u call it through delegate


Why delegates ?
-> Suppose u wanna different methods to execute dynamically


Types of delegates :-
-> Single cast ( One method )
-> Multicast delegate ( Multiple methods )
-> Bult in delegates ( Instead of creating delegates , C# provides three built int delegates )
    1. Action :- returns nothing
    2. Func :- returns a value
    3. Predicate :- always returns bool


Event :-
-> Its based on delegates
-> It allows one object to notify another object when something happens







*/