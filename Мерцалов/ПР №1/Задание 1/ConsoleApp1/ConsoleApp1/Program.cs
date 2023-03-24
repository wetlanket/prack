using System;

public class Car
{
    private string make;
    private string model;
    private int year;
    private double price;
    private string name;
    private double maxSpeed;

    public Car(string make, string model, int year, double price, string name, double maxSpeed)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.price = price;
        this.name = name;
        this.maxSpeed = maxSpeed;
    }

    public string Make
    {
        get { return make; }
        set { make = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double MaxSpeed
    {
        get { return maxSpeed; }
        set { maxSpeed = value; }
    }

    public void Display()
    {
        Console.WriteLine("{0} {1} ({2}) - ${3}", make, model, year, price);
    }

    public void DisplayMaxSpeed()
    {
        Console.WriteLine("Name: {0}, Max Speed: {1}", name, maxSpeed);
    }
}

public class Race
{
    private string name;
    private Car[] cars;
    private Random rand;

    public Race(string name, Car[] cars)
    {
        this.name = name;
        this.cars = cars;
        this.rand = new Random();
    }

    public void StartRace()
    {
        Console.WriteLine("Starting race: {0}", name);

        foreach (Car car in cars)
        {
            Console.WriteLine("Car: {0} {1}", car.Make, car.Model);
            double speed = rand.NextDouble() * car.MaxSpeed;
            Console.WriteLine("Max speed: {0:F2} mph", car.MaxSpeed);
            Console.WriteLine("Actual speed: {0:F2} mph", speed);
        }

        Console.WriteLine("Race ended: {0}", name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car[] cars = new Car[]
        {
            new Car("Tesla", "Model S", 2020, 80000.00, "Lightning", 150.0),
            new Car("Porsche", "911", 2021, 110000.00, "Thunder", 180.0),
            new Car("Audi", "R8", 2019, 175000.00, "Hurricane", 200.0),
            new Car("Lamborghini", "Aventador", 2022, 450000.00, "Typhoon", 220.0)
        };

        Race race = new Race("Super Car Race", cars);
        race.StartRace();

        Console.ReadLine();
    }
}
