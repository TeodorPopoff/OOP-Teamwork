namespace TheQuest
{
    using System;

    public class Goblin : Enemy
    {

        public Goblin(string name, Location position)
            : base(name, position)
        {
            Random rnd = new Random();
            base.BattleStrength = (double)rnd.Next(50, 400);
            base.symbol = "O";
            base.description = " They lived deep under the Misty Mountains in many strongholds, ever since the War of Wrath in the First Age. They are big, ugly creatures, cruel, wicked, and bad-hearted.";
        }
    }
}