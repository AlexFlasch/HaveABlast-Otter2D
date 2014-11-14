using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace HaveABlast.Scenes
{
    class MainMenuScene : Scene
    {

        private const string font = "../../Assets/Fonts/Thin_Line_Font.otf";

        public MainMenuScene()
        {
            Text titleText = new Text("Have A Blast!", font, 90);
            Text playText = new Text("Play", font, 70);
            Text optionsText = new Text("Options", font, 70);
            Text exitText = new Text("Exit", font, 70);

            exitText.Y = HaveABlast.App.WindowHeight - 100;
            exitText.X = 100;
            AddGraphic(exitText);

            optionsText.Y = HaveABlast.App.WindowHeight - 200;
            optionsText.X = 100;
            AddGraphic(optionsText);

            playText.Y = HaveABlast.App.WindowHeight - 300;
            playText.X = 100;
            AddGraphic(playText);

            titleText.Y = HaveABlast.App.WindowHeight - 400;
            titleText.X = 50;
            titleText.Color = Color.Black;
            titleText.OutlineColor = Color.White;
            titleText.OutlineThickness = 2;
            titleText.OutlineQuality = TextOutlineQuality.Best;
            AddGraphic(titleText);
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Render()
        {
            base.Render();
        }
    }
}
