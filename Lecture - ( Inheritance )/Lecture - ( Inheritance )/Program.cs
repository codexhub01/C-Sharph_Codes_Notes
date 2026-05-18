using System;
namespace A
{
    //Basic Inheritance
    class C1
    {
        public void M1()
        {
            Console.WriteLine("Method M1 which is inside C1 class");
        }
    }

    class C2 : C1
    {
        public void M2()
        {
            Console.WriteLine("Method M1 which is inside C2 class");
        }
    }


    class ABC
    {
        public static void Main(String[] args)
        {
            //Basic Inheritance
            C2 c = new C2();
            c.M1();
            c.M2();

            Console.ReadLine();
        }
    }
}
/*  

Inheritance:-    
 -> mehanism where one class aquires properties & bhevaiours of another class

Types of inheritance :-
-> Single
-> Multilevel
-> Heiracchical
-> Multiple ( No via classess )
-> Hybrid ( No directly )

-> base keyword used to access parent class members
 
 Method overriding :-
-> Method have same name inside ederived class too but with override keyword
-> And method which is inside parent class would use virtual keyword
 
 
 
 
 
 
 
 
 */