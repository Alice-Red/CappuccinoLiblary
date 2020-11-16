using System;

namespace Cappuccino.Graphics2D.Elements
{
    [Flags]
    public enum FontStyle
    {
        // 標準テキスト
        Regular = 0,

        // 太字テキスト
        Bold = 1,

        // 斜体テキスト
        Italic = 2,

        // 下線付きテキスト
        Underline = 4,

        // 中央に線が引かれているテキスト
        Strikeout = 8,
    }
}
