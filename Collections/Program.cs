using Collections.Assignment_1_Working_with_List_T;
using Collections.Assignment_4_Implementing_Undo_Redo_with_Stack_T;
using Collections.Assignment_5_Simulating_a_Ticketing_System_with_Queue_T;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Collections
{
    internal class Program
    {
        static void GetCountryByKey(Dictionary<int, string> d)
        {
            Console.WriteLine("plz enter a valid Code");

            string userInput = Console.ReadLine();
            bool isValidInput = int.TryParse(userInput, out int key);
            d.ContainsKey(key);

            if (d.ContainsKey(key))
                foreach (var dd in d)
                {
                    if (dd.Key == key)
                    {
                        Console.WriteLine($"The Country of Code {dd.Key} is {dd.Value}");
                        break;
                    }
                }
            else Console.WriteLine("In Valid Country Code");
        }



        static void Main(string[] args)
        {
            #region Assignment 1: Working with List<T>
            /* Create a List<Student> and:
                  o	Add at least 5 students. 
                  o	Print all students. 
                  o	Find a student by ID and update their grade.
                  o	Remove a student from the list.
                  o	Sort students by Grade in descending order.
                  o	Print the top 3 students.
               */



            ////Add at least 5 students. 
            //List<Student> students = new List<Student>() {
            //    new Student(){ Id=10, Name="Galal", Grade=87 },
            //    new Student(){ Id=20, Name="Nabil", Grade=79 },
            //    new Student(){ Id=40, Name="Maha", Grade=88.5 },
            //    new Student(){ Id=50, Name="Fares", Grade=90 }

            //};

            //Console.WriteLine("********");
            //students.Add(new Student { Id = 60, Name = "Israa", Grade = 92 });
            //students.Insert(2, new Student { Id = 30, Name = "Sarah", Grade = 97.2 });

            ////Print all students
            //foreach (var s in students)
            //    Console.WriteLine(s);


            //Console.WriteLine("********");
            //Console.WriteLine();
            //Console.WriteLine();
            ////Find a student by ID and update their grade
            //int index = students.FindIndex(N => N.Id == 10);
            //students[index].Grade = 70;

            //Console.WriteLine($"================ {students[index]} ===================");

            //Console.WriteLine("********");
            //Console.WriteLine();
            //Console.WriteLine();

            ////Remove a student from the list
            //students.Remove(students[3]);

            ////Sort students by Grade in descending order.
            //students.Sort(new StudentComparer());
            //students.Reverse();

            ////Print the top 3 students
            //List<Student> s1 = students.Slice(0, 3);
            //foreach (var s in s1) Console.WriteLine(s);

            #endregion


            #region Assignment 2: Working with Dictionary<TKey, TValue>
            /* Assignment 2: Working with Dictionary<TKey, TValue>
                 1.	Create a Dictionary<int, string> to store country codes and country names.
                 2.	Add the following data:

                 1 -> USA
                 91 -> India
                 44 -> UK
                 81 -> Japan
                 20 -> Egypt
                 3.	Perform the following:
                 o	Print all key-value pairs.
                 o	Ask the user for a country code and print the country name.
                 o	Check if a key exists before retrieving a value.
                 o	Remove an entry and print the updated dictionary.
             */

            //   Dictionary<int, string> dict = new Dictionary<int, string>();

            /*Add the following data:

                 1 -> USA
                 91 -> India
                 44 -> UK
                 81 -> Japan
                 20 -> Egypt*/


            //dict.Add(1, "USA");
            //dict.Add(91, "India");
            //dict.Add(44, "UK");
            //dict.Add(81, "Japan");
            //dict.Add(20, "Egypt");
            ////Print all key-value pairs
            //foreach (KeyValuePair<int, string> kvp in dict) Console.WriteLine(kvp); ;
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine();

            ////Ask the user for a country code and print the country name.
            ////Check if a key exists before retrieving a value.
            //Program.GetCountryByKey(dict);

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine();

            ////Remove an entry and print the updated dictionary
            //string s;
            //dict.Remove(1,out  s);
            //Console.WriteLine(s);


            #endregion


            #region Assignment 3: Using HashSet<T> for Unique Values

            /*Assignment 3: Using HashSet<T> for Unique Values

                1.	Create a HashSet<string> to store unique programming languages.
                2.	Add the following:

                "C#"
                "Java"
                "Python"
                "C++"
                "C#"
                "Java"
                3.	Print all elements to verify duplicates are not stored.
                4.	Check if "JavaScript" exists in the set.
                5.	Remove "Python" from the set and print the updated values
            */
            //HashSet<string> hSet = new HashSet<string>() { "C#", "Java", "Python", "C++", "C#", "Java" };

            //foreach (var h in hSet) Console.WriteLine(h);

            //Console.WriteLine("------------------------");
            //Console.WriteLine();

            //bool isExist = hSet.Contains("JavaScript");
            //Console.WriteLine($"The Existance of JavaScript is --> {isExist}");

            //Console.WriteLine("------------------------");
            //Console.WriteLine();

            //hSet.Remove("Python");

            //foreach (var h in hSet) Console.WriteLine(h);
            #endregion


            #region Assignment 4: Implementing Undo/Redo with Stack<T>

            /*Assignment 4: Implementing Undo/Redo with Stack<T>

            1.	Create a Text Editor Simulation where:
                o	Stack<string> undoStack keeps previous states.
                o	Stack<string> redoStack stores redoable actions.
            2.	Allow the user to:
                o	Type a new text (add it to the undo stack).
                o	Undo (pop from undo stack and push to redo stack).
                o	Redo (pop from redo stack and push back to undo stack).
            3.	Display the current text after each operation.      */


            //TextEditor stackTt = new TextEditor();

            //stackTt.AddNewText("Hello ");
            //stackTt.AddNewText("every ");
            //stackTt.AddNewText("body ");
            //stackTt.AddNewText("we ");
            //stackTt.AddNewText("love ");
            //stackTt.AddNewText("dot net");
            //stackTt.AddNewText("CORE");

            //foreach (var s in stackTt.StackT)
            //Console.WriteLine(s);

            //Console.WriteLine("============================");


            //stackTt.Undo();
            //stackTt.Undo();
            //foreach (var s in stackTt.StackT)
            //    Console.WriteLine(s);

            //Console.WriteLine("============================");



            //stackTt.Redo();

            //foreach (var s in stackTt.StackT)
            //    Console.WriteLine(s);

            //Console.WriteLine("============================");


            #endregion


            #region Assignment 5: Simulating a Ticketing System with Queue<T>
            /*Assignment 5: Simulating a Ticketing System with Queue<T>
                1.	Create a Queue<string> for customer service tickets.
                2.	Perform the following operations:
                    o	Add new tickets ("Ticket#1", "Ticket#2", etc.).
                    o	Process tickets FIFO style (use .Dequeue()).
                    o	Display remaining tickets in the queue.
                */

            //TicketingSystem ticketingSystem = new TicketingSystem();

            //ticketingSystem.AddTicket("T1");
            //ticketingSystem.AddTicket("T2");
            //ticketingSystem.AddTicket("T3");
            //ticketingSystem.AddTicket("T4");
            //ticketingSystem.AddTicket("T5");


            //ticketingSystem.DisplayRemainingTickets();
            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine();

            //ticketingSystem.ProcessTickets();
            //ticketingSystem.ProcessTickets();
            //ticketingSystem.ProcessTickets();

            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine();
            //ticketingSystem.DisplayRemainingTickets();


            #endregion


            #region Assignment 6: Combining Collections

            /*Assignment 6: Combining Collections
                1.	Create a Dictionary<int, HashSet<string>> to store students' subjects.
                    o	Each student ID is mapped to a HashSet of subjects.
                2.	Perform the following:
                    o	Add subjects for 3 students.
                    o	Prevent duplicate subjects.
                    o	Retrieve and print subjects for a specific student.
                    o	Remove a subject from a student.*/








        #endregion
    }


    }
}
