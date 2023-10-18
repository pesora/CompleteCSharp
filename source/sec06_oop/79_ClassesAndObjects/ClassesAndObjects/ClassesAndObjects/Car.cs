using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Car
    {   
        // Member variables
        private string _name; // private field typically used for storing data.
        private int _hp;
        private string _color;

        // Constructor
        public Car(string name, int hp = 0, string color = "black")
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color = color;
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
