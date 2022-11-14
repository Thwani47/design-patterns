namespace AbstractFactory.Products.ModernProducts;

public class ModernChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on Modern chair...");
    }
}