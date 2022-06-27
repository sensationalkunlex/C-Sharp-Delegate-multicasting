// See https://aka.ms/new-console-template for more information
public class DelegateClass
{
    public delegate void delegateDefination(double a, double b);
    public void Perimeter(double c, double d)
    {
        Console.WriteLine($"Perimeter {c + d}");
    }

    public void Area(double c, double d)
    {
        Console.WriteLine($"Area {c * d}");
    }
}