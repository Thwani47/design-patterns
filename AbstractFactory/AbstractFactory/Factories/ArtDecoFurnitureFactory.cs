using AbstractFactory.Products;
using AbstractFactory.Products.ArtDecoProducts;

namespace AbstractFactory.Factories;

public class ArtDecoFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ArtDecoChair();
    }

    public ITable CreateTable()
    {
        return new ArtDecoTable();
    }

    public ISofa CreateSofa()
    {
        return new ArtDecoSofa();
    }
}