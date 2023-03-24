class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Toyota", "Camry", 2020, 25000, "Camry XSE", 220);
        Car car2 = new Car("Honda", "Civic", 2019, 20000, "Civic LX", 190);

        Console.WriteLine(car1.DisplayCarInfo());
        Console.WriteLine(car2.DisplayCarInfo());
        Console.ReadKey();
    }
}

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
