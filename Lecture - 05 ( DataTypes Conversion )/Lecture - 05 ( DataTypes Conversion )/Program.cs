int a = 50;

//Implicit Conversion
float b = a;
Console.WriteLine(b);

float c = 100f;

//Explicit Conversion
int d = Convert.ToInt32(c);
Console.WriteLine(d);

string s1 = "1000";
string s2 = "1992";

//Explicit Conversion
int value = Convert.ToInt32(s1) + Convert.ToInt32(s2);
Console.WriteLine(value);

/*
    value type ( faster ) :- store actual value
    refrence types ( slower ) :- store memory refrence
    pointer types :- store memory address
    
    Value Types :- 
    1. They are generally stored in stack memory mostly but if inside object then they can exist in heap too
    2. Each variable gets its own copy

    Refrenced Types :- 
    1. Memory Address , not actual object data directly 
    2. Object are generally stored in heap memory

    Boxing & Unboxing :-
    1. Boxing :- value type into refrenced type
    2. Unboxing :- Converting object into value type
 */

