using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstWebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace firstWebApp.Pages
{
    public class StudentsModel : PageModel
    {
        public string Message { get; set; } = "Today is: ";

        // public Student Sicco = new Student("Sicco", 1);
        
        //property that contains the list of the students + getter/setter
        public List<Student> Students { get; set; }
        
        //constructor - assigns the result of the "GetStudentList" to the "Students" property
        public StudentsModel()
        {   
            Students = GetStudentList();
        }
        
        //getter to get one specific student based on the ID
        public Student GetStudent(int Id)
        {
            return Students.ElementAt(Id);
        } 
        
      public List<Student> GetStudentList()
      {  
          //creates list of the names
          List<string> studentNames = new List<string>()
              {"Anne", "Billy", "Bobbie", "Enrico", "Camilla", "Johnny", "Steve", "Sonya", "Alberto", "Ida"};
       
          //creates list of student objects
          List<Student> students = new List<Student>();
          Student.IdCounter = 0;
          for (int i = 0; i < studentNames.Count; i++)
          {
              students.Add(new Student(studentNames.ElementAt(i),i%2 == 0 ? 1 : 2));
          }
          return students;
      }
    }
    
}
