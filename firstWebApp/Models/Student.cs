using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace firstWebApp.Models
{
    public class Student
    {
        public static int IdCounter = 0;
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

        private int _ClassId;
        public int ClassId
        {
            get { return _ClassId; }
            set { _ClassId = value; }
        }

        public Student(string Name, int ClassId)
        {
            _Id = IdCounter;
            IdCounter++;
            _Name = Name;
            _ClassId = ClassId;
        }
    }
}