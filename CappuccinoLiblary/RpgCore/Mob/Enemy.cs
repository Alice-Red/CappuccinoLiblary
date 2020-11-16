using System;
using System.Collections.Generic;
using System.Text;
using Cappuccino.API.Mob;
using Cappuccino.RpgCore;
using Cappuccino.RpgCore.Mob;

namespace Cappuccino.RpgCore.Mob
{
    public abstract class Enemy : Mob, IAttackable
    {
        public abstract void Attack();

        public abstract override void Damage(int dmg);
    }
}
