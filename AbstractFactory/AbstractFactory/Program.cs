using AbstractFactory.Factories;

Console.Write("Enter the type of furniture you want  [1 - ArtDeco, 2 - Modern, 3 - Victorian]: ");

var validInput = int.TryParse(Console.ReadLine(), out var input);

if (!validInput)
{
    throw new Exception("Invalid value provided. Only integers allowed. Please try again");
}

var factoryType = (FactoryType)input;

IFurnitureFactory factory;

switch (factoryType)
{
    case FactoryType.ArtDeco:
        factory = new ArtDecoFurnitureFactory();
        break;
    case FactoryType.Modern:
        factory = new ModernFurnitureFactory();
        break;
    case FactoryType.Victorian:
        factory = new VictorianFurnitureFactory();
        break;
    default:
        throw new Exception("Invalid value provided. Allowed values are (1, 2,3)");
}

var chair = factory.CreateChair();
chair.SitOn();

var table = factory.CreateTable();
table.EatOn();

var sofa = factory.CreateSofa();
sofa.LieOn();