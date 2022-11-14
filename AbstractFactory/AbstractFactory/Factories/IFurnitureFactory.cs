using AbstractFactory.Products;

namespace AbstractFactory.Factories;

public interface IFurnitureFactory
{
    IChair CreateChair();
    ITable CreateTable();
    ISofa CreateSofa();
}