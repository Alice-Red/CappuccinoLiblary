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
        public Title(Jogmaya nt) : base(nt) {

        }

        protected override void Initialization() {
            Layer layer1 = new Layer();
            Letter title =
                new Letter(
                    "!light",
                    new Font("Consolas", 28, FontStyle.Underline | FontStyle.Bold),
                    Position.Centor(root)
                    );
            //layer1.Add(layer1.Bukket(0, 0, Color.White));
            layer1.Add(
                title.AddEasing(Easing.In.Quad, time: 1)
                .AddAnimation(new Flashing(opacityA: 1, opacityB: 0.9, cycle: 0.6, cycleGap: 0.2).LoopReverse(),
                    new Glowing(color: Color.Black, radius: 14, cycle: 0.6).LoopReverse())
            );
            layer1.AddEasing(Easing.Out.Quad, time: 4);
            Add(layer1);


        }
    }
}
