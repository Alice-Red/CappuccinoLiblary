using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Cappuccino.Graphics2D.Effects;
using Cappuccino.Graphics2D.Elements;
using RUtil;

namespace Cappuccino.Graphics2D
{
    // 実用的な描画オブジェクト
    public abstract class ViewBase : Jogmaya
    {

        public Area Bucket(int x, int y, Color color) {
            //TODO 色参照できないからここじゃないほうがいいカモメ
            if (x.Range(0, Width - 1) && y.Range(0, Height - 1)) {

            }
            //Parallel.For()
            return new Area();
        }

        public virtual ViewBase AddEasing(Easing easing, int time) {
            //TODO イージングなのはいいんですけど、各parameterにしたいんですよね、なので多分ここじゃない
            return this;
        }

        public virtual ViewBase AddAnimation(params Animation[] animate) {
            //TODO まだあり
            return this;
        }
    }
}
