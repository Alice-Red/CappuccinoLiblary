﻿using System;
using System.Collections.Generic;
using System.Text;
using Cappuccino.Graphics2D;
using Cappuccino.Graphics2D.Effects;

namespace NotLightWin.Scenes
{
    public class FindLightMain : Scene
    {
        public FindLightMain(Chimame obj) : base(obj) {
            Layer pl = new Layer();
            pl.Add(new Entities.PlayerMachine());
        }
    }
}
