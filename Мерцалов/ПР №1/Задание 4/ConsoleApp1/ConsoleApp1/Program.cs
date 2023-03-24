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

    public string DisplayCarInfo()
    {
        return "Car name: " + name + ", Max speed: " + maxSpeed + " km/h";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем массив из 4 автомобилей
        Car[] cars = new Car[4];
        cars[0] = new Car("Honda", "Civic", 2022, 22000, "Car1", 200);
        cars[1] = new Car("Toyota", "Corolla", 2022, 23000, "Car2", 190);
        cars[2] = new Car("Ford", "Fusion", 2022, 24000, "Car3", 180);
        cars[3] = new Car("Chevrolet", "Malibu", 2022, 25000, "Car4", 170);

        // Выводим информацию о каждом автомобиле на экран
        foreach (Car car in cars)
        {
            Console.WriteLine(car.DisplayCarInfo());
        }

        Console.WriteLine("\nLet the race begin!");

        // Генерируем случайные скорости для каждого автомобиля
        Random rnd = new Random();
        double[] speeds = new double[4];
        for (int i = 0; i < speeds.Length; i++)
        {
            speeds[i] = rnd.NextDouble() * cars[i].MaxSpeed / 2 + cars[i].MaxSpeed / 2;
        }
    }
}