using System.Collections.Generic;
using System.Linq;
using firstWebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace firstWebApp.Pages
{
    public class ClassroomsModel : PageModel
    {
        public string Message { get; set; } = "In page model: ";
        
        
        //property that contains the list of the classrooms + getter/setter
        public List<Classroom> Classrooms { get; set; }
        
        //constructor - assigns the result of the "GetClassroomList" to the "Classrooms" property
        public ClassroomsModel()
        {
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
                {"Dumb", "Viking", "Master minds", "Super boring"};
       
            //creates list of class objects
            List<Classroom> classrooms = new List<Classroom>();
            Classroom.IdCounter = 0;
            for (int i = 0; i < classroomNames.Count; i++)
            {
                classrooms.Add(new Classroom(classroomNames.ElementAt(i),i+1));
            }
            return classrooms;
        }
        
    }
}