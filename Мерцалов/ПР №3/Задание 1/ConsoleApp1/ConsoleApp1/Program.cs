using System;

public class Color
{
    private int red;
    private int black;
    private int white;

    public Color(int r, int b, int w)
    {
        red = r;
        black = b;
        white = w;
    }

    public int Red
    {
        get { return red; }
        set { red = value; }
    }

    public int Green
    {
        get { return black; }
        set { black = value; }
    }

    public int Blue
    {
        get { return white; }
        set { white = value; }
    }

    public override string ToString()
    {
        return String.Format("({0}, {1}, {2})", red, black, white);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Color myColor = new Color(255, 0, 0);
        Console.WriteLine("My color is " + myColor.ToString());
        myColor.Green = 255;
        Console.WriteLine("My color is " + myColor.ToString());
        Console.ReadLine();
    }
}
