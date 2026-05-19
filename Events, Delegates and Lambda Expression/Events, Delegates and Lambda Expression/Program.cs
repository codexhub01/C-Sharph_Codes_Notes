using System;
namespace ABC
{
    delegate void delegate_method();
    class X
    {
        static void show()
        {
            Console.WriteLine("Hey HI");
        }

        static void Display()
        {
            Console.WriteLine("Hello");
        }

        //Events

        public event delegate_method my_event;

        public void start()
        {
            Console.WriteLine("Start method ");
            my_event?.Invoke();
        }

        public static void Main(string[] args)
        {
            //Storing reference of show method
            delegate_method d = show;

            //Here reference is getting stroed of another method
            d += Display;
            
            //calling method
            d();


            X obj = new X();
            obj.my_event += show;
            obj.my_event += Display;
            
        }
    }
}

/*  
Delegates :-
-> It stores reference of a method
-> It allow method to be passed like a variable
-> Example like remote control
-> Its a foundation of events & lambda expression
-> It store methods with not rerturn type & no parameters
-> Internally irt derived from System.Delegate 
 -> d += Display :- means adding reference of another method
 
 Events :-
-> mechanism for notification or communication between objects
-> It uses delegates internally
-> Events are delegates based notification
-> .Invoke() :- safely trigger event 

 */