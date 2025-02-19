using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Assignment_1_Working_with_List_T
{
    internal class Student
    {

        /* 1.	Create a class Student with:
                o	Id (int)
                o	Name (string)
                o	Grade (double)
         */


        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        public Student()
        {
            
        }
        public Student(int id,string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }


        public override string ToString()=>       
             $"ID:{Id} *** Name:{Name} *** Grade:{Grade}";
        
    }
}
