using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace firstWebApp.Pages
{
    public class TeachersModel : PageModel
    {   public string Message { get; set; } = "Today is: ";

        //property that contains the list of the teachers + getter/setter
        public List<Teacher> Teachers { get; set; }
        
        //constructor - assigns the result of the "GetTeacherList" to the "Teachers" property
        public TeachersModel()
        {
            Teachers = GetTeacherList();
        }
        
        //getter to get one specific teacher based on the ID
        public Teacher GetTeacher(int Id)
        {
            return Teachers.ElementAt(Id);
        } 
        
        public List<Teacher> GetTeacherList()
        {  
            //creates list of the names
            List<string> teacherNames = new List<string>()
                {"Mr.Loki", "Mrs.Freya"};
       
            //creates list of teacher objects
            List<Teacher> teachers = new List<Teacher>();
            Teacher.IdCounter = 0;
            for (int i = 0; i < teacherNames.Count; i++)
            {
                teachers.Add(new Teacher(teacherNames.ElementAt(i),i%2 == 0 ? 1 : 2));
            }
            return teachers;
        }
    }
}
