namespace _115_DictionariesDemo
{
    internal class Program
    {
        // key - value
        // Auto - car
        static void Main(string[] args)
        {
            //database
            Employee[] employees = {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 21),
                new Employee("Secretrary", "Petra", 28, 18),
                new Employee("Lead Developer", "Artories", 55, 35),
                new Employee("Intern", "Ernest", 22, 8),
            };

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach(Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            //(1) ContainsKey
            string key = "CEO";
            if(employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory[key];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salay);

            }
            else
            {
                Console.WriteLine("No employee found with this key {0}", key);
            }
            Console.WriteLine();

            //(2) TryGetValue()
            Employee result = null;
            //using TryGetValue() it returns true if the operation was successful, or false otherwise
            if (employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value Rerieved!.");

                Console.WriteLine("Employee Name: {0}", result.Name);
                Console.WriteLine("Employee Role: {0}", result.Role);
                Console.WriteLine("Employee Age: {0}", result.Age);
                Console.WriteLine("Employee Salary: {0}", result.Salay);
            } else
            {
                Console.WriteLine("The key does not exist");
            }
            Console.WriteLine();

            //(3) ElementAt()
            for (int i = 0; i <employeesDirectory.Count; i++)
            {
                //using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                //print the key
                Console.WriteLine("key: {0}", keyValuePair.Key);
                //storing the value in an employee object
                Employee employeeValue = keyValuePair.Value;
                //printing the properties of the employee object
                Console.WriteLine("Employee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salay);
            }
            Console.WriteLine();
        }
    }
}

class Employee
{
    public string Role { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public float Rate { get; set; }

    //Year Salary = rate/h * number of days * number of weeks * number of months

    public float Salay
    {
        get
        {
            return Rate * 8 * 5 * 4 * 12;
        }
    }
    
    public Employee(string role, string name, int age, float rate)
    {
        this.Role = role;
        this.Name = name;
        this.Age = age;
        this.Rate = rate;
    }
}