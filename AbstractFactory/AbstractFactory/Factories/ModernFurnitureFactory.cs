using AbstractFactory.Products;
using AbstractFactory.Products.ModernProducts;

namespace AbstractFactory.Factories;

public class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public ITable CreateTable()
    {
        return new ModernTable();
    }

    public ISofa CreateSofa()
    {
        return new ModernSofa();
    }
}