namespace AbstractFactory.Products.ArtDecoProducts;

public class ArtDecoChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on ArtDeco chair...");
    }
}