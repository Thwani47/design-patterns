using FactoryMethod.Creators;
using FactoryMethod.Enums;
using FactoryMethod.Products;

Console.Write("Enter the type of scene to be created. [0 - Mobile, 1 - Desktop]: ");

if (int.TryParse(Console.ReadLine(), out var input))
{
    var sceneType = (SceneType)input;
    var mobileSceneCreator = new MobileSceneCreator();
    var desktopSceneCreator = new DesktopSceneCreator();

    IScene scene;

    switch (sceneType)
    {
        case SceneType.Mobile:
            scene = mobileSceneCreator.CreateScene();
            break;
        case SceneType.Desktop:
            scene = desktopSceneCreator.CreateScene();
            break;
        default:
            throw new Exception("Unknown scene type provided");
    }

    scene.Render();
}
else
{
    Console.WriteLine("Invalid input provided. Numbers only allowed. Please rerun the program and try again.");
}