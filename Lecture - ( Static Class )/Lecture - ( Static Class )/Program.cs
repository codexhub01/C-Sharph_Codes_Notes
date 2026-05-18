using System;
namespace A
{
    //static class
    static class Stclass
    {
        public static void Show()
        {

        }

        //static constructor
        static Stclass()
        {
            Console.WriteLine("Static Constructor");
        }
    }

    class ABC
    {
        //static variable
        public static string static_var = "ABC College";

        //static method
        public static int static_method(int a, int b)
        {
            return a + b;
        }
        public static void Main(String[] args)
        {
            //calling static variable
            Console.WriteLine(ABC.static_var);

            //calling static method
            ABC.static_method(2, 6);

            Console.ReadLine();
        }
    }
}


/*
Static Keyword :- 
-> members belongs to class itself not to object 
-> Main method is static because program starts before any object exist

Static class:-
-> No object create for static class
-> only contain static members

Static Constructor :-
->It initialize static data
-> Runs automxatically
-> execute only once
 -> runs before first object / static class

Static Methods :-
-> static methods can not directly access non static members , bceause non static members required object
-> It can not use this keyword because this refers to current object

 */