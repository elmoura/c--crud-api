namespace ApiCrud.Code.Students
{
    public class Student
    {
        public Guid id { get; init; }

        public string name { get; private set; }
    
        public bool isActive { get; private set; }

        public Student(string name)
        {
            this.name = name;
            this.id = Guid.NewGuid();
            this.isActive = true;
        }
    }
}
