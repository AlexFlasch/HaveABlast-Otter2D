using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Otter;

namespace OtterPongGame {
    class Program {
        static void Main(string[] args) {
            Game game = new Game("Otter Pong", 1000, 750);

            Global.PlayerOne = game.AddSession("P1");
            Global.PlayerTwo = game.AddSession("P2");

            Global.PlayerOne.Controller.Up.AddKey(Key.W);
            Global.PlayerOne.Controller.Down.AddKey(Key.S);

            Global.PlayerTwo.Controller.Up.AddKey(Key.Up);
            Global.PlayerTwo.Controller.Down.AddKey(Key.Down);

            game.FirstScene = new PongScene();

            game.Start();
        }
    }
}
