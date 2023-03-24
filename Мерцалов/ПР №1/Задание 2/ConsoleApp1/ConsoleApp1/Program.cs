using System;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Toyota", "Corolla", 2015, 15000.0, "Corolla S");
        Car car2 = new Car("Honda", "Accord", 2018, 25000.0, "Accord LX");
        Car car3 = new Car("Ford", "Mustang", 2016, 30000.0, "Mustang GT");
        Car car4 = new Car("Chevrolet", "Camaro", 2019, 35000.0, "Camaro SS");

        car1.PrintInfo();
        car2.PrintInfo();
        car3.PrintInfo();
        car4.PrintInfo();

        Console.ReadLine();
    }

    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double price;
        private string name;

        public Car(string make, string model, int year, double price, string name)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.name = name;
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

        public void PrintInfo()
        {
            Console.WriteLine($"Car name: {Name}, Max speed: {CalculateMaxSpeed()} km/h");
        }

        private double CalculateMaxSpeed()
        {
            // This is just a dummy calculation for demonstration purposes.
            return 200.0 - (2022 - Year) * 10;
        }
    }
}
