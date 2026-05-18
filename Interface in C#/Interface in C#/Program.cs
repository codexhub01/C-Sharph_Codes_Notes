using System;
namespace ABC
{
    interface I1
    {
        public void M1()
        {
            Console.WriteLine("Method inside interface");
        }
        
    }

    class P1 : I1
    {

        public void M1()
        {
            
            Console.WriteLine("Method inside class");
        }
    }

    class X
    {
        public static void Main(String[] args)
        {
           P1 p = new P1();
            p.M1();
            
            Console.ReadLine();
        }
    }
}


/*  
 
 Interface :-
-> Its a kind of contract thatd defines what a class must implement

 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */