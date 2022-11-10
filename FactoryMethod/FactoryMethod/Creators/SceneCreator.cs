using FactoryMethod.Products;

namespace FactoryMethod.Creators;

public abstract class SceneCreator
{
    public abstract IScene CreateScene();
}