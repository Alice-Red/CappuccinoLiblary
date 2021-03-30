using System;
using System.Collections.Generic;
using System.Text;
using NotLightWin.Scenes;
using Cappuccino.Graphics2D;

namespace NotLightWin
{
    public class NotLight : Cappuccino.Windows.GameWindow
    {

        public NotLight() {
            Initialization();
        }

        protected override void Initialization() {
            this.FullScreen = false;
            this.Width = 1280;
            this.Height = 720;
            Scene title = new Title(this);
            Scene game = new FindLightMain(title);
            Scene result = new Result(game);
            this.AddScene(title);
            this.AddScene(game);
            this.AddScene(result);


        }

        public void Boot() {
            this.Start();

        }


        //protected override 


    }
}
