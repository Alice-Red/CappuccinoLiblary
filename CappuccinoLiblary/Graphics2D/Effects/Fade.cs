using System;
using System.Collections.Generic;
using System.Text;

namespace Cappuccino.Graphics2D.Effects
{
    // in
    // out
    public class Fade : Animation
    {
        public static Fade Out() {
            return new Fade();
        }
        public static Fade Out(double duration) {
            return new Fade();
        }
        public static Fade In() {
            return new Fade();
        }
        public static Fade In(double duration) {
            return new Fade();
        }
    }
}
