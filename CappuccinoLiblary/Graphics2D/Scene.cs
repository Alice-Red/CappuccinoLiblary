namespace Cappuccino.Graphics2D
{
    public class Scene: ViewBase
    {

        protected readonly Chimame root;
        public Scene(Chimame cpcp) {
            root = cpcp;
        }


        protected virtual void Initialization() {

        }

        /// <summary>
        /// 指定した位置にレイヤーを敷きます
        /// </summary>
        /// <param name="layer"></param>
        /// <param name="index"></param>
        public void Add(Layer layer, int index) {

        }

        /// <summary>
        /// レイヤーを配列で受けとります
        /// </summary>
        /// <param name="layer"></param>
        public void Add(params Layer[] layer) {

        }
    }
}
