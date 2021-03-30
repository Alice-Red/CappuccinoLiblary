using System;
using System.Collections.Generic;
using System.Text;
using Cappuccino.Graphics2D;
using Cappuccino.Graphics2D.Effects;

namespace NotLightWin.Scenes
{
    public class FindLightMain : Scene
    {
        public FindLightMain(Jogmaya jg) : base(jg) {
            Layer pl = new Layer();
            pl.Add(new Entities.PlayerMachine());
        }
    }
}
