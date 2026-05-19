using System;
namespace ABC
{
    class X
    {
        public static void main(String[] args)
        {
            int x = 10;
            int y = 0;
            int res = x / y;

            //try-catch
            try
            {

            }
            catch (FormatException)
            {
                Console.WriteLine("Exception handled");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero exception");
            }
        }
    }
}

/*  
 
 Exception :-
-> run time error that interups normal program execution

Exception handling keywords :-
-> try
-> catch
-> finally :- this block executes always whether the exceptions occurs orot
-> throw

-> multiple catch blocks can be there
-> specific type of exception must comes first before ( Exception )
 








 
 
 */
