using System;
namespace ABC
{
    class Student
    {
        private string[] students =
       {
            "Mayank",
            "Rahul",
            "Ankit"
        };

        public string this[int index]
        {
            get
            {
                return students[index];
            }

            set
            {
                students[index] = value;
            }
        }

        public string GetStudent(int index)
        {
            return students[index];
        }

        public void SetStudent(int index, string name)
        {
            students[index] = name;
        }
        public static void Main(String[] args)
        {
            Student s = new Student();

            Console.WriteLine(s[0]);

            s[1] = "Rohit";

            Console.WriteLine(s[1]);

            //Without indexer
            Console.WriteLine(s.GetStudent(0));
            s.SetStudent(1, "Rohit");

            //With indexer
            Console.WriteLine(s[0]);
            s[1] = "Rohit";
        }
    }
}

/*  
 
Indexer :-
-> It allows an object to be accessed like an array without exposing the underlying collection
-> Instead of Student.GetStudent(0) , u can write student[0]
-> It make objects behave like arrays
-> Basically we are accessing indexes over here beause of which things are getting possible

*/