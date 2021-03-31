using System.Collections.Generic;
using firstWebApp.Pages;

namespace firstWebApp.Models
{
    public class Classroom
    {
        public static int IdCounter = 1;
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private List<Teacher> _teachers;
        public List<Teacher> teachers
        {
            get { return _teachers; }
            set { _teachers = value; }
        }

        private List<Student> _students;
        public List<Student> students
        {
            get { return _students; }
            set { _students = value; }
        }

        public string getAllStudentNames()
        {
            string studentNames = "";
            foreach (var student in students)
            {
                if (studentNames.Equals(""))
                {
                    studentNames = student.Name;
                }
                else
                {
                    studentNames = studentNames + ", " + student.Name;
                }
            }
            return studentNames;
        }
        public string getAllTeacherNames()
        {
            string teacherNames = "";
            foreach (var teacher in teachers)
            {
                if (teacherNames.Length == 0)
                {
                    teacherNames = teacher.Name;
                }
                else
                {
                    teacherNames = teacherNames + ", " + teacher.Name;
                }
            }
            return teacherNames;
        }

        public Classroom(string Name,List<Teacher> teachers,List<Student> students )
        {
            _Id = IdCounter++;
            _Name = Name;
            _teachers = teachers;
            _students = students;
        }
    }
}