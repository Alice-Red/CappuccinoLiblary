using System;
using System.Collections.Generic;
using System.Text;
using CappuccinoLibrary.RPG;


namespace VirusFight.Entitiy
{
    public abstract class Virus :Enemy
    {
        protected int HP { get; set; }
        protected string Name { get; set; }
        protected int ATK { get; set; }




    }
}
