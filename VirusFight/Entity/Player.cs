using System;
using System.Collections.Generic;
using System.Text;
using Cappuccino.API.Mob;
using Cappuccino.Core;
using Cappuccino.Core.Mob;

namespace VirusFight.Entity
{
    public class Player : Mob, IAttackable
    {
        protected int HP { get; set; }
        protected string Name { get; set; }
        protected int ATK { get; set; }

        public void Attack() {

        }

        public override void Damage(int dmg) {

        }
    }
}
