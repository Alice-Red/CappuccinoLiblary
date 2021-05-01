using Cappuccino.Graphics2D;
using Cappuccino.Graphics2D.Effects;
using Cappuccino.Graphics2D.Elements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NotLightWin.Scenes
{
    public class Title : Scene
    {
        public Title(Chimame obj) : base(obj) {

        }

        protected override void Initialization() {
            Layer layer1 = new Layer();
            Letter title = new Letter(
                "!light",
                new Font(@"Consolas", 28, FontStyle.Underline | FontStyle.Bold),
                  root.Center()  //Position.Center(root)
                );
            //layer1.Add(layer1.bucket(0, 0, Color.White));
            layer1.Add(
                title.AddAnimation(Fade.In(1).AddEasing(Easing.In.Quad))
                .AddAnimation(
                    new Flashing(opacityA: 1, opacityB: 0.9, cycle: 0.6, cycleGap: 0.2).LoopReverse(),
                    new Glowing(color: Color.Black, range: 14, cycle: 0.6).LoopReverse()
                    )
            );
            layer1.AddAnimation(Fade.In(4).AddEasing(Easing.Out.Quad));
            layer1.OnClicked += Layer1_OnClicked;
            Add(layer1);
        }

        private void Layer1_OnClicked(object sender, ClickedArgs e) {
            // TODO 画面クリック時
        }
    }
}
