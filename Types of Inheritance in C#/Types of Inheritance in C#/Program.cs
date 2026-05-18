using System;
namespace ABC
{
    class parent
    {
        public void M1()
        {
            Console.WriteLine("Dont know");
        }
    }

    class Single : parent
    {
        public int no;
        public void M2()
        {
            base.M1();
            Console.WriteLine("Single Inheritance");
        }
    }


    class Multilevel : Single
    {
        public void M4()
        {
            Console.WriteLine("Multilevel Inheritance");
        }
    }

    class Herirachichal : Single
    {
        public void M5()
        {
            Console.WriteLine("Herirachichal Inheritance");
        }
    }


    interface I1
    {
        public void Show();
    }

    interface I2
    {
        public void Display();
    }

    class Multiple : I1 , I2
    {
        public void Show()
        {
            Console.WriteLine("Method of interface 1");
        }
        public void Display()
        {
            Console.WriteLine("Method of interface 2");

        }


    }
    class X
    {
        public static void main(string[] args)
        {

        }
    }
}
/*  

Types of inheritance :-
-> Single
-> Multilevel
-> Herirachichal
-> Multiple :- this does not support through classess , avoid this because of diamond problem ( ambiguty )
-> Hybrid Inheritance
    
 
 
 
 
 
 
 
 
 
 
 
 */