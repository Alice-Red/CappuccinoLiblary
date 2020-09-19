using CappuccinoLibrary.API.Mob;
using CappuccinoLibrary.Core.Base;

namespace CappuccinoLibrary.Core.Mob
{
    public abstract class Mob : Entity, IDeathable, IHitPoint
    {
        public abstract void Damage(int dmg);
    }
}
