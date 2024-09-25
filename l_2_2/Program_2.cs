using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

class Vehicle
{
    private double x;
    private double y;
    private double price;
    private double speed;
    private int year;

    public Vehicle(double x, double y, double price, double speed, int year)
    {
        this.x = x;
        this.y = y;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Vehicle information:");
        Console.WriteLine($"Coordinates: ({x}, {y})");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Speed: {speed}");
        Console.WriteLine($"Year: {year}");
    }
}

class Plane : Vehicle
{
    private double height;
    private int passengers;

    public Plane(double x, double y, double price, double speed, int year, double height, int passengers)
        : base(x, y, price, speed, year)
    {
        this.height = height;
        this.passengers = passengers;
    }

    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Passengers: {passengers}");
    }
}

class Car : Vehicle
{
    public Car(double x, double y, double price, double speed, int year)
        : base(x, y, price, speed, year)
    {
    }

    public void ShowInfo()
    {
        base.ShowInfo();
    }
}

class Ship : Vehicle
{
    private int passengers;
    private string port;

    public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
        : base(x, y, price, speed, year)
    {
        this.passengers = passengers;
        this.port = port;
    }

    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Passengers: {passengers}");
        Console.WriteLine($"Port: {port}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Plane plane = new Plane(100, 200, 100000, 500, 2010, 10000, 200);
        plane.ShowInfo();

        Console.WriteLine();

        Car car = new Car(50, 100, 50000, 200, 2015);
        car.ShowInfo();

        Console.WriteLine();

        Ship ship = new Ship(300, 400, 2000000, 100, 2020, 1000, "New York");
        ship.ShowInfo();
    }
}