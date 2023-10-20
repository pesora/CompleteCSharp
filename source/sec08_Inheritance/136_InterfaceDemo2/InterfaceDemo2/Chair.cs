using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    internal class Chair : Furniture, IDestroyable
    {
        //implrmrnyinh yhr interface's property
        public string DestructionSound {  get; set; }

        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;

            //initializing the interface's property with a value in the construdtor
            DestructionSound = "chairDestructionSound.mp3";
        }

        //implrmrnying the interface's method
        public void Destroy()
        {
            //when a chair gets destroyed we should play thge destruction sound
            //and spawn the destroyed chair parts
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");
        }

    }
}
