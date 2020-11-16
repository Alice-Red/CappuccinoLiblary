using System;
using System.Collections.Generic;
using System.Text;
using Cappuccino.Core.Mob;
using Cappuccino.API;


namespace VirusFight.Entitiy
{
    public abstract class Virus :Enemy
    {
        protected int HP { get; set; }
        protected string Name { get; set; }
        protected int ATK { get; set; }




    }
}
