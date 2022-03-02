using System;

public class Program
{
    static int Policz(int a, int b)
    {
        return a * b;
    }

    static void Main(string[] args)
    {
        Console.WriteLine($"W pierwszym branchu; 2+3={Policz(2, 3)}");
    }

}