namespace Cappuccino.Graphics2D
{
    public class Jogmaya
    {
        public delegate void OnClickedHandler(object sender, ClickedArgs e);
        public event OnClickedHandler OnClicked;

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
