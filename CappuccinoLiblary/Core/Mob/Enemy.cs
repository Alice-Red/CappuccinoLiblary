using System;
using System.Collections.Generic;
using System.Text;
using CappuccinoLibrary.API.Mob;
using CappuccinoLibrary.Core;

namespace CappuccinoLibrary.RPG
{
    public abstract class Enemy : Mob, IAttackable
    {
        public abstract void Attack();

        public abstract override void Damage(int dmg);
    }
}
