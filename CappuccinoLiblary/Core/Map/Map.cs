using System;
using System.Collections.Generic;
using System.Text;
using CappuccinoLibrary.Core.Base;

namespace CappuccinoLibrary.RPG
{
    public abstract class Map : Cappuccino
    {
        public string Name { get; protected set; }
    }
}
