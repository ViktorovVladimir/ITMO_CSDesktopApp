using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_CreatingDataBindingToCollectionObject
{
    public class Student
    {
        public string StudentName { get; set; }
        public bool IsEnrolled { get; set; }

        //--.
        public Student(string name, bool ch)
        {
            StudentName = name;
            IsEnrolled = ch;
        }
        
        //--.
        public string FullStudentData
        {
            get { return StudentName + "\t" + IsEnrolled; }
        }

        //--. or the same thing, but using lambda expression syntax
        //public string FullStudentData => StudentName + "\t" + IsEnrolled

    }


    //--.
    public class StudentList : ObservableCollection<Student> 
    { 
        public StudentList() 
        {
            Add(new Student("Lorin Kanev", true));
            Add(new Student("Ivan Petrov", false));
            Add(new Student("Sergey Masov", true));
            Add(new Student("Tais Frolova", true));
            Add(new Student("Elena Diva", false));
        }
    }

}
