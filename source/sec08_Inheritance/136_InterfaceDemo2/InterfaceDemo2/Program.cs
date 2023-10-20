namespace InterfaceDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating two objectys of type chair
            Chair officChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            //creating a new object of tpe car
            Car damagedCar = new Car(80f, "Blue");

            //add the two chairs to the IDestroyable list of the car
            //so that when we destroy the car the destroyable objects
            //that are near the car will get destroyed as well
            damagedCar.DestroyableNearby.Add(officChair);
            damagedCar.DestroyableNearby.Add(gamingChair);

            //destroy the car
            damagedCar.Destroy();
        }
    }
}