using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Otter;

namespace HaveABlast.Scenes
{
    
    public class SplashScene : Scene
    {

        private Image splashImage;

        public SplashScene()
        {
            splashImage = new Image("../../Assets/Images/HaveABlastSplash.png");
            splashImage.ScaleX = (float) HaveABlast.App.WindowWidth / splashImage.Width;
            splashImage.ScaleY = (float) HaveABlast.App.WindowHeight / splashImage.Height;
            AddGraphic(splashImage);
        }

        public override void Update()
        {
            HaveABlast.App.RemoveScene();
            HaveABlast.App.AddScene(new MainMenuScene());
        }
    }
}
