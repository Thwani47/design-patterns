using FactoryMethod.Products;

namespace FactoryMethod.Creators;

public class MobileSceneCreator : SceneCreator
{
    public override IScene CreateScene()
    {
        return new MobileScene();
    }
}