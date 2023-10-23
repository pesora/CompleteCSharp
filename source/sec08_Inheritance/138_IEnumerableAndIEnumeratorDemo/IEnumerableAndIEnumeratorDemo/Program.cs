using System.Collections;
using System.Collections.Generic;

namespace IEnumerableAndIEnumeratorDemo
{
    internal class Program
    {
        // 1.IEnumerable <T> for generic collections
        // 2.IEnumerable for non generic collections


        /// <summary>
        /// IEnumberable<T> contains a signle method that you must implement when implementing this interface;
        /// GetEnumerator(), which returns an IEnumerator<T> object.
        /// The returned IEnumerator<T> provides the ability to iterate through the collection
        /// by exposing a Current property that points at the object we are currently at in the collection
        /// </summary>
        /// 

        /// when it is recommended to use the IEnumerable interface:
        /// - Your collection represents a massive database table;
        /// your don't want to copy the entire thing into memory and cause performance issues in your application.
        /// When it is not recommended to use the IEnumerable iterface:
        /// You need the results right away and are possibly mutaging / editing the objects later on.
        /// In this case, it is better to use an Array or a List

        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach (Dog dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }

        }
    }

    class Dog
    {
        public string Name { get; set; }
        public bool IsNaughtyDog { get; set; }
        public Dog(string name, bool isNaughtyDog)
        {
            Name = name;
            IsNaughtyDog = isNaughtyDog;
        }

        public void GiveTreat(int numberofTreats)
        {
            Console.WriteLine("Dog: {0} said wuoff {1} times!", Name, numberofTreats);
        }
    }

    //a class named DogShelter this class contaions a generic collection of type Doog
    //objects of this class can't be used inside a for each loop because it lacks an implemented of the IEnumerable interface
    class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> dogs;

        public DogShelter() 
        {
            //initialize the dogs list using the collection-initializer
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Oreo", false),
                new Dog("Pixel", false),
            };
        }

        public IEnumerator<Dog> GetEnumerator() //generic
        {
            //So we need to change that here.
            //We can now implement what should happen with our get enumerator method once it is called.
            //So in order to fix it, what we're going to say here is just return.
            //Dogs our list dogs dot get enumerator just like so.
            //And that will be the implementation because our dog shelter is now implementing the enumerable interface.

            return dogs.GetEnumerator();
            //throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() //non-generic
        {
            throw new NotImplementedException();
        }
    }
}