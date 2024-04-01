using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cm
{
    internal class Group
    {
        public int No;
        Student[] students;
        public int StudentLimit;
        public Group() 
        {
            students = new Student[0];
        }
        public void AddStudent(Student student) 
        {
            StudentLimit = students.Length;
            if (StudentLimit>=0 && StudentLimit<=20)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("!Student Limit:20");
            }
        }
        public void ShowStudentsInfo()
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{students[i].Fullname} " +
                    $"{students[i].GroupNo} " +
                    $"{students[i].AvgPoint} ");
            }
        }
        public void ShowStudentInfo(Student student)
        {
            Console.WriteLine($"{student.Fullname} " +
                    $"{student.GroupNo} " +
                    $"{student.AvgPoint} ");
        }
      
        
    }
}
