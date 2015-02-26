using System;

namespace TheQuest
{
    public class Eagles : Item, IFly
    {
        private int flyingEffect = 5;

        public Eagles(Location position)
            : base("Eagles", position)
        {
            base.symbol = "I";
            base.description = "This item gives the team a prescious ability - to fly away from its enemies.";
        }


        public int FlyingEffect
        {
            get
            {
                return this.flyingEffect;
            }
        }
    }
}