using System;
namespace std;
class X
{
    public static void main(String[] args)
    {
        //var which give error during compile time
        var x = 10;

        //x.Length;


        //Dynamic which gives error during runtime
        dynamic value = "Mayank";

        Console.WriteLine(value);

        value = 10;

        value = true;

        value = DateTime.Now;
    }
}
/*  
 var :-
-> Tells the compiler to figure out type during compilation , once type is determined it can not be changed
-> Faster because everything checks during compile time


Dynamic :-
-> dont check the now , check it at runtime










*/