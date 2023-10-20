using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    internal class Car : Vehicle, IDestroyable
    {
        //implementing the interface's property
        public string DestructionSound {  get; set; }

        //creating a new property to store the destroyable objects nearby
        //when a car gets destroyed it should also destory the nearby boject
        //this list is of type IDestroyable which means it can store any boject
        //that implements this interface and we can only access the properties and
        //methods in this interface
        public List<IDestroyable> DestroyableNearby;

        public Car(float speed, string color)// : base(speed, color) 
        { 
            this.Speed = speed;
            this.Color = color;
            DestructionSound = "CarExplosionsSound.mp3";
            DestroyableNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}", DestructionSound );
            Console.WriteLine("Create fire");

            foreach(IDestroyable destroyable in DestroyableNearby)
            {
                destroyable.Destroy();
            }
        }

    }
}
