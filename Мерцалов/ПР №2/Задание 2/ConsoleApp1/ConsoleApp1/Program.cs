using System;

public class NumberIncrementer
{
    private int a = 0;

    public bool SetNumber(int number)
    {
        if (number == a + 1)
        {
            a = number;
            return true;
        }
        else
        {
            a = 0;
            return false;
        }
    }

    public int GetExpectedNumber()
    {
        return a + 1;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        NumberIncrementer incrementer = new NumberIncrementer();

        Console.WriteLine("Введите число 1:");
        int number = int.Parse(Console.ReadLine());

        while (true)
        {
            if (incrementer.SetNumber(number))
            {
                Console.WriteLine("Введите число " + incrementer.GetExpectedNumber() + ":");
                number = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Неверное число . Начинать все сначала.");
                Console.WriteLine("Введите число 1:");
                number = int.Parse(Console.ReadLine());
            }
        }
    }
}
