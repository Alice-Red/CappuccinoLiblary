namespace Cappuccino.Graphics2D
{
    public class Scene: ViewBase
    {

        protected readonly Jogmaya root;
        public Scene(Jogmaya nt) {
            root = nt;
        }


        protected virtual void Initialization() {

        }

        ///// <summary>
        ///// レイヤーを上に重ねます
        ///// </summary>
        ///// <param name="layer"></param>
        //public void Add(Layer layer) {

        //}

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
