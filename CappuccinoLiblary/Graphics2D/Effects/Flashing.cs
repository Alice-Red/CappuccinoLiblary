using System;
using System.Collections.Generic;
using System.Text;

namespace Cappuccino.Graphics2D.Effects
{
    // アニメーションの一種
    // 点滅
    public class Flashing: Animation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="opacityA">変化前透明度</param>
        /// <param name="opacityB">変化後透明度</param>
        /// <param name="cycle">1サイクルの秒数</param>
        /// <param name="cycleGap">サイクル間の秒数</param>
        public Flashing(int opacityA, double opacityB, double cycle, double cycleGap) {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opacityA">変化前透明度</param>
        /// <param name="opacityB">変化後透明度</param>
        /// <param name="cycleA">変化後までの秒数</param>
        /// <param name="cycleB">戻るまでの秒数</param>
        /// <param name="cycleGap">サイクル間の秒数</param>
        public Flashing(int opacityA, double opacityB, double cycleA, double cycleB, double cycleGap) {

        }
    }
}
