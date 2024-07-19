using System;
using System.Collections.Generic;

public class CarGallery
{
    public string Name { get; set; }
    public List<Car> Cars { get; set; }

    public CarGallery(string name)
    {
        Name = name;
        Cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        Cars.Add(car);
    }

    public void RemoveCar(Car car)
    {
        Cars.Remove(car);
    }

    public void ShowCars()
    {
        Console.WriteLine($"Cars in {Name} Gallery:");
        foreach (var car in Cars)
        {
            Console.WriteLine(car.ToString());
        }
    }
}

public class Car
{
    public string Model { get; set; }
    public string Marka { get; set; }
    public int Year { get; set; }

    public Car(string marka, string model, int year)
    {
        Marka = marka;
        Model = model;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Marka} - {Model} - {Year}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        CarGallery gallery = new CarGallery("Luxury Cars");

        Car car1 = new Car("Toyota", "Camry", 2020);
        Car car2 = new Car("Honda", "Accord", 2019);
        Car car3 = new Car("Tesla", "Model S", 2021);

        gallery.AddCar(car1);
        gallery.AddCar(car2);
        gallery.AddCar(car3);

        gallery.ShowCars();

        gallery.RemoveCar(car2);

        Console.WriteLine("\nAfter removing one car:");
        gallery.ShowCars();
    }
}
