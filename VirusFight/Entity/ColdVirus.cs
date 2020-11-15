using System;
using System.Collections.Generic;
using System.Text;
using VirusFight.Entitiy;

namespace VirusFight.Entity
{
    public class ColdVirus : Virus
    {
        public override void Attack() { throw new NotImplementedException(); }
        public override void Damage(int dmg) { throw new NotImplementedException(); }
    }
}
