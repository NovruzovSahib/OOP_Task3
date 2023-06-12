using OOP_Task3;
using System.Drawing;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Class with constructor");
        Car1 car = new Car1("Sedan", "BMW", 2, "Black", 2012, true);
        Console.WriteLine($"car cartype is {car.CarType}\ncar model is {car.Model}\ncar engine is {car.Engine}\ncar color is {car.Color}\ncar productyear is {car.ProductYear}\ncar isautomatic is {car.IsAutomatic}");
        Console.WriteLine();
        Console.WriteLine("Car1 Method");
        car.CarInfo1();
        Console.WriteLine();
        Console.WriteLine("Record with init");
        Car2 car2 = new Car2
        {
            CarType = "Liftback",
            Model = "Hyundai",
            Color = "Green",
            ProductYear = 2013,
            IsAutomatic = true
        };
        Console.WriteLine($"car2 cartype is {car.CarType}\ncar2 model is {car.Model}\ncar2 engine is {car.Engine}\ncar2 color is {car.Color}\ncar2 productyear is {car.ProductYear}\ncar2 isautomatic is {car.IsAutomatic}");
        Console.WriteLine();
        Console.WriteLine("Record changed");
        Car2 car3 = car2 with { Color = "DarkGray" };
        Car2 car4 = car2 with { Model = "Kia" };
        Console.WriteLine($"car3 color is {car3.Color}\ncar4 model is {car4.Model}");

        Car2 car5 = new Car2();
        car5.CarInfo2("Liftback","Kia","2.2","Black",2022,true);
        Console.ReadLine();
     

    }

}