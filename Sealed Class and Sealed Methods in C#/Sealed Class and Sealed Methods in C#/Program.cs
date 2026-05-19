using System;
namespace ABC
{
    sealed class sealed_class
    {
        public void M1()
        {
            Console.WriteLine("Methode inside sealed class");
        }
    }

    class Non_sealed
    {
        public virtual void show()
        {
            Console.WriteLine("Method insde non sealed class");
        }
    }

    class child_class : Non_sealed
    {
        public sealed override void show()
        {
            Console.WriteLine("selaed method inside child class or derived class");
        }
    }

    class X
    {
        public static void main(string[] args)
        {
            sealed_class sc = new sealed_class();
            sc.M1();
        }
    }
}

/*  
 Sealed :- 
-> It means stop inheritance

Sealed class :-
-> class that can not be inherited
-> It ensure that class behaviour can not change through inheritance
-> Some of .net classes are sealed like string , Math , Convert etc
-> You can create object of sealed class
 
 Sealed method :- 
-> overriden method that can not be overriden again
-> These method can only be used wth override keyword
 
 
 
 
 
 */