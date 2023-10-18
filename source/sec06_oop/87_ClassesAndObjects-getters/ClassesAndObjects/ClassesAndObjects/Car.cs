

using System.Drawing;

namespace ClassesAndObjects
{
    internal class Car
    {   
        // Member variables
        // access modifier private
        private string _name; // private field typically used for storing data.
        private int _hp;
        private string _color;

        public int GetHp()
        {
            return _hp;
        }

        public string GetName()
        {  
            return _name;
        }

        public void SetName(string name)
        {   
            if(name == "")
            {
                _name = "DefaultName";
            }
            else
            {
                _name = name;
            }
            
        }

        // Default Constructor
        public Car()
        {
            _name = "Car";
            _hp = 5;
            _color = "red";
            Drive();
        }
        // Partial Specification Constructor
        public Car(string name, int hp = 0)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color="red";
            Drive();
        }
        // Full Specification Constructor
        public Car(string name, int hp, string color)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color = color;
            Drive();
        }

       

        // Member Method
        public void Drive() { 
            Console.WriteLine(_name + " is driving"); 
        }

        // Member Methods
        public void Stop()
        {
            Console.WriteLine(_name + " stopped!");
        }

        public void Details()
        {
            Console.WriteLine("The "+_color +" car "+_name
                + " has "+ _hp + " hp");
        }
    }
}
