using Microsoft.Xna.Framework;
using Nez;

namespace Charted_Waters;

public class Game1 : Core
{
    public Game1()
    {
        Window.AllowUserResizing = true;
        Window.Title = "Charted Waters";
    }

    protected override void Initialize()
    {
        base.Initialize();

        var scene = new Scene()
        {
            ClearColor = Color.CornflowerBlue
        };

        Scene = scene;
    }
}