using System;

namespace TheQuest
{
    public class Goblin : Character, IEnemy
    {
        private int battleStrength = 80;
        private bool isAlive = true;

             public Goblin(string name, Location position)
            : base(name, position)
        {
            base.symbol = "u+0045";
            base.description = " They lived deep under the Misty Mountains in many strongholds, ever since the War of Wrath in the First Age. They are big, ugly creatures, cruel, wicked, and bad-hearted.";
        }

             public override bool IsAlive
             {
                 get
                 {
                     return this.IsAlive;
                 }
             }

             public override string Description
             {
                 get
                 {
                     return base.description;
                 }
             }

             public override int BattleStrength
             {
                 get
                 {
                     return this.battleStrength;
                 }

                 set
                 {
                     if (value <= 0)
                     {
                         this.isAlive = false;
                     }
                     this.battleStrength = value;
                 }
             }
    }


}