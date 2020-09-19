using System;
using System.Collections.Generic;
using System.Text;
using CappuccinoLibrary.API;
using CappuccinoLibrary.Core.Base;

namespace CappuccinoLibrary.Core
{
    public abstract class Mob : Entitiy, IDethable, IHitPoint
    {
        public abstract void Damage(int dmg);
    }
}
