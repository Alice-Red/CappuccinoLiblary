using System;
using System.Collections.Generic;
using System.Text;

namespace Cappuccino.Graphics2D.Effects
{
    public abstract class Animation
    {
        protected double Offset { get; set; } = 0.0;

        protected bool IsLoop { get; set; } = false;
        protected bool IsReverse { get; set; } = false;


        internal void Next() {

        }

        public void AddOffset() {

        }

        public Animation Loop(bool value = true) {
            IsLoop = value;
            return this;
        }
        
        public Animation LoopReverse(bool value = true) {
            return LoopReverse(true, value);
        }

        public Animation LoopReverse(bool loop, bool reverse) {
            IsLoop = loop;
            IsReverse = reverse;
            return this;

        }

        public virtual Animation AddEasing(Easing easing) {
            return this;
        }
        public virtual Animation AddEasing(Easing easing, double time) {
            // イージングするのはアニメーション関連だけと仮定
            // なので多分ここで良い
            return this;
        }

    }
}
