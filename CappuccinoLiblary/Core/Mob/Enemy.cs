using System;
using System.Collections.Generic;
using System.Text;
using CappuccinoLibrary.API.Mob;
using CappuccinoLibrary.Core;
using CappuccinoLibrary.Core.Mob;

namespace CappuccinoLibrary.Core.Mob
{
    public abstract class Enemy : Mob, IAttackable
    {
        public abstract void Attack();

        public abstract override void Damage(int dmg);
    }
}
