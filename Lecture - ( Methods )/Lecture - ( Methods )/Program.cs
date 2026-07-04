using System;
namespace ABC
{
    class mob
    {
        public void M1()
        {
            Console.WriteLine("Hey this method is inside mob class");
        }

        public void parame(int a , int b)
        {
            Console.WriteLine("Sum of two numbers : " , a + b);
        }

        public void Ov1_1(int a , int b)
        {
            Console.WriteLine(a + b);
        }

        public void Ov1_1(int a, int b , int c)
        {
            Console.WriteLine(a + b + c);
        }

        public int pass_by_val(int a)
        {
            return a + 10;
        }

        public void 
            optional_para(int a = 10)
        {
            Console.WriteLine(a);
        }
        
        public void named_param(int x , int y)
        {
            Console.WriteLine("value of x & y is : " , x + " , " + y);
        }
    }
    class A
    {
        public static void M2()
        {
            Console.WriteLine("Hey this method is inside A class & method is M2");
        }

        static void change_by_ref(ref int no , ref int ns)
        {
            Console.WriteLine(no);
        }

        static void change_by_out(out int no, out int ns)
        {
            no= 21;
            ns= 19;
        }

        public static void Main(String[] args)
        {
          
            // to call non static method
            mob mb = new mob();
            mb.parame(6, 2);
            mb.M1();

            //to call multiple overloading methods
            mb.Ov1_1(8, 6);
            mb.Ov1_1(6, 2, 8);

            //pass by value
            int c = 10; ;int d = 100;
            int res = mb.pass_by_val(c);
            Console.WriteLine(res);

            //passed by ref
            A.change_by_ref(ref c , ref d);
            Console.WriteLine("After passed by ref : " , c);

            //passed by out
            A.change_by_out(out c, out d);

            //optional parameter
            mb.optional_para();
            mb.optional_para(100);

            //named parameter
            mb.named_param(y: 100, x: 18);

            Console.ReadLine();
        }
    }
}


/*
    Function :-
    -> A reusable block of code that perform a quick task
    -> Functions are officially calls as methods
    
    Function With Parameters :-
    -> Passing data into functions
    
    Parameters vs Arguments :-
    -> Parameter means varaiable in a method
    -> Arguments means actual value passed

    Static Methods :-
    -> Main() method is static
    -> Static method belongs to class itself
    -> No object needed
    
    Instance Method :-
    -> Object level
    -> Object Required

    Method Overloading :- 
    -> Multiple methods with same name , but different parameters
    -> Method signature include method name , parametr count & parameter type 
    -> No return type included

    Pass By Value :-
    -> In this copy of variable get passed

    Ref keyword :-
    -> actual refrence get passed
    -> variable must be initialize
    
    Out Keyword :-
    -> Initialization not required

    Optional Parameter :-
    -> Means during creating a parameter we initialize with some kind of value over there only

    Named Parameter :- 
    -> basically during passing values or arguments we mention paramater name too

*/