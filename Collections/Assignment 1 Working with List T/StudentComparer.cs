using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Assignment_1_Working_with_List_T
{
    internal class StudentComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            if(x==null|| y==null) return -1;
            return x.Grade.CompareTo(y.Grade);
        }
    }
}
