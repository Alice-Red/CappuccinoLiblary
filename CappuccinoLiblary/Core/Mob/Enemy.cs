using System;
using System.Collections.Generic;
using System.Text;
using CappuccinoLiblary.API.Mob;
using CappuccinoLiblary.Core;

namespace CappuccinoLiblary.RPG
{
    public abstract class Enemy : Mob, IAttackable
    {
        public abstract void Attack();

        public abstract override void Damage(int dmg);
    }
}
