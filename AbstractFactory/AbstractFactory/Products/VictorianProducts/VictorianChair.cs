namespace AbstractFactory.Products.VictorianProducts;

public class VictorianChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on Victorian chair...");
    }
}