using System;
using System.Collections.Generic;
using System.Text;
using CappuccinoLiblary.API;
using CappuccinoLiblary.Core.Base;

namespace CappuccinoLiblary.Core
{
    public abstract class Mob : Entitiy, IDethable, IHitPoint
    {
        public abstract void Damage(int dmg);
    }
}
