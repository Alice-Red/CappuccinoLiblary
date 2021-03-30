using Cappuccino.Windows.Interface;

namespace Cappuccino.Graphics2D
{
    // 描画できるなにか
    public class Chimame/*:IClickable*/
    {
        public delegate void OnClickedHandler(object sender, ClickedArgs e);
        public event OnClickedHandler OnClicked;

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        //public event Chimame.OnClickedHandler OnClicked;
    }
}
