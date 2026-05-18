using System;
namespace A
{
    class ABC
    {
        //This can not be modifed because of const
        const int num = 100;
        static string name = "roy";

        public static void Main(String[] args)
        {
            name = "Mayank";
           
            
        }
    }
}

/*

-> Read & const exist so the value could not change

Const :-
-> Compile time constant because value fixed during compilation
-> Must assigned immediately
-> replace value directly

Readonly :-
-> value can assign during declaration or constructor
-> Initialize during run time
-> Fixed after run time initilization
-> stores in memory and then checked at runtime


*/