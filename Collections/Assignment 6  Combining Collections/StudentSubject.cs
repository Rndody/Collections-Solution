using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Assignment_6__Combining_Collections
{
        internal class StudentId
        {
            public int Id { get; set; }
            public StudentId(int id)
            {
                Id = id;
            }
        }
        internal class Subjects
        {
            public HashSet<string> SubjectS { get; set; } = new HashSet<string>();
            public Subjects(IEnumerable<string> s)
            {
                SubjectS = new HashSet<string>(s);
            }
        }
    internal class StudentSubject
    {

        public Dictionary<StudentId, Subjects> StudentSubjects { get; set; } = new Dictionary<StudentId, Subjects>();

        public void AddSubjects(int iid, IEnumerable<string> subjs)
        {
            //StudentId(iid);
            //Subjects()
            //StudentSubjects.Add(iid, subj);
        }


    }
}
