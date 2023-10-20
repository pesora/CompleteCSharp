using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    internal class Dog : Animal
    {
        public bool IsHappy { get; set; }

        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }

        //simple override ot the virtual method Eat
        public override void Eat()
        {
            //to call the eat method from our base class we use the keysord "base" 
            base.Eat();
        }

        //override of the virtual method MakeSound
        public override void MakeSound()
        {
            //since every animal will make a tottaly different sound 
            //each animal will implement their own version of MakeSound
            Console.WriteLine("Wuuuf!");
        }

        //virtual method Play
        public override void Play()
        {
            if(IsHappy)
            {
                base.Play();
            }
        }
    }
}
