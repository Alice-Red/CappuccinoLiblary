using System;
using System.Collections.Generic;
using System.Text;
using CappuccinoLibrary.API.Mob;
using CappuccinoLibrary.Core;

namespace VirusFight.Entitiy
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
