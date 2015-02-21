using System;

namespace TheQuest
{
    public class Eagles : Item, IFly
    {
        private int flyingEffect = 5;

        public Eagles(Location position)
            : base("Eagles", position)
        {
            base.symbol = "U+101EE";
            base.description = "This item gives the team a prescious ability - to fly away from its enemies.";
        }

        public override string Description
        {
            get
            {
                return base.description;
            }
        }

        public override string Symbol
        {
            get
            {
                return base.symbol;
            }
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