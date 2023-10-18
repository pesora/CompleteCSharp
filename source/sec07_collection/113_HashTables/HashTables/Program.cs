using System.Collections;

namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.Id, stud1 );
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            // retrieve individual item with known ID
            Student storedStudend1 = (Student)studentsTable[stud1.Id];
            //Console.WriteLine("Student ID:{0}, Name:{1}, GPA{2}", storedStudend1.Id, storedStudend1.Name, storedStudend1.GPA);
            
            //retrieve all values from a Hashtable
            foreach(DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID:{0}", temp.Id);
                Console.WriteLine("Student Name:{0}", temp.Name);
                Console.WriteLine("Student GPA:{0}", temp.GPA);
            }
            Console.WriteLine();

            foreach(Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID:{0}", value.Id);
                Console.WriteLine("Student Name:{0}", value.Name);
                Console.WriteLine("Student GPA:{0}", value.GPA);
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
            this. GPA = GPA;
        }
    }
}