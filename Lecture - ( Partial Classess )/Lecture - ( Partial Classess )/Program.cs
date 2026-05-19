using Lecture_____Partial_Classess__;
using System;
namespace A
{
    class ABC
    {
        public static void Main(String[] args)
        {
            P1 ob = new P1();
            ob.M1();
            ob.M2 ();
            Console.ReadLine();
        }
    }
}

/*  
 
Partial class :-
-> Splitting single class defination into multiple files 
-> It's only availiable during development not during compiled time
-> It must use partial keyword
-> Have same class name
-> Esist in same namespace
 
Partial Method :-
-> method declaration whose implementation is optional
-> and these method should be in partial class only
 
 
 */