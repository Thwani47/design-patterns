namespace AbstractFactory.Products.VictorianProducts;

public class VictorianTable : ITable
{
    public void EatOn()
    {
        Console.WriteLine("Eating on Victorian table...");
    }
}