using System;
using System.Collections.Generic;
using System.Text;

namespace Cappuccino.API
{
    public interface IDeathable
    {
        protected bool IsDead { get; set; }
    }
}
