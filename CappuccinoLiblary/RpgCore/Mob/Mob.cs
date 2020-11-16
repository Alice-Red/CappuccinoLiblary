using Cappuccino.API.Mob;
using Cappuccino.RpgCore.Base;

namespace Cappuccino.RpgCore.Mob
{
    public abstract class Mob : Entity, IDeathable, IHitPoint
    {
        public abstract void Damage(int dmg);
    }
}
