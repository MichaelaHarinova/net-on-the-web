using System.Collections.Generic;
using System.Linq;
using firstWebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace firstWebApp.Pages
{
    public class ClassroomsModel : PageModel
    {
        public string Message { get; set; } = "Today is: ";
        
        
        //property that contains the list of the classrooms + getter/setter
        public List<Classroom> Classrooms { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        
        
        //constructor - assigns the result of the "GetClassroomList" to the "Classrooms" property
        public ClassroomsModel()
        {
            Teachers = new TeachersModel().Teachers;
            Students = new StudentsModel().Students;
            Classrooms = GetClassroomList();
            
        }
        
        //getter to get one specific class based on the ID
        public Classroom GetClassroom(int Id)
        {
            return Classrooms.ElementAt(Id);
        } 
        
        public List<Classroom> GetClassroomList()
        {  
            //creates list of the names
            List<string> classroomNames = new List<string>()
                {"Vikings", "Master minds"};
       
            //creates list of class objects
            List<Classroom> classrooms = new List<Classroom>();
            Classroom.IdCounter = 0;
            for (int i = 0; i < classroomNames.Count; i++)
            {
                List<Teacher> teachers = new List<Teacher>();
                foreach (var teacher in Teachers)
                {
                    if (teacher.ClassId == i+1)
                    {
                        teachers.Add(teacher);
                    }
                }
                
                List<Student> students = new List<Student>();
                foreach (var student in Students)
                {
                    if (student.ClassId == i+1)
                    {
                        students.Add(student);
                    }
                }
                classrooms.Add(new Classroom(classroomNames.ElementAt(i),teachers,students));
            }
            return classrooms;
        }
        
    }
}