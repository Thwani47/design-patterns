using FactoryMethod.Products;

namespace FactoryMethod.Creators;

public class DesktopSceneCreator : SceneCreator
{
    public override IScene CreateScene()
    {
        return new DesktopScene();
    }
}