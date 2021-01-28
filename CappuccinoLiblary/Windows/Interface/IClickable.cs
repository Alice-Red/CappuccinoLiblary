using System;
using System.Collections.Generic;
using System.Text;
using Cappuccino.Graphics2D;

namespace Cappuccino.Windows.Interface
{
    public interface IClickable
    {
        public delegate void OnClickedHandler(object sender, ClickedArgs e);
        public event Jogmaya.OnClickedHandler OnClicked;
    }
}
