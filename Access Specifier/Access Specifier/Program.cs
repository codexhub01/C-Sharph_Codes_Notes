using System;
namespace ABC
{
    class XYZ
    {
        public string name;

        private int accno;

        protected string designation;
    }

    class B : XYZ
    {
        void M1()
        {
            designation = "CEO";
        }
    }
    public class A
    {
        public static void main(String[] args)
        {

        }
    }
}

/*  
 
 Access modifiers :-
-> who can access class members

Main access specifier :-
-> public
-> private
-> protected
-> internal
-> protected internal
-> private protected

public :-
-> accessible from anywhere
 
 private:-
-> accessible only inside same class

protected :-
-> accessible inside class & derived class
-> mainly used in inheritance

internal :-
-> accessible with in same assembly or project

protected internal :-
-> access in same assembly or derived class outside assembly

 default access level :-
 -> class member :- private
 -> top level classes :- internal
 
 With the help of these access specifier , we achieve encapsulation
 
 */