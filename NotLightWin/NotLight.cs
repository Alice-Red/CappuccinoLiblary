using System;
using System.Collections.Generic;
using System.Text;
using NotLightWin.Scenes;

namespace NotLightWin
{
    public class NotLight : Cappuccino.Windows.GameWindow
    {

        public NotLight() {

        }

        protected override void Initialization() {
            this.FullScreen = false;
            this.Width = 1270;
            this.Height = 720;
            this.AddScene(new Title(this));


        }

        public void Boot() {

        }


        //protected override 


    }
}
