using System;
using System.Collections.Generic;
using System.Text;

namespace Cappuccino.Graphics2D.Effects
{
    public abstract class Animation
    {
        public Animation Loop() {
            return this;
        }
        public Animation LoopReverse() {
            return this;
        }

    }
}
