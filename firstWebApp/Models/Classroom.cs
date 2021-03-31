namespace firstWebApp.Models
{
    public class Classroom
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

        private int _TeacherId;
        public int TeacherId
        {
            get { return _TeacherId; }
            set { _TeacherId = value; }
        }

        private int _StudentId;
        public int StudentId
        {
            get { return _StudentId; }
            set { _StudentId = value; }
        }
        public Classroom(string _Name, int _TeacherId)
        {
            this._Id = IdCounter;
            IdCounter++;
            this._Name = _Name;
            this._TeacherId = _TeacherId;
         
        }
    }
}