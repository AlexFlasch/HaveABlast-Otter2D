using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HaveABlast.Scenes;
using HaveABlast.Util;
using Otter;

namespace HaveABlast
{
    class HaveABlast
    {
        public static Game App;
        public static Session PlayerSession;
        public static AssetManager Manager;

        public static void Main()
        {
            App = new Game("Have a Blast!", 1027, 768);

            Manager = new AssetManager();

            App.SetWindow(1024, 768);
            App.MouseVisible = true;

            App.FirstScene = new SplashScene();
            App.Start();
        }
    }
}
