﻿using System;
using System.Collections.Generic;
using System.Text;
using Cappuccino.Graphics2D;

namespace Cappuccino.Windows
{
    public abstract class GameWindow : Graphics2D.Chimame
    {

        public bool FullScreen { get; set; }
        
        protected abstract void Initialization();

        protected void AddScene(Scene scene) {


        }



        protected void Start() {

        }
    }
}
