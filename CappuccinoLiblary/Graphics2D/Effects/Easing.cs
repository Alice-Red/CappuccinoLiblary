using System;
using System.Collections.Generic;
using System.Text;

namespace Cappuccino.Graphics2D.Effects
{
    // 書き方を優先したイージング
    // どうなるかわからん
    public class Easing
    {
        public string Formula;

        public Easing(string fml) {
            Formula = fml;
        }

        public Position Calc(double timing) {
            var fml = Formula.Replace("x", timing + "");
        }













        public static Easing Liner;

        public static class In
        {
            public static Easing Sine;
            public static Easing Quad;
            public static Easing Cubic;
            public static Easing Quart;
            public static Easing Quint;
            public static Easing Expo;
            public static Easing Circ;
            public static Easing Back;
            public static Easing Elastic;
            public static Easing Bounce;
        }

        public static class Out
        {
            public static Easing Sine;
            public static Easing Quad;
            public static Easing Cubic;
            public static Easing Quart;
            public static Easing Quint;
            public static Easing Expo;
            public static Easing Circ;
            public static Easing Back;
            public static Easing Elastic;
            public static Easing Bounce;
        }

        public static class InOut
        {
            public static Easing Sine;
            public static Easing Quad;
            public static Easing Cubic;
            public static Easing Quart;
            public static Easing Quint;
            public static Easing Expo;
            public static Easing Circ;
            public static Easing Back;
            public static Easing Elastic;
            public static Easing Bounce;
        }

        public static class OutIn
        {
            public static Easing Sine;
            public static Easing Quad;
            public static Easing Cubic;
            public static Easing Quart;
            public static Easing Quint;
            public static Easing Expo;
            public static Easing Circ;
            public static Easing Back;
            public static Easing Elastic;
            public static Easing Bounce;
        }



    }
}
