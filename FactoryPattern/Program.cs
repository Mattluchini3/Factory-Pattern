namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the food item you would like to order:");
            Console.WriteLine("Type 1 sides, type 2 steaks");

            int UserInput = int.Parse(Console.ReadLine());

            IRestuarant order1 = FoodFactory.GetRestuarant(UserInput);

            order1.Food();
           
        }
    }
}



//Create an Interface named IVehicle that has a stubbed out public void Drive method.
//Create 2 new public classes that will conform to IVehicle.
//Example) Car, Motorcycle, BigRig
//Note: These classes must conform to IVehicle and implement the Drive() method -
//which will just Console.WriteLine(“Building a new Car!”)

//Now we will make our static VehicleFactory class.
//It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of
//tires it’s given as a parameter
//Call this functionality in the Main method.