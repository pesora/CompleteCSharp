using System.Collections;

namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();

            Student[] students = new Student[5];
            students[0] = new Student(1, "Dennis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            foreach(Student s in students) 
            {
                if (!table.ContainsKey(s.Id))
                {
                    table.Add(s.Id, s);
                    Console.WriteLine("Student with ID{0} was added", s.Id);
                }
                else
                {
                    Console.WriteLine("Sorry, a student with the same ID already exists ID:{0}", s.Id);
                }
            }
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}