namespace firstWebApp.Models
{
    public class Teacher
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

        public Teacher(string _Name, int _ClassId)
        {
            this._Id = IdCounter;
            IdCounter++;
            this._Name = _Name;
            this._ClassId = _ClassId;
        }
    }
}