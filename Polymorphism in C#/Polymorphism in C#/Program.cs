using System;
namespace ABC
{

    class A
    {
        public int Method_overload1(int i)
        {
            return i;
        }

        public int Method_overload1(int i , int j)
        {
            return i+j;
        }

        public virtual void Override_method()
        {
            Console.WriteLine("Override method 1");
        }

    }

    class B :A
    {
        public override void Override_method()
        {
            base.Override_method();
            Console.WriteLine("Override method 1");
        }
    }




    class X
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Polymorphism");
        }
    }
}
/*  
 Polymorphism :-
-> One thing behave in multiple forms

Types of polymorphism :-
-> Compile time polymorphism ( Method overloading )
-> Runtime polymorphism ( Method overriding )
 
 
 Stack :- stores refrence means left part before equal too 
 Heap :- which stores object that is in right side of double equal too
 
 
 
 
 
 
 
 */