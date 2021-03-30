using Cappuccino.API;
using Cappuccino.RpgCore.Base;

namespace Cappuccino.RpgCore.Mob
{
    public abstract class Mob : Entity, IDeathable, IHitPoint
    {
        public abstract void Damage(int dmg);
    }
}
