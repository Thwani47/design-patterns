using AbstractFactory.Products;
using AbstractFactory.Products.VictorianProducts;

namespace AbstractFactory.Factories;

public class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new VictorianChair();
    }

    public ITable CreateTable()
    {
        return new VictorianTable();
    }

    public ISofa CreateSofa()
    {
        return new VictorianSofa();
    }
}