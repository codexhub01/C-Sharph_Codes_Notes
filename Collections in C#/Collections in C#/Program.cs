using System;
using System.Collections;
namespace ABC
{
    public class User
    {
        public int productid { get; set; }
        public string productname { get; set; } 
    }
    class A
    {
        public static void Main()
        {
            //Non-Generic
            ArrayList ars = new ArrayList();
            ars.Add(10);
            ars.Add("Mayank");

            //Generic
            List<int> list = new List<int>();
            List<User> users = new List<User>(); // Only specified typs is allowed whether u have created class or something else

            //Dictionary
            Dictionary<int , string> dic = new Dictionary<int , string>();
            dic.Add(1, "Mayank");

            //Stack
            Stack<User> stack = new Stack<User>();  

            //Queue
            Queue<User> queue = new Queue<User>();

            //This works because lsit implements Ienumerable
            foreach(var data in list)
            {

            }

            IEnumerable<User> users1 = new List<User>();

            //Ilist
            IList list2 = new List<User>();
        }
    }
}

/*  

Collections :-
-> A class that stores & manage objects efficiently
-> Example :- let suppose u have 10 users , 100 produtcs and etc , so now u are not going to create a object one by one fir this we do 
List<User> users = new List<User>();

Whty Collections ?
-> Lets talk about List , because Arrays have an some limitations

Non_Generic Collections :-
ArrayList
Hashtable
Stack
Queue

Generic Collections :-
List<T>
Dictionary<TKey,TValue>
Stack<T>
Queue<T>
HashSet<T>

Generic collection introduced because non-generic create issues in boxng &unboxing , poor performance , less safe

-> To use generic we have to include using System.Collections
 
-> Dictionary use hash table internally
 
-> Stack use Last In First Out 
 
-> Queue use First In First Out 
 
-> Hashset stores unique value only

IEnumerable :-
-> Iteration capability

IICollection :-
-> It's provides Add , remove , count etc operations

Ilist :- 
-> Its provides index based access
 */